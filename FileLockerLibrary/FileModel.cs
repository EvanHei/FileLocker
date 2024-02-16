using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

/// <summary>
/// Represents a file model containing content, path, password, and encryption-related properties and methods.
/// </summary>
public class FileModel
{
    /// <summary>
    /// The path of the file.
    /// </summary>
    public string Path { get; set; }

    /// <summary>
    /// The password used for encryption and decryption.
    /// </summary>
    public string Password { get; set; }

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
            if (value.Length != 32)
                throw new ArgumentException("Invalid encryption key length. Expected 32 bytes.");

            encryptionKey = value;
        }
    }

    /// <summary>
    /// The salt used in deriving the encryption key.
    /// </summary>
    public byte[] EncryptionKeySalt { get; set; }

    /// <summary>
    /// The status of encryption for the file.
    /// </summary>
    public bool EncryptionStatus
    {
        get
        {
            return System.IO.Path.GetExtension(Path).Equals(Constants.EncryptedExtension, StringComparison.OrdinalIgnoreCase);
        }
    }

    public bool IntegrityStatus
    {
        get
        {
            bool output = false;

            if (Mac != null && MacKey != null)
                output = ValidateMac();

            return output;
        }

        private set { IntegrityStatus = value; }
    }

    public byte[] MacKeySalt { get; set; }

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
            else
                output += "     ";

            string fileName = FileName.Length > 50 ? FileName.Substring(0, 47) + "..." : FileName;
            output += $" {fileName}";

            return output;
        }
    }

    /// <summary>
    /// The file name without the directory path.
    /// </summary>
    public string FileName
    {
        get
        {
            return System.IO.Path.GetFileName(Path);
        }
    }

    public void Lock()
    {
        Encrypt();
        AddMac();
    }

    public void Unlock()
    {
        Decrypt();
        RemoveMac();
    }

    private void Encrypt()
    {
        if (!File.Exists(Path))
            throw new FileNotFoundException("The file could not be found.", Path);
        if (Password == null)
            throw new NullReferenceException("Password must be set.");
        if (EncryptionStatus == true)
            return;

        // read plaintext
        string plaintextPath = Path;
        byte[] content = File.ReadAllBytes(Path);
        Path += Constants.EncryptedExtension;

        // encrypt
        EncryptionKeySalt = GlobalConfig.KeyDeriver.GenerateSalt();
        EncryptionKey = GlobalConfig.KeyDeriver.DeriveKey(Password, EncryptionKeySalt);
        byte[] ciphertext = GlobalConfig.Encryptor.Encrypt(content, EncryptionKey);

        // overwrite plaintext
        File.WriteAllBytes(Path, ciphertext);
        File.Delete(plaintextPath);
    }

    private void Decrypt()
    {
        if (!File.Exists(Path))
            throw new FileNotFoundException("The file could not be found.", Path);
        if (Password == null)
            throw new NullReferenceException("Password must be set.");
        if (EncryptionKeySalt == null)
            throw new NullReferenceException("Encryption key salt must be set.");
        if (EncryptionStatus == false)
            return;

        try
        {
            // read ciphertext
            string ciphertextPath = Path;
            byte[] content = File.ReadAllBytes(ciphertextPath);

            // decrypt
            EncryptionKey = GlobalConfig.KeyDeriver.DeriveKey(Password, EncryptionKeySalt);
            byte[] plaintext = GlobalConfig.Encryptor.Decrypt(content, EncryptionKey);

            // write plaintext
            Path = System.IO.Path.ChangeExtension(Path, null);
            File.WriteAllBytes(Path, plaintext);

            // cleanup
            EncryptionKeySalt = null;
            File.Delete(ciphertextPath);
        }
        catch (Exception ex)
        {
            throw new CryptographicException("Unable to decrypt.", ex);
        }
    }

    private void AddMac()
    {
        if (!File.Exists(Path))
            throw new FileNotFoundException("The file could not be found.", Path);
        if (Password == null)
            throw new NullReferenceException("Password must be set.");
        if (EncryptionStatus == false)
            return;

        MacKeySalt = GlobalConfig.KeyDeriver.GenerateSalt();
        MacKey = GlobalConfig.KeyDeriver.DeriveKey(Password, MacKeySalt);
        GlobalConfig.MacGenerator.Key = MacKey;

        byte[] content = File.ReadAllBytes(Path);
        Mac = GlobalConfig.MacGenerator.GenerateMac(content);
    }

    private bool ValidateMac()
    {
        if (Mac == null)
            throw new NullReferenceException("MAC must be set.");
        if (MacKey == null)
            throw new NullReferenceException("MAC key must be set.");

        byte[] content = File.ReadAllBytes(Path);
        GlobalConfig.MacGenerator.Key = MacKey;
        bool output = GlobalConfig.MacGenerator.ValidateMac(content, Mac);

        return output;
    }

    private void RemoveMac()
    {
        Mac = null;
        MacKeySalt = null;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FileModel"/> class with the specified file path.
    /// </summary>
    /// <param name="path">The path of the file.</param>
    public FileModel(string path)
    {
        Path = path;
    }
}
