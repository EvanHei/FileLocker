using System;
using System.Security.Cryptography;

namespace FileLockerLibrary;

/// <summary>
/// Represents a class for Password-Based Key Derivation Function 2 (PBKDF2) key derivation.
/// </summary>
public class Pbkdf2KeyDeriver : IKeyDeriver
{
    /// <summary>
    /// Generates a 32-byte random salt for cryptographic operations.
    /// </summary>
    /// <returns>A byte array representing the generated salt.</returns>
    public byte[] GenerateSalt()
    {
        using var rng = RandomNumberGenerator.Create();
        byte[] salt = new byte[32];
        rng.GetBytes(salt);
        return salt;
    }

    /// <summary>
    /// Derives a 32-byte cryptographic key using PBKDF2 with the specified password and salt.
    /// </summary>
    /// <param name="password">The password to derive the key from.</param>
    /// <param name="salt">The randomly generated salt used in key derivation.</param>
    /// <returns>A byte array representing the derived key.</returns>
    public byte[] DeriveKey(string password, byte[] salt)
    {
        if (password == null)
            throw new ArgumentNullException("Password cannot be null.");
        if (salt == null)
            throw new ArgumentNullException("Salt cannot be null.");

        using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256);
        return pbkdf2.GetBytes(32);
    }
}
