using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

/// <summary>
/// Implementation of <see cref="IHasher"/> interface using SHA-256 hashing algorithm.
/// </summary>
public class Sha256Hasher : IHasher
{
    /// <summary>
    /// Computes the SHA-256 hash of the specified data.
    /// </summary>
    /// <param name="data">The data to hash.</param>
    /// <returns>The computed SHA-256 hash.</returns>
    public byte[] Hash(byte[] data)
    {
        byte[] hash = SHA256.HashData(data);
        return hash;
    }
}
