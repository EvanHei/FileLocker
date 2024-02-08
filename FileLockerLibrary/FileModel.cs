using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary
{
    /// <summary>
    /// Represents a file model containing content, path, password, and encryption-related properties and methods.
    /// </summary>
    public class FileModel
    {
        /// <summary>
        /// The content of the file.
        /// </summary>
        public byte[] Content { get; private set; }

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
        public bool EncryptionStatus { get; private set; }

        /// <summary>
        /// Encrypts the content of the file.
        /// </summary>
        public void Encrypt()
        {
            if (EncryptionStatus == true)
                return;

            // TODO - implement 
            //AesEncryptor encryptor = new AesEncryptor(); // remove padding?
            //Content = encryptor.encrypt(Content, EncryptionKey);

            EncryptionStatus = true;
        }

        /// <summary>
        /// Decrypts the content of the file.
        /// </summary>
        public void Decrypt()
        {
            if (EncryptionStatus == false)
                return;

            //AesEncryptor encryptor = new AesEncryptor();
            //Content = encryptor.decrypt(Content, EncryptionKey);

            EncryptionStatus = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileModel"/> class with the specified path and password.
        /// </summary>
        /// <param name="path">The path of the file.</param>
        /// <param name="password">The password used for encryption and decryption.</param>
        FileModel(string path, string password)
        {
            Path = path;
            Password = password;
            Content = File.ReadAllBytes(path);

            // TODO - implement 
            //EncryptionKeySalt = GlobalConfig.KeyDeriver.GenerateSalt();
            //EncryptionKey = GlobalConfig.KeyDeriver.DeriveKey(password, EncryptionKeySalt);
        }
    }
}
