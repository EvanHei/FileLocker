using System;
using System.Security.Cryptography;

namespace FileLockerLibrary;

/// <summary>
/// Provides functionality for generating a HMAC-based digest.
/// </summary>
public class HmacGenerator
{
    private HMACSHA256 Hmac = new HMACSHA256();

    private bool keyIsSet = false;

    /// <summary>
    /// The 32-byte key used for the HMAC.
    /// </summary>
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

    /// <summary>
    /// Computes the HMAC for the specified data.
    /// </summary>
    /// <param name="data">The data for which to generate the HMAC.</param>
    /// <returns>The generated HMAC.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the data is null.</exception>
    /// <exception cref="NullReferenceException">Thrown if the key has not been set.</exception>
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

    /// <summary>
    /// Validates the HMAC for the specified data against the expected HMAC.
    /// </summary>
    /// <param name="data">The data for which to validate the HMAC.</param>
    /// <param name="expectedHmac">The expected HMAC to compare against.</param>
    /// <returns>True if the HMAC is valid, false otherwise.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the data or expectedHmac is null.</exception>
    /// <exception cref="NullReferenceException">Thrown if the key has not been set.</exception>
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

    /// <summary>
    /// Performs a constant-time comparison between two byte arrays.
    /// </summary>
    /// <param name="first">The first byte array.</param>
    /// <param name="second">The second byte array.</param>
    /// <returns>True if the arrays are equal, false otherwise.</returns>
    /// <exception cref="ArgumentNullException">Thrown if either array is null.</exception>
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
