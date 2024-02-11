using System;
using System.Collections.Generic;
using System.Linq;
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

    private string password;

    /// <summary>
    /// The password used for encryption and decryption.
    /// Setting the password also updates the password hash.
    /// </summary>
    public string Password
    {
        get { return password; }
        set
        {
            password = value;
            PasswordHash = GlobalConfig.Hasher.HashPassword(value);
        }
    }

    /// <summary>
    /// The hashed password. Automatically computed when the password is set.
    /// </summary>
    public string PasswordHash { get; set; }

    /// <summary>
    /// The encryption key used for encryption and decryption.
    /// </summary>
    public byte[] EncryptionKey { get; set; }

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

    /// <summary>
    /// Encrypts the content of the file.
    /// </summary>
    public void Encrypt()
    {
        if (!File.Exists(Path))
            throw new FileNotFoundException("The file could not be found.", Path);
        if (EncryptionStatus == true)
            return;

        string plaintextPath = Path;
        Path = Path + Constants.EncryptedExtension;

        byte[] content = File.ReadAllBytes(plaintextPath);
        byte[] ciphertext = GlobalConfig.Encryptor.Encrypt(content, EncryptionKey);

        File.WriteAllBytes(Path, ciphertext);
        File.Delete(plaintextPath);
    }

    /// <summary>
    /// Decrypts the content of the file.
    /// </summary>
    public void Decrypt()
    {
        if (!File.Exists(Path))
            throw new FileNotFoundException("The file could not be found.", Path);
        if (EncryptionStatus == false)
            return;

        string ciphertextPath = Path;
        Path = System.IO.Path.ChangeExtension(Path, null);

        byte[] content = File.ReadAllBytes(ciphertextPath);
        byte[] plaintext = GlobalConfig.Encryptor.Decrypt(content, EncryptionKey);
        File.WriteAllBytes(Path, plaintext);
        File.Delete(ciphertextPath);
    }

    public FileModel(string path)
    {
        Path = path;
    }
}
