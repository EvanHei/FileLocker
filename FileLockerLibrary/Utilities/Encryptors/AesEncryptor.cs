using System;
using System.Security.Cryptography;
using System.IO;

namespace FileLockerLibrary
{
    /// <summary>
    /// Provides functionality to encrypt and decrypt text using the Advanced Encryption Standard (AES) algorithm.
    /// </summary>
    public class AesEncryptor : IEncryptor
    {
        private const int PADDING_LENGTH = 10000;

        /// <summary>
        /// Encrypts plaintext using a symmetric key.
        /// </summary>
        /// <param name="plaintext">Plaintext to be encrypted.</param>
        /// <param name="key">The 32-byte key to use.</param>
        /// <returns>Bytes of ciphtertext with the intialization vector appended to the front.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the plaintext or key is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the plaintext or key has invalid length.</exception>
        public byte[] Encrypt(string plaintext, byte[] key)
        {
            if (plaintext == null)
                throw new ArgumentNullException("Plaintext is null.");
            if (key == null)
                throw new ArgumentNullException("Key is null.");
            if (plaintext.Length < 0)
                throw new ArgumentOutOfRangeException("Plaintext has invalid length.");
            if (key.Length != 32)
                throw new ArgumentOutOfRangeException("Key must be 32 bytes (256 bits) long.");

            byte[] ciphertext;
            byte[] ivAndCiphertext;

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plaintext);
                        }
                        ciphertext = msEncrypt.ToArray();

                        // create output variable with correct length and data
                        ivAndCiphertext = new byte[aes.IV.Length + ciphertext.Length];
                        Array.Copy(aes.IV, ivAndCiphertext, aes.IV.Length);
                        msEncrypt.ToArray().CopyTo(ivAndCiphertext, aes.IV.Length);
                    }
                }
            }

            return ivAndCiphertext;
        }

        /// <summary>
        /// Decrypts ciphertext using a provided key.
        /// </summary>
        /// <param name="ciphertextAndIv">The ciphertext with the initialization vector appended to the front.</param>
        /// <param name="key">32-character key to use when decrypting.</param>
        /// <returns>String of plaintext.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the ciphertext or key is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the ciphertext or key has invalid length.</exception>
        public string Decrypt(byte[] ciphertextAndIv, byte[] key)
        {
            if (ciphertextAndIv == null)
                throw new ArgumentNullException("Ciphertext is null.");
            if (key == null)
                throw new ArgumentNullException("Key is null.");
            if (ciphertextAndIv.Length < 16 && ciphertextAndIv.Length != 0)
                throw new ArgumentOutOfRangeException("Ciphertext has invalid length.");
            if (key.Length != 32)
                throw new ArgumentOutOfRangeException("Key must be 32 bytes (256 bits) long.");

            // if the ciphertext is "", then the plaintext is ""
            if (ciphertextAndIv.Length == 0)
                return "";

            string plaintext = null;

            using (Aes aes = Aes.Create())
            {
                // get the IV (first 16 bytes)
                byte[] iv = new byte[16];
                Array.Copy(ciphertextAndIv, 0, iv, 0, iv.Length);

                aes.Key = key;
                aes.IV = iv;

                byte[] ciphertext = new byte[ciphertextAndIv.Length - iv.Length];
                Array.Copy(ciphertextAndIv, iv.Length, ciphertext, 0, ciphertext.Length);

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream msDecrypt = new MemoryStream(ciphertext))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }
}
