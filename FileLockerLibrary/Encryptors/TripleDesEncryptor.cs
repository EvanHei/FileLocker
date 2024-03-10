using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public class TripleDesEncryptor : IEncryptor
{
    private const long MaxFileSize = Constants.MaxFileSize;
    private const int PaddingFieldLength = sizeof(long);

    public byte[] Encrypt(byte[] plaintext, byte[] key)
    {
        if (plaintext == null)
            throw new ArgumentNullException(nameof(plaintext), "Plaintext is null.");
        if (key == null)
            throw new ArgumentNullException(nameof(key), "Key is null.");
        if (key.Length != 24)
            throw new ArgumentOutOfRangeException(nameof(key), "Key must be 24 bytes long.");

        using TripleDES tripleDes = TripleDES.Create();
        ICryptoTransform encryptor = tripleDes.CreateEncryptor(key, tripleDes.IV);

        using MemoryStream msEncrypt = new();
        using (CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write))
        {
            byte[] paddedData = PadData(plaintext);
            csEncrypt.Write(paddedData, 0, paddedData.Length);
        }
        byte[] ciphertext = msEncrypt.ToArray();

        // create output variable with correct length and data
        byte[] ivAndCiphertext = new byte[tripleDes.IV.Length + ciphertext.Length];
        Buffer.BlockCopy(tripleDes.IV, 0, ivAndCiphertext, 0, tripleDes.IV.Length);
        Buffer.BlockCopy(ciphertext, 0, ivAndCiphertext, tripleDes.IV.Length, ciphertext.Length);

        return ivAndCiphertext;
    }

    public byte[] Decrypt(byte[] ciphertextAndIv, byte[] key)
    {
        if (ciphertextAndIv == null)
            throw new ArgumentNullException(nameof(ciphertextAndIv), "Ciphertext is null.");
        if (key == null)
            throw new ArgumentNullException(nameof(key), "Key is null.");
        if (ciphertextAndIv.Length < 8 && ciphertextAndIv.Length != 0)
            throw new ArgumentOutOfRangeException(nameof(ciphertextAndIv), "Ciphertext has invalid length.");
        if (key.Length != 24)
            throw new ArgumentOutOfRangeException(nameof(key), "Key must be 24 bytes long.");

        // empty byte array for empty ciphertext
        if (ciphertextAndIv.Length == 0)
            return new byte[0];

        // extract the IV (first 8 bytes)
        byte[] iv = new byte[8];
        Buffer.BlockCopy(ciphertextAndIv, 0, iv, 0, iv.Length);

        // get the ciphertext
        byte[] ciphertext = new byte[ciphertextAndIv.Length - iv.Length];
        Buffer.BlockCopy(ciphertextAndIv, iv.Length, ciphertext, 0, ciphertext.Length);

        using TripleDES tripleDes = TripleDES.Create();
        tripleDes.Key = key;
        tripleDes.IV = iv;
        ICryptoTransform decryptor = tripleDes.CreateDecryptor();

        using MemoryStream msDecrypt = new(ciphertext);
        using CryptoStream csDecrypt = new(msDecrypt, decryptor, CryptoStreamMode.Read);
        using MemoryStream plaintextStream = new();
        csDecrypt.CopyTo(plaintextStream);

        byte[] paddedData = plaintextStream.ToArray();
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
