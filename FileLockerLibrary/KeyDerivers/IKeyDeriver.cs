namespace FileLockerLibrary;

/// <summary>
/// Interface for deriving cryptographic keys.
/// </summary>
public interface IKeyDeriver
{
    /// <summary>
    /// Generates a random salt for key derivation.
    /// </summary>
    /// <returns>The generated salt.</returns>
    byte[] GenerateSalt();

    /// <summary>
    /// Derives a key from the given password and salt.
    /// </summary>
    /// <param name="password">The password to derive the key from.</param>
    /// <param name="salt">The salt to use for key derivation.</param>
    /// <param name="length">The length of the derived key in bytes (default is 32).</param>
    /// <returns>The derived key.</returns>
    byte[] DeriveKey(string password, byte[] salt, int length = 32);
}
