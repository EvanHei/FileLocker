﻿using System;
using System.Collections.Generic;
using System.Linq;
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
    /// <exception cref="FileNotFoundException">Thrown the file could not be found.</exception>
    /// <exception cref="CryptographicException">Thrown when decryption fails.</exception>
    public void Decrypt()
    {
        if (!File.Exists(Path))
            throw new FileNotFoundException("The file could not be found.", Path);
        if (EncryptionStatus == false)
            return;

        try
        {
            string ciphertextPath = Path;
            byte[] content = File.ReadAllBytes(ciphertextPath);
            byte[] plaintext = GlobalConfig.Encryptor.Decrypt(content, EncryptionKey);

            Path = System.IO.Path.ChangeExtension(Path, null);
            File.WriteAllBytes(Path, plaintext);
            File.Delete(ciphertextPath);
        }
        catch (Exception ex)
        {
            throw new CryptographicException("Unable to decrypt.", ex);
        }
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
