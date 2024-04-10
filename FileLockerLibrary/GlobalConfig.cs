using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

/// <summary>
/// Provides global configuration settings and instances for various components of the application.
/// </summary>
public static class GlobalConfig
{
    /// <summary>
    /// Gets or sets the data accessor for file operations.
    /// </summary>
    public static IDataAccessor DataAccessor { get; set; } = new JsonAccessor();

    /// <summary>
    /// Gets or sets the key deriver for generating encryption keys.
    /// </summary>
    public static IKeyDeriver KeyDeriver { get; set; } = new Pbkdf2KeyDeriver();

    /// <summary>
    /// Gets or sets the message authentication code (MAC) generator.
    /// </summary>
    public static IMacGenerator MacGenerator { get; set; } = new HmacGenerator();

    /// <summary>
    /// Gets or sets the logger for recording application logs.
    /// </summary>
    public static ILogger Logger { get; set; } = new SerilogLogger();

    /// <summary>
    /// Gets or sets the hasher for generating hash values.
    /// </summary>
    public static IHasher Hasher { get; set; } = new Sha256Hasher();

    /// <summary>
    /// Gets the diagnostics utility for monitoring application performance.
    /// </summary>
    public static Diagnostics Diagnostics { get; } = new Diagnostics();

    /// <summary>
    /// Returns an encryptor based on the specified encryption algorithm.
    /// </summary>
    /// <param name="algorithm">The encryption algorithm.</param>
    /// <returns>An instance of the encryptor for the specified algorithm.</returns>
    /// <exception cref="ArgumentException">Thrown when the specified algorithm is unsupported.</exception>
    public static IEncryptor Encryptor(EncryptionAlgorithm algorithm)
    {
        switch (algorithm)
        {
            case EncryptionAlgorithm.AES:
                return new AesEncryptor();
            case EncryptionAlgorithm.TripleDES:
                return new TripleDesEncryptor();
            default:
                throw new ArgumentException("Unsupported encryption algorithm.", nameof(algorithm));
        }
    }

    /// <summary>
    /// Returns a signer based on the specified signing algorithm.
    /// </summary>
    /// <param name="algorithm">The signing algorithm.</param>
    /// <returns>An instance of the signer for the specified algorithm.</returns>
    /// <exception cref="ArgumentException">Thrown when the specified algorithm is unsupported.</exception>
    public static ISigner Signer(DigSigAlgorithm algorithm)
    {
        switch (algorithm)
        {
            case DigSigAlgorithm.RSA:
                return new RsaSigner();
            case DigSigAlgorithm.ECDSA:
                return new EcdsaSigner();
            default:
                throw new ArgumentException("Unsupported signing algorithm.", nameof(algorithm));
        }
    }
}
