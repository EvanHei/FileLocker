using System;
using System.Text;

namespace FileLockerLibrary;

/// <summary>
/// Dummy implementation of the IEncryptor interface that doesn't perform actual encryption.
/// </summary>
public class DummyEncryptor : IEncryptor
{
    /// <summary>
    /// Dummy implementation of encryption that returns the plaintext as bytes without encryption.
    /// </summary>
    /// <param name="plaintext">The plaintext to be "encrypted".</param>
    /// <param name="key">The encryption key (not used in this dummy implementation).</param>
    /// <returns>The plaintext converted to bytes.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the plaintext or key is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the plaintext or key has invalid length.</exception>
    public byte[] Encrypt(byte[] plaintext, byte[] key)
    {
        if (plaintext == null)
            throw new ArgumentNullException("Plaintext is null.");
        if (key == null)
            throw new ArgumentNullException("Key is null.");
        if (plaintext.Length < 0)
            throw new ArgumentOutOfRangeException("Plaintext has invalid length.");
        if (key.Length != 32)
            throw new ArgumentOutOfRangeException("Key must be 32 bytes (256 bits) long.");

        return plaintext;
    }

    /// <summary>
    /// Dummy implementation of decryption that converts the bytes back to a string without decryption.
    /// </summary>
    /// <param name="ciphertext">The "ciphertext" bytes (plaintext bytes in this dummy implementation).</param>
    /// <param name="key">The decryption key (not used in this dummy implementation).</param>
    /// <returns>The decrypted string.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the ciphertext or key is null.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the ciphertext or key has invalid length.</exception>
    public byte[] Decrypt(byte[] ciphertext, byte[] key)
    {
        if (ciphertext == null)
            throw new ArgumentNullException("Ciphertext is null.");
        if (key == null)
            throw new ArgumentNullException("Key is null.");
        if (ciphertext.Length < 0)
            throw new ArgumentOutOfRangeException("Ciphertext has invalid length.");
        if (key.Length != 32)
            throw new ArgumentOutOfRangeException("Key must be 32 bytes (256 bits) long.");

        return ciphertext;
    }
}
