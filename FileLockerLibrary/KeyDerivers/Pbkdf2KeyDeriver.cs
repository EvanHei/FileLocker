using System;
using System.Security.Cryptography;

namespace FileLockerLibrary.KeyDerivers;

/// <summary>
/// Implementation of <see cref="IKeyDeriver"/> interface using the PBKDF2 key derivation algorithm.
/// </summary>
public class Pbkdf2KeyDeriver : IKeyDeriver
{
    /// <summary>
    /// Generates a random salt.
    /// </summary>
    /// <returns>The generated salt.</returns>
    public byte[] GenerateSalt()
    {
        using RandomNumberGenerator rng = RandomNumberGenerator.Create();
        byte[] salt = new byte[32];
        rng.GetBytes(salt);
        return salt;
    }

    /// <summary>
    /// Derives a key from the specified password and salt using the PBKDF2 algorithm.
    /// </summary>
    /// <param name="password">The password from which to derive the key.</param>
    /// <param name="salt">The salt value.</param>
    /// <param name="length">The length of the derived key in bytes (default is 32 bytes).</param>
    /// <returns>The derived key.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the <paramref name="password"/> or <paramref name="salt"/> is null.</exception>
    public byte[] DeriveKey(string password, byte[] salt, int length = 32)
    {
        if (password == null)
            throw new ArgumentNullException("Password cannot be null.");
        if (salt == null)
            throw new ArgumentNullException("Salt cannot be null.");

        using Rfc2898DeriveBytes pbkdf2 = new(password, salt, 10000, HashAlgorithmName.SHA256);
        return pbkdf2.GetBytes(length);
    }

    /// <summary>
    /// Derives a key from the specified password using the PBKDF2 algorithm.
    /// </summary>
    /// <param name="password">The password from which to derive the key.</param>
    /// <param name="length">The length of the derived key in bytes (default is 32 bytes).</param>
    /// <returns>The derived key.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the <paramref name="password"/> is null.</exception>
    public byte[] DeriveKey(string password, int length = 32)
    {
        if (password == null)
            throw new ArgumentNullException(nameof(password), "Password cannot be null.");

        using Rfc2898DeriveBytes pbkdf2 = new(password, salt: new byte[0], 10000, HashAlgorithmName.SHA256);
        return pbkdf2.GetBytes(length);
    }
}
