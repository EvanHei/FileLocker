namespace FileLockerLibrary;

/// <summary>
/// Represents an interface for encryption and decryption operations.
/// </summary>
public interface IEncryptor
{
    /// <summary>
    /// Encrypts the specified plaintext using the provided key.
    /// </summary>
    /// <param name="plaintext">The plaintext to be encrypted.</param>
    /// <param name="key">The encryption key.</param>
    /// <returns>The encrypted data as a byte array.</returns>
    byte[] Encrypt(byte[] plaintext, byte[] key);

    /// <summary>
    /// Encrypts the specified plaintext using the provided key and custom padding length.
    /// </summary>
    /// <param name="plaintext">The plaintext to be encrypted.</param>
    /// <param name="key">The encryption key.</param>
    /// <param name="minPaddingLength">The minimum length the ciphertext will be.</param>
    /// <returns>The encrypted data as a byte array at least as long as paddingLength.</returns>
    byte[] Encrypt(byte[] plaintext, byte[] key, long minPaddingLength);

    /// <summary>
    /// Decrypts the specified ciphertext using the provided key.
    /// </summary>
    /// <param name="ciphertext">The ciphertext.</param>
    /// <param name="key">The decryption key.</param>
    /// <returns>The decrypted plaintext as a string.</returns>
    byte[] Decrypt(byte[] ciphertext, byte[] key);
}
