using System;
using System.Security.Cryptography;

namespace FileLockerLibrary;

public class HmacGenerator : IMacGenerator
{
    private HMACSHA256 Hmac = new HMACSHA256();

    private bool keyIsSet = false;

    public byte[] Key
    {
        get
        {
            if (!keyIsSet)
            {
                throw new NullReferenceException("Key has not been set.");
            }
            return Hmac.Key;
        }
        set
        {
            if (value == null)
                throw new ArgumentNullException("Key cannot be null.");
            if (value.Length != 32)
                throw new ArgumentException($"Invalid key length. Expected 32 bytes.");

            Hmac.Key = value;
            keyIsSet = true;
        }
    }

    public byte[] GenerateMac(byte[] data)
    {
        if (data == null)
            throw new ArgumentNullException("Data cannot be null.");
        if (!keyIsSet)
            throw new NullReferenceException("Key has not been set.");

        // return an empty HMAC for empty data
        if (data.Length == 0)
            return new byte[0];

        byte[] output = Hmac.ComputeHash(data);
        return output;
    }

    public bool ValidateMac(byte[] data, byte[] expectedHmac)
    {
        if (data == null)
            throw new ArgumentNullException("Data cannot be null.");
        if (expectedHmac == null)
            throw new ArgumentNullException("Expected HMAC cannot be null.");
        if (!keyIsSet)
            throw new NullReferenceException("Key has not been set.");

        byte[] computedHmac = GenerateMac(data);
        bool output = AreEqual(computedHmac, expectedHmac);
        return output;
    }

    private static bool AreEqual(byte[] first, byte[] second)
    {
        if (first == null || second == null)
            throw new ArgumentNullException("Both arrays must be non-null.");

        if (first.Length != second.Length)
            return false;

        int result = 0;
        for (int i = 0; i < first.Length; i++)
            result |= first[i] ^ second[i];

        bool output = (result == 0);
        return output;
    }
}
