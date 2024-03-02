using System;
using System.Security.Cryptography;
using System.IO;

namespace FileLockerLibrary;

/// <summary>
/// Provides functionality to encrypt and decrypt text using the Advanced Encryption Standard (AES) algorithm.
/// </summary>
public class AesEncryptor : IEncryptor
{
    private const long MaxFileSize = Constants.MaxFileSize;
    private const int PaddingFieldLength = sizeof(long);

    public byte[] Encrypt(byte[] plaintext, byte[] key)
    {
        if (plaintext == null)
            throw new ArgumentNullException("Plaintext is null.");
        if (key == null)
            throw new ArgumentNullException("Key is null.");
        if (key.Length != 32)
            throw new ArgumentOutOfRangeException("Key must be 32 bytes (256 bits) long.");

        byte[] paddedData = PadData(plaintext);
        byte[] iv;
        byte[] ciphertext;

        using Aes aes = Aes.Create();
        aes.Key = key;
        aes.GenerateIV();
        iv = aes.IV;

        using MemoryStream msEncrypt = new();
        using (CryptoStream csEncrypt = new(msEncrypt, aes.CreateEncryptor(aes.Key, aes.IV), CryptoStreamMode.Write))
        {
            csEncrypt.Write(paddedData, 0, paddedData.Length);
        }
        ciphertext = msEncrypt.ToArray();

        // create output variable with correct length and data
        byte[] ivAndCiphertext = new byte[iv.Length + ciphertext.Length];
        Buffer.BlockCopy(iv, 0, ivAndCiphertext, 0, iv.Length);
        Buffer.BlockCopy(ciphertext, 0, ivAndCiphertext, iv.Length, ciphertext.Length);

        return ivAndCiphertext;
    }

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

        byte[] paddedData;

        using (Aes aes = Aes.Create())
        {
            // get the IV (first 16 bytes)
            byte[] iv = new byte[16];
            Buffer.BlockCopy(ciphertextAndIv, 0, iv, 0, iv.Length);

            aes.Key = key;
            aes.IV = iv;

            using MemoryStream msDecrypt = new(ciphertextAndIv, iv.Length, ciphertextAndIv.Length - iv.Length);
            using CryptoStream csDecrypt = new(msDecrypt, aes.CreateDecryptor(), CryptoStreamMode.Read);
            using MemoryStream plaintextStream = new();
            csDecrypt.CopyTo(plaintextStream);
            paddedData = plaintextStream.ToArray();
        }

        byte[] unpaddedData = UnpadData(paddedData);

        return unpaddedData;
    }

    private byte[] PadData(byte[] data)
    {
        if (data.Length > MaxFileSize)
            throw new ArgumentOutOfRangeException(nameof(data), "Data size exceeds the maximum allowed size of 100 MB.");

        long paddingLength = MaxFileSize - data.Length;
        byte[] paddedData = new byte[MaxFileSize + PaddingFieldLength]; 

        Buffer.BlockCopy(data, 0, paddedData, 0, data.Length);

        // add the padding length field
        Buffer.BlockCopy(BitConverter.GetBytes(paddingLength), 0, paddedData, data.Length + (int)paddingLength, PaddingFieldLength);

        return paddedData;
    }

    private byte[] UnpadData(byte[] paddedData)
    {
        if (paddedData.Length < MaxFileSize + PaddingFieldLength)
            throw new ArgumentException("Invalid padded data size.");

        // extract the padding length field
        long paddingLength = BitConverter.ToInt64(paddedData, paddedData.Length - PaddingFieldLength);

        if (paddingLength < 0 || paddingLength > MaxFileSize)
            throw new ArgumentException("Invalid padding length.");

        byte[] unpaddedData = new byte[MaxFileSize - paddingLength];

        Buffer.BlockCopy(paddedData, 0, unpaddedData, 0, unpaddedData.Length);

        return unpaddedData;
    }
}
