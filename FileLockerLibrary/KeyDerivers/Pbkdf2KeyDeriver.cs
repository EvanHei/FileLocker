using System;
using System.Security.Cryptography;

namespace FileLockerLibrary;

public class Pbkdf2KeyDeriver : IKeyDeriver
{
    public byte[] GenerateSalt()
    {
        using RandomNumberGenerator rng = RandomNumberGenerator.Create();
        byte[] salt = new byte[32];
        rng.GetBytes(salt);
        return salt;
    }

    public byte[] DeriveKey(string password, byte[] salt, int length = 32)
    {
        if (password == null)
            throw new ArgumentNullException("Password cannot be null.");
        if (salt == null)
            throw new ArgumentNullException("Salt cannot be null.");

        using Rfc2898DeriveBytes pbkdf2 = new(password, salt, 10000, HashAlgorithmName.SHA256);
        return pbkdf2.GetBytes(length);
    }
}
