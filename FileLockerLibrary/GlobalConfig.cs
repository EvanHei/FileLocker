using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

/// <summary>
/// Provides global configuration servies for the application.
/// </summary>
public static class GlobalConfig
{
    /// <summary>
    /// The data accessor used for data access operations.
    /// </summary>
    public static TextAccessor DataAccessor { get; set; } = new TextAccessor();

    /// <summary>
    /// The encryptor used for encryption and decryption.
    /// </summary>
    public static IEncryptor Encryptor { get; set; } = new AesEncryptor();

    /// <summary>
    /// The hasher used for hashing passwords.
    /// </summary>
    public static BCryptHasher Hasher { get; set; } = new BCryptHasher();

    /// <summary>
    /// The key deriver used for deriving keys.
    /// </summary>
    public static Pbkdf2KeyDeriver KeyDeriver { get; set; } = new Pbkdf2KeyDeriver();
}
