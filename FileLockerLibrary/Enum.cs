using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

/// <summary>
/// Specifies encryption algorithms.
/// </summary>
public enum EncryptionAlgorithm
{
    /// <summary>
    /// Advanced Encryption Standard (AES) encryption algorithm.
    /// </summary>
    AES,

    /// <summary>
    /// Triple Data Encryption Standard (TripleDES) encryption algorithm.
    /// </summary>
    TripleDES
}

/// <summary>
/// Specifies signing algorithms.
/// </summary>
public enum DigSigAlgorithm
{
    /// <summary>
    /// RSA (Rivest-Shamir-Adleman) signing algorithm.
    /// </summary>
    RSA,

    /// <summary>
    /// ECDSA (Elliptic Curve Digital Signature Algorithm) signing algorithm.
    /// </summary>
    ECDSA
}

/// <summary>
/// Specifies the log level.
/// </summary>
public enum LogLevel
{
    /// <summary>
    /// Informational logging level.
    /// </summary>
    Information,

    /// <summary>
    /// Debugging logging level.
    /// </summary>
    Debug,

    /// <summary>
    /// Warning logging level.
    /// </summary>
    Warning,

    /// <summary>
    /// Error logging level.
    /// </summary>
    Error,

    /// <summary>
    /// Fatal logging level.
    /// </summary>
    Fatal
}
