using System;
using System.Security.Cryptography;
using System.IO;

namespace FileLockerLibrary;

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
    public byte[] Encrypt(byte[] plaintext, byte[] key)
    {
        if (plaintext == null)
            throw new ArgumentNullException("Plaintext is null.");
        if (key == null)
            throw new ArgumentNullException("Key is null.");
        if (key.Length != 32)
            throw new ArgumentOutOfRangeException("Key must be 32 bytes (256 bits) long.");

        byte[] iv;
        byte[] ciphertext;

        using (Aes aes = Aes.Create())
        {
            aes.Key = key;
            aes.GenerateIV();
            iv = aes.IV;

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, aes.CreateEncryptor(aes.Key, aes.IV), CryptoStreamMode.Write))
                {
                    csEncrypt.Write(plaintext, 0, plaintext.Length);

                }
                ciphertext = msEncrypt.ToArray();

                // create output variable with correct length and data
                byte[] ivAndCiphertext = new byte[iv.Length + ciphertext.Length];
                Buffer.BlockCopy(iv, 0, ivAndCiphertext, 0, iv.Length);
                Buffer.BlockCopy(ciphertext, 0, ivAndCiphertext, iv.Length, ciphertext.Length);
    
                return ivAndCiphertext;
            }
        }
    }

    /// <summary>
    /// Decrypts ciphertext using a provided key.
    /// </summary>
    /// <param name="ciphertextAndIv">The ciphertext with the initialization vector appended to the front.</param>
    /// <param name="key">32-character key to use when decrypting.</param>
    /// <returns>String of plaintext.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the ciphertext or key is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the ciphertext or key has invalid length.</exception>
    public byte[] Decrypt(byte[] ciphertextAndIv, byte[] key)
    {
        if (ciphertextAndIv == null)
            throw new ArgumentNullException("Ciphertext is null.");
        if (key == null)
            throw new ArgumentNullException("Key is null.");
        if (ciphertextAndIv.Length < 16 && ciphertextAndIv.Length != 0)
            throw new ArgumentOutOfRangeException("Ciphertext has invalid length.");
        if (key.Length != 32)
            throw new ArgumentOutOfRangeException("Key must be 32 bytes (256 bits) long.");

        // empty byte array for empty ciphertext
        if (ciphertextAndIv.Length == 0)
            return new byte[0];

        byte[] plaintextBytes;

        using (Aes aes = Aes.Create())
        {
            // get the IV (first 16 bytes)
            byte[] iv = new byte[16];
            Buffer.BlockCopy(ciphertextAndIv, 0, iv, 0, iv.Length);

            aes.Key = key;
            aes.IV = iv;

            using (MemoryStream msDecrypt = new MemoryStream(ciphertextAndIv, 16, ciphertextAndIv.Length - 16))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    using (MemoryStream plaintextStream = new MemoryStream())
                    {
                        csDecrypt.CopyTo(plaintextStream);
                        plaintextBytes = plaintextStream.ToArray();
                    }
                }
            }
        }

        return plaintextBytes;
    }
}
