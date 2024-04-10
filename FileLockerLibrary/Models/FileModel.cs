using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public class FileModel
{
    public string Path { get; set; }

    private string password;

    [JsonIgnore]
    public string Password
    {
        get { return password; }
        set
        {
            password = value;

            if (EncryptionKeySalt != null)
                if (EncryptionAlgorithm == EncryptionAlgorithm.AES)
                    EncryptionKey = GlobalConfig.KeyDeriver.DeriveKey(Password, EncryptionKeySalt, 32);
                else if (EncryptionAlgorithm == EncryptionAlgorithm.TripleDES)
                    EncryptionKey = GlobalConfig.KeyDeriver.DeriveKey(Password, EncryptionKeySalt, 24);

            if (MacKeySalt != null)
                MacKey = GlobalConfig.KeyDeriver.DeriveKey(Password, MacKeySalt);
        }
    }

    [JsonIgnore]
    public EncryptionAlgorithm EncryptionAlgorithm { get; set; }

    [JsonIgnore]
    public byte[] EncryptionKey { get; set; }

    private byte[] encryptionKeySalt;

    public byte[] EncryptionKeySalt
    {
        get { return encryptionKeySalt; }
        set
        {
            encryptionKeySalt = value;

            if (Password != null && value != null)
                if (EncryptionAlgorithm == EncryptionAlgorithm.AES)
                    EncryptionKey = GlobalConfig.KeyDeriver.DeriveKey(Password, EncryptionKeySalt, 32);
                else if (EncryptionAlgorithm == EncryptionAlgorithm.TripleDES)
                    EncryptionKey = GlobalConfig.KeyDeriver.DeriveKey(Password, EncryptionKeySalt, 24);
        }
    }

    [JsonIgnore]
    public bool EncryptionStatus
    {
        get
        {
            bool output = false;

            if (System.IO.Path.GetExtension(Path).Equals(Constants.AesExtension) ||
                System.IO.Path.GetExtension(Path).Equals(Constants.TripleDesExtension))
                output = true;

            return output;
        }
    }

    private byte[] macKeySalt;
    public byte[] MacKeySalt
    {
        get { return macKeySalt; }
        set
        {
            macKeySalt = value;

            if (Password != null && value != null)
                MacKey = GlobalConfig.KeyDeriver.DeriveKey(Password, MacKeySalt);
        }
    }

    [JsonIgnore]
    public byte[] MacKey { get; set; }

    public byte[] Mac { get; set; }

    public byte[] DigSig { get; set; }

    public DigSigAlgorithm DigSigAlgorithm { get; set; }

    [JsonIgnore]
    public string DigSigDisplay
    {
        get
        {
            if (DigSig == null)
                return "No signature";

            byte[] content = File.ReadAllBytes(Path);
            List<KeyPairModel> allKeyPairs = GlobalConfig.DataAccessor.LoadAllPublicKeyPairModels();
            allKeyPairs.AddRange(GlobalConfig.DataAccessor.LoadAllPrivateKeyPairModels());

            foreach (KeyPairModel keyPairModel in allKeyPairs)
                if (GlobalConfig.Signer(DigSigAlgorithm).Verify(keyPairModel.PublicKey, DigSig, content))
                    return $"Signed by \'{keyPairModel.Name}\' using {keyPairModel.Algorithm}";

            return "Unknown signer or tampered data";
        }
    }

    [JsonIgnore]
    public string DisplayName
    {
        get
        {
            string output = "";

            if (EncryptionStatus == true)
                output += "🔐";
            else if (EncryptionStatus == false)
                output += "📄 ";

            string fileName = FileName.Length > 35 ? FileName.Substring(0, 32) + "..." : FileName;
            output += $" {fileName}";

            return output;
        }
    }

    [JsonIgnore]
    public string FileName
    {
        get
        {
            return System.IO.Path.GetFileName(Path);
        }
    }

    [JsonIgnore]
    public byte[] Sha
    {
        get
        {
            byte[] data = File.ReadAllBytes(Path);
            return GlobalConfig.Hasher.Hash(data);
        }
    }

    [JsonIgnore]
    public int SizeInBytes
    {
        get
        {
            byte[] data = File.ReadAllBytes(Path);
            return data.Length;
        }
    }

    public DateTime DateAdded { get; set; }

    public void Lock(EncryptionAlgorithm encryptionAlgorithm)
    {
        Encrypt(encryptionAlgorithm);
        GenerateMac();
        RemoveDigSig();
    }

    public void Unlock()
    {
        Decrypt();
        RemoveMac();
        RemoveDigSig();
    }

    private void Encrypt(EncryptionAlgorithm encryptionAlgorithm)
    {
        if (!File.Exists(Path))
            throw new FileNotFoundException("The file was either moved or deleted.", Path);
        if (Password == null)
            throw new NullReferenceException("Password must be set.");
        if (EncryptionStatus == true)
            return;

        EncryptionAlgorithm = encryptionAlgorithm;

        // read plaintext
        byte[] content = File.ReadAllBytes(Path);
        ShredFile();

        switch (EncryptionAlgorithm)
        {
            case EncryptionAlgorithm.AES:
                Path += Constants.AesExtension;
                break;
            case EncryptionAlgorithm.TripleDES:
                Path += Constants.TripleDesExtension;
                break;
            default:
                throw new ArgumentException("Unsupported encryption algorithm.", nameof(EncryptionAlgorithm));
        }

        // encrypt
        EncryptionKeySalt = GlobalConfig.KeyDeriver.GenerateSalt();
        byte[] ciphertext = GlobalConfig.Encryptor(EncryptionAlgorithm).Encrypt(content, EncryptionKey, Constants.MaxFileSize);

        // overwrite plaintext
        File.WriteAllBytes(Path, ciphertext);

        GlobalConfig.Logger.Log($"File encrypted with {encryptionAlgorithm} - {System.IO.Path.GetFileNameWithoutExtension(FileName)}", LogLevel.Information);
    }

    private void Decrypt()
    {
        if (!File.Exists(Path))
            throw new FileNotFoundException("The file was either moved or deleted.", Path);
        if (Password == null)
            throw new NullReferenceException("Password must be set.");
        if (ValidateIntegrity() == false)
            throw new CryptographicException("Integrity check failed.");
        if (EncryptionStatus == false)
            return;

        try
        {
            // read ciphertext
            string ciphertextPath = Path;
            byte[] content = File.ReadAllBytes(ciphertextPath);

            // decrypt
            byte[] plaintext = GlobalConfig.Encryptor(EncryptionAlgorithm).Decrypt(content, EncryptionKey);

            // write plaintext
            Path = System.IO.Path.ChangeExtension(Path, null);
            File.WriteAllBytes(Path, plaintext);

            // cleanup
            EncryptionKeySalt = new byte[0];
            File.Delete(ciphertextPath);
        }
        catch (Exception ex)
        {
            throw new CryptographicException("Decryption Failed.", ex);
        }

        GlobalConfig.Logger.Log($"File decrypted with {EncryptionAlgorithm} - {FileName}", LogLevel.Information);
    }

    public bool ValidateIntegrity()
    {
        if (!File.Exists(Path))
            throw new FileNotFoundException("The file was either moved or deleted.", Path);
        if (Mac == null)
            throw new NullReferenceException("MAC must be set.");
        if (MacKey == null)
            throw new NullReferenceException("MAC key must be set.");

        GlobalConfig.MacGenerator.Key = MacKey;

        byte[] content = File.ReadAllBytes(Path);
        bool output = GlobalConfig.MacGenerator.ValidateMac(content, Mac);

        if (output == false)
            GlobalConfig.Logger.Log($"Integrity check failed, incorrect password or tampering - {FileName}", LogLevel.Warning);

        return output;
    }

    private void GenerateMac()
    {
        if (!File.Exists(Path))
            throw new FileNotFoundException("The file was either moved or deleted.", Path);
        if (Password == null)
            throw new NullReferenceException("Password must be set.");
        if (EncryptionStatus == false)
            return;

        MacKeySalt = GlobalConfig.KeyDeriver.GenerateSalt();
        GlobalConfig.MacGenerator.Key = MacKey;

        byte[] content = File.ReadAllBytes(Path);
        Mac = GlobalConfig.MacGenerator.GenerateMac(content);
    }

    private void RemoveMac()
    {
        Mac = new byte[0];
        MacKeySalt = new byte[0];
    }

    public void Sign(KeyPairModel keyPairModel, string password)
    {
        if (!File.Exists(Path))
            throw new FileNotFoundException("The file was either moved or deleted.", Path);
        if (keyPairModel == null)
            throw new NullReferenceException("keyPair cannot be null.");

        DigSigAlgorithm = keyPairModel.Algorithm;

        // read data
        byte[] content = File.ReadAllBytes(Path);

        // temporarily decrypt the private key
        byte[] encryptedPrivateKey = keyPairModel.PrivateKey;
        byte[] encryptionKey = GlobalConfig.KeyDeriver.DeriveKey(password);
        keyPairModel.PrivateKey = GlobalConfig.Encryptor(EncryptionAlgorithm.AES).Decrypt(keyPairModel.PrivateKey, encryptionKey);

        // create digital signature
        DigSig = GlobalConfig.Signer(DigSigAlgorithm).Sign(keyPairModel.PrivateKey, content);

        keyPairModel.PrivateKey = encryptedPrivateKey;
    }

    private void RemoveDigSig()
    {
        DigSig = null;
    }

    public void ShredFile()
    {
        if (string.IsNullOrEmpty(Path))
            throw new ArgumentException("Path cannot be null or empty.", nameof(Path));

        using (FileStream stream = new(Path, FileMode.Open, FileAccess.Write))
        {
            Random random = new();
            byte[] buffer = new byte[1024];

            // overwrite with random data
            long remainingBytes = stream.Length;
            while (remainingBytes > 0)
            {
                // calculate the size of the next chunk to overwrite
                int chunkSize = (int)Math.Min(buffer.Length, remainingBytes);
                random.NextBytes(buffer);
                stream.Write(buffer, 0, chunkSize);
                remainingBytes -= chunkSize;
            }
        }

        File.Delete(Path);
    }

    public FileModel(string path)
    {
        Path = path;
        encryptionKeySalt = new byte[0];
        macKeySalt = new byte[0];
        Mac = new byte[0];

        string extension = System.IO.Path.GetExtension(path).ToLower();
        switch (extension)
        {
            case Constants.AesExtension:
                EncryptionAlgorithm = EncryptionAlgorithm.AES;
                break;
            case Constants.TripleDesExtension:
                EncryptionAlgorithm = EncryptionAlgorithm.TripleDES;
                break;
        }
    }
}
