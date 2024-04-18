using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FileLockerLibrary.Models;

/// <summary>
/// Metadata about a file.
/// </summary>
public class FileModel
{
    /// <summary>
    /// Gets or sets the path to the file.
    /// </summary>
    public string Path { get; set; }

    private string password;

    /// <summary>
    /// Gets or sets the password associated with the file.
    /// </summary>
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

    /// <summary>
    /// Gets or sets the encryption algorithm used for encrypting the file.
    /// </summary>
    public EncryptionAlgorithm EncryptionAlgorithm { get; set; }

    /// <summary>
    /// Gets or sets the encryption key used to encrypt the file content.
    /// </summary>
    [JsonIgnore]
    public byte[] EncryptionKey { get; set; }

    private byte[] encryptionKeySalt;

    /// <summary>
    /// Gets or sets the salt used in the derivation of the encryption key.
    /// </summary>
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

    /// <summary>
    /// Gets a value indicating whether the file is encrypted.
    /// </summary>
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

    /// <summary>
    /// Gets or sets the salt used in the derivation of the MAC key.
    /// </summary>
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

    /// <summary>
    /// Gets or sets the MAC key used for file integrity verification.
    /// </summary>
    [JsonIgnore]
    public byte[] MacKey { get; set; }

    /// <summary>
    /// Gets or sets the MAC (Message Authentication Code) for file integrity verification.
    /// </summary>
    public byte[] Mac { get; set; }

    /// <summary>
    /// Gets or sets the digital signature of the file.
    /// </summary>
    public byte[] DigSig { get; set; }

    /// <summary>
    /// Gets or sets the digital signature algorithm used for signing the file.
    /// </summary>
    public DigSigAlgorithm DigSigAlgorithm { get; set; }

    /// <summary>
    /// Gets a display string describing the digital signature status of the file.
    /// </summary>
    [JsonIgnore]
    public string DigSigDisplay
    {
        get
        {
            if (DigSig == null)
                return "None";

            byte[] content = File.ReadAllBytes(Path);
            List<KeyPairModel> allKeyPairs = GlobalConfig.DataAccessor.LoadAllPublicKeyPairModels();
            allKeyPairs.AddRange(GlobalConfig.DataAccessor.LoadAllPrivateKeyPairModels());

            foreach (KeyPairModel keyPairModel in allKeyPairs)
                if (GlobalConfig.Signer(DigSigAlgorithm).Verify(keyPairModel.PublicKey, DigSig, content))
                    return $"Signed by \'{keyPairModel.Name}\' using {keyPairModel.Algorithm}";

            return "Unknown signer or tampered data";
        }
    }

    /// <summary>
    /// Gets a display name for the file, including encryption status and file name.
    /// </summary>
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

    /// <summary>
    /// Gets the name of the file.
    /// </summary>
    [JsonIgnore]
    public string FileName
    {
        get
        {
            return System.IO.Path.GetFileName(Path);
        }
    }

    /// <summary>
    /// Gets the SHA hash of the file content.
    /// </summary>
    [JsonIgnore]
    public byte[] Sha
    {
        get
        {
            byte[] data = File.ReadAllBytes(Path);
            return GlobalConfig.Hasher.Hash(data);
        }
    }


    /// <summary>
    /// Gets the size of the file in bytes.
    /// </summary>
    [JsonIgnore]
    public int SizeInBytes
    {
        get
        {
            byte[] data = File.ReadAllBytes(Path);
            return data.Length;
        }
    }

    /// <summary>
    /// Gets or sets the date when the file was added.
    /// </summary>
    public DateTime DateAdded { get; set; }

    /// <summary>
    /// Locks the file by encrypting it, generating a MAC, and removing any digital signature.
    /// </summary>
    /// <param name="encryptionAlgorithm">The encryption algorithm to use for encryption.</param>
    public void Lock(EncryptionAlgorithm encryptionAlgorithm)
    {
        Encrypt(encryptionAlgorithm);
        GenerateMac();
        RemoveDigSig();
    }

    /// <summary>
    /// Unlocks the file by decrypting it, removing the MAC, and removing any digital signature.
    /// </summary>
    public void Unlock()
    {
        Decrypt();
        RemoveMac();
        RemoveDigSig();
    }

    /// <summary>
    /// Encrypts the file using the specified encryption algorithm.
    /// </summary>
    /// <param name="encryptionAlgorithm">The encryption algorithm to use.</param>
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

    /// <summary>
    /// Decrypts the file.
    /// </summary>
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
            GlobalConfig.Logger.Log($"Failed decryption with {EncryptionAlgorithm} - {FileName}", LogLevel.Warning);

            throw new CryptographicException("Decryption Failed.", ex);
        }

        GlobalConfig.Logger.Log($"File decrypted with {EncryptionAlgorithm} - {FileName}", LogLevel.Information);
    }

    /// <summary>
    /// Validates the integrity of the file by verifying its MAC.
    /// </summary>
    /// <returns>True if the integrity check succeeds; otherwise, false.</returns>
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

    /// <summary>
    /// Generates the MAC (Message Authentication Code) for the file.
    /// </summary>
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

    /// <summary>
    /// Removes the MAC from the file.
    /// </summary>
    private void RemoveMac()
    {
        Mac = new byte[0];
        MacKeySalt = new byte[0];
        GlobalConfig.DataAccessor.SaveFileModel(this);
    }

    /// <summary>
    /// Generates a digital signature for the file using the specified key pair model and password.
    /// </summary>
    /// <param name="keyPairModel">The key pair model containing the private key for signing.</param>
    /// <param name="password">The password used to decrypt the private key.</param>
    public void GenerateDigSig(KeyPairModel keyPairModel, string password)
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

        GlobalConfig.Logger.Log($"File signed with {DigSigAlgorithm} - {FileName}", LogLevel.Information);
    }

    /// <summary>
    /// Removes the digital signature from the file.
    /// </summary>
    public void RemoveDigSig()
    {
        DigSig = null;
        GlobalConfig.DataAccessor.SaveFileModel(this);
    }

    /// <summary>
    /// Overwrites the file with random data and then deletes it, making it unrecoverable.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the file path is null or empty.</exception>
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
    }
}
