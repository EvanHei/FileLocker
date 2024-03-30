using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

/// <summary>
/// Interface for classes implementing hash algorithms.
/// </summary>
public interface IHasher
{
    /// <summary>
    /// Computes the hash value for the specified byte array.
    /// </summary>
    /// <param name="data">The input data to compute the hash value for.</param>
    /// <returns>The computed hash value.</returns>
    byte[] Hash(byte[] data);
}
