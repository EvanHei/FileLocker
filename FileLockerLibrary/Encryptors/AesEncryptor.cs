using System;
using System.Security.Cryptography;
using System.IO;

namespace FileLockerLibrary;

/// <summary>
/// Provides functionality to encrypt and decrypt text using the Advanced Encryption Standard (AES) algorithm.
/// </summary>
public class AesEncryptor : IEncryptor
{
    private const int PaddingFieldLength = sizeof(long);

    /// <summary>
    /// Encrypts the provided plaintext with a specified key and no additional padding.
    /// </summary>
    /// <param name="plaintext">The plaintext data to encrypt.</param>
    /// <param name="key">The key used for encryption (must be 32 bytes long).</param>
    /// <returns>The encrypted ciphertext.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the plaintext or key is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the key length is not 32 bytes.</exception>
    public byte[] Encrypt(byte[] plaintext, byte[] key)
    {
        return Encrypt(plaintext, key, 0);
    }

    /// <summary>
    /// Encrypts the provided plaintext with a specified key and no additional padding.
    /// </summary>
    /// <param name="plaintext">The plaintext data to encrypt.</param>
    /// <param name="key">The key used for encryption (must be 32 bytes long).</param>
    /// <returns>The encrypted ciphertext.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the plaintext or key is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the key length is not 32 bytes or when paddingLength is negative.</exception>
    public byte[] Encrypt(byte[] plaintext, byte[] key, long minPaddingLength)
    {
        if (plaintext == null)
            throw new ArgumentNullException("Plaintext is null.");
        if (key == null)
            throw new ArgumentNullException("Key is null.");
        if (key.Length != 32)
            throw new ArgumentOutOfRangeException("Key must be 32 bytes long.");
        if (minPaddingLength < 0)
            throw new ArgumentOutOfRangeException(nameof(minPaddingLength), "Padding length cannot be negative.");

        using Aes aes = Aes.Create();
        ICryptoTransform encryptor = aes.CreateEncryptor(key, aes.IV);

        using MemoryStream msEncrypt = new();
        using (CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write))
        {
            byte[] paddedData = PadData(plaintext, minPaddingLength);
            csEncrypt.Write(paddedData, 0, paddedData.Length);
        }
        byte[] ciphertext = msEncrypt.ToArray();

        // create output variable with correct length and data
        byte[] ivAndCiphertext = new byte[aes.IV.Length + ciphertext.Length];
        Buffer.BlockCopy(aes.IV, 0, ivAndCiphertext, 0, aes.IV.Length);
        Buffer.BlockCopy(ciphertext, 0, ivAndCiphertext, aes.IV.Length, ciphertext.Length);

        return ivAndCiphertext;
    }

    /// <summary>
    /// Encrypts the provided plaintext with a specified key and additional padding length.
    /// </summary>
    /// <param name="plaintext">The plaintext data to encrypt.</param>
    /// <param name="key">The key used for encryption (must be 32 bytes long).</param>
    /// <param name="paddingLength">The length of additional padding to add.</param>
    /// <returns>The encrypted ciphertext.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the plaintext or key is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the key length is not 32 bytes or when paddingLength is negative.</exception>
    public byte[] Decrypt(byte[] ciphertextAndIv, byte[] key)
    {
        if (ciphertextAndIv == null)
            throw new ArgumentNullException("Ciphertext is null.");
        if (key == null)
            throw new ArgumentNullException("Key is null.");
        if (ciphertextAndIv.Length < 16 && ciphertextAndIv.Length != 0)
            throw new ArgumentOutOfRangeException("Ciphertext has invalid length.");
        if (key.Length != 32)
            throw new ArgumentOutOfRangeException("Key must be 32 bytes long.");

        // empty byte array for empty ciphertext
        if (ciphertextAndIv.Length == 0)
            return new byte[0];

        byte[] paddedData;

        // extract the IV (first 16 bytes)
        byte[] iv = new byte[16];
        Buffer.BlockCopy(ciphertextAndIv, 0, iv, 0, iv.Length);

        // get the ciphertext
        byte[] ciphertext = new byte[ciphertextAndIv.Length - iv.Length];
        Buffer.BlockCopy(ciphertextAndIv, iv.Length, ciphertext, 0, ciphertext.Length);

        using Aes aes = Aes.Create();
        aes.Key = key;
        aes.IV = iv;
        ICryptoTransform decryptor = aes.CreateDecryptor();

        using MemoryStream msDecrypt = new(ciphertext);
        using CryptoStream csDecrypt = new(msDecrypt, decryptor, CryptoStreamMode.Read);
        using MemoryStream plaintextStream = new();
        csDecrypt.CopyTo(plaintextStream);

        paddedData = plaintextStream.ToArray();
        byte[] unpaddedData = UnpadData(paddedData);

        return unpaddedData;
    }

    /// <summary>
    /// Pads the provided data array with the specified padding length up to at least the length provided.
    /// </summary>
    /// <param name="data">The data array to pad.</param>
    /// <param name="length">The total length to pad the data up to.</param>
    /// <returns>The padded data array.</returns>
    private byte[] PadData(byte[] data, long paddingLength)
    {
        byte[] paddedData = new byte[data.Length + PaddingFieldLength + paddingLength];

        Buffer.BlockCopy(data, 0, paddedData, 0, data.Length);

        // add the padding length field
        Buffer.BlockCopy(BitConverter.GetBytes(paddingLength), 0, paddedData, data.Length + (int)paddingLength, PaddingFieldLength);

        return paddedData;
    }

    /// <summary>
    /// Unpads the provided padded data array.
    /// </summary>
    /// <param name="paddedData">The padded data array to unpad.</param>
    /// <returns>The unpadded data array.</returns>
    /// <exception cref="ArgumentException">Thrown when the padded data size is invalid or the padding length is invalid.</exception>
    private byte[] UnpadData(byte[] paddedData)
    {
        if (paddedData.Length < PaddingFieldLength)
            throw new ArgumentException("Invalid padded data size.");

        // extract the padding length field
        long paddingLength = BitConverter.ToInt64(paddedData, paddedData.Length - PaddingFieldLength);

        if (paddingLength < 0 || paddingLength > paddedData.Length - PaddingFieldLength)
            throw new ArgumentException("Invalid padding length.");

        byte[] unpaddedData = new byte[paddedData.Length - PaddingFieldLength - paddingLength];

        Buffer.BlockCopy(paddedData, 0, unpaddedData, 0, unpaddedData.Length);

        return unpaddedData;
    }
}
