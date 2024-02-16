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
    /// Decrypts the specified ciphertext (and possibly initialization vector) using the provided key.
    /// </summary>
    /// <param name="ciphertext">The combined ciphertext (and possibly initialization vector).</param>
    /// <param name="key">The decryption key.</param>
    /// <returns>The decrypted plaintext as a string.</returns>
    byte[] Decrypt(byte[] ciphertext, byte[] key);
}
