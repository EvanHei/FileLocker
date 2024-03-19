using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public class FileModel
{
    public string Path { get; set; }

    private string password;
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

    public EncryptionAlgorithm EncryptionAlgorithm { get; set; }

    private byte[] encryptionKey;
    public byte[] EncryptionKey
    {
        get
        {
            return encryptionKey;
        }
        set
        {
            if (value == null)
                throw new ArgumentNullException("Encryption key cannot be null.");
            if (value.Length != 32 && value.Length != 24)
                throw new ArgumentException("Invalid encryption key length. Expected 32 or 24 bytes.");

            encryptionKey = value;
        }
    }

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

    private byte[] macKey;
    public byte[] MacKey
    {
        get
        {
            return macKey;
        }
        set
        {
            if (value == null)
                throw new ArgumentNullException("MAC key cannot be null.");
            if (value.Length != 32)
                throw new ArgumentException("Invalid MAC key length. Expected 32 bytes.");

            macKey = value;
        }
    }

    private byte[] mac;
    public byte[] Mac
    {
        get
        {
            return mac;
        }
        set
        {
            mac = value;
        }
    }

    public string DisplayName
    {
        get
        {
            string output = "";

            if (EncryptionStatus == true)
                output += "🔐";
            else if (EncryptionStatus == false)
                output += "📄 ";

            string fileName = FileName.Length > 50 ? FileName.Substring(0, 47) + "..." : FileName;
            output += $" {fileName}";

            return output;
        }
    }

    public string FileName
    {
        get
        {
            return System.IO.Path.GetFileName(Path);
        }
    }

    // throws FileNotFoundException and others
    public void Lock()
    {
        Encrypt();
        GenerateMac();

        GlobalConfig.Logger.Info($"File Locked - {FileName}");
    }

    public void Unlock()
    {
        Decrypt();
        RemoveMac();

        GlobalConfig.Logger.Info($"File Unlocked - {FileName}");
    }

    private void Encrypt()
    {
        if (!File.Exists(Path))
            throw new FileNotFoundException("The file was either moved or deleted.", Path);
        if (Password == null)
            throw new NullReferenceException("Password must be set.");
        if (EncryptionStatus == true)
            return;

        // read plaintext
        string plaintextFilePath = Path;
        byte[] content = File.ReadAllBytes(Path);

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
        byte[] ciphertext = GlobalConfig.Encryptor(EncryptionAlgorithm).Encrypt(content, EncryptionKey);

        // overwrite plaintext
        File.WriteAllBytes(Path, ciphertext);
        GlobalConfig.DataAccessor.ShredFile(plaintextFilePath);
    }

    private void Decrypt()
    {
        if (!File.Exists(Path))
            throw new FileNotFoundException("The file was either moved or deleted.", Path);
        if (Password == null)
            throw new NullReferenceException("Password must be set.");
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
            throw new CryptographicException("Unable to decrypt.", ex);
        }
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

        return output;
    }

    private void RemoveMac()
    {
        Mac = new byte[0];
        MacKeySalt = new byte[0];
    }

    public FileModel(string path)
    {
        Path = path;
        encryptionKeySalt = new byte[0];
        macKeySalt = new byte[0];
        mac = new byte[0];

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
