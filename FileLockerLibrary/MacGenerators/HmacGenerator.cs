using System;
using System.Security.Cryptography;

namespace FileLockerLibrary.MacGenerators;

/// <summary>
/// Implementation of the <see cref="IMacGenerator"/> interface using HMAC-SHA256.
/// </summary>
public class HmacGenerator : IMacGenerator
{
    private HMACSHA256 Hmac = new();
    private bool keyIsSet = false;

    /// <summary>
    /// Gets or sets the key used for MAC generation and validation.
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
    /// Generates a MAC for the given data using HMAC-SHA256.
    /// </summary>
    /// <param name="data">The data to generate the MAC for.</param>
    /// <returns>The generated MAC.</returns>
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
    /// Validates whether the provided MAC matches the calculated MAC for the given data using HMAC-SHA256.
    /// </summary>
    /// <param name="data">The data to validate the MAC against.</param>
    /// <param name="expectedHmac">The expected MAC to validate against.</param>
    /// <returns><c>true</c> if the MAC is valid, <c>false</c> otherwise.</returns>
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
    /// Compares two byte arrays for equality by performing a bitwise comparison.
    /// </summary>
    /// <param name="first">The first byte array to compare.</param>
    /// <param name="second">The second byte array to compare.</param>
    /// <returns>
    /// <c>true</c> if the arrays are equal; otherwise, <c>false</c>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when either <paramref name="first"/> or <paramref name="second"/> is null.
    /// </exception>
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
