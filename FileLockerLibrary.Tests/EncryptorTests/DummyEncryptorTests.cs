using FileLockerLibrary;
using System;
using System.Text;
using Xunit;

namespace FileLockerLibrary.Tests.EncryptorTests;

public class DummyEncryptorTests
{
    [Fact]
    public void Encrypt_ValidInput_ReturnsPlaintextAsBytes()
    {
        // Arrange
        var dummyEncryptor = new DummyEncryptor();
        byte[] plaintext = Encoding.UTF8.GetBytes("This is a secret message.");
        byte[] key = new byte[32];

        // Act
        var ciphertext = dummyEncryptor.Encrypt(plaintext, key);

        // Assert
        Assert.NotNull(ciphertext);
        Assert.True(ciphertext.Length > 0);

        // Ensure the encrypted data is equivalent to the original plaintext as bytes
        Assert.Equal(plaintext, ciphertext);
    }

    [Fact]
    public void Encrypt_NullPlaintext_ThrowsArgumentNullException()
    {
        // Arrange
        var dummyEncryptor = new DummyEncryptor();
        byte[] key = new byte[32];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => dummyEncryptor.Encrypt(null, key));
    }

    [Fact]
    public void Encrypt_NullKey_ThrowsArgumentNullException()
    {
        // Arrange
        var dummyEncryptor = new DummyEncryptor();
        byte[] plaintext = Encoding.UTF8.GetBytes("This is a secret message.");

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => dummyEncryptor.Encrypt(plaintext, null));
    }

    [Fact]
    public void Decrypt_ValidInput_ReturnsCiphertextAsPlainText()
    {
        // Arrange
        var dummyEncryptor = new DummyEncryptor();
        byte[] originalPlaintext = Encoding.UTF8.GetBytes("This is a secret message.");
        byte[] key = new byte[32];

        // Encrypt the original plaintext
        var ciphertext = dummyEncryptor.Encrypt(originalPlaintext, key);

        // Act
        var decryptedPlaintext = dummyEncryptor.Decrypt(ciphertext, key);

        // Assert
        Assert.Equal(originalPlaintext, decryptedPlaintext);
    }

    [Fact]
    public void Decrypt_NullCiphertext_ThrowsArgumentNullException()
    {
        // Arrange
        var dummyEncryptor = new DummyEncryptor();
        byte[] key = new byte[32];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => dummyEncryptor.Decrypt(null, key));
    }

    [Fact]
    public void Decrypt_NullKey_ThrowsArgumentNullException()
    {
        // Arrange
        var dummyEncryptor = new DummyEncryptor();
        byte[] ciphertext = Encoding.UTF8.GetBytes("Dummy ciphertext");

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => dummyEncryptor.Decrypt(ciphertext, null));
    }
}
