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
        public byte[] Content { get; set; }

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
        /// The hashed password.
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
        public bool EncryptionStatus { get; set; }

        /// <summary>
        /// Encrypts the content of the file.
        /// </summary>
        public void Encrypt()
        {
            if (EncryptionStatus == true)
                return;

            Content = GlobalConfig.Encryptor.Encrypt(Content, EncryptionKey);
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
    }
}
