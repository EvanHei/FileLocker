using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace FileLockerLibrary.Tests.EncryptorTests;

public class TripleDesEncryptorTests
{
    [Fact]
    public void Encrypt_ValidInput_ReturnsEncryptedDataWithIV()
    {
        // Arrange
        var tripleDesEncryptor = new TripleDesEncryptor();
        byte[] plaintext = Encoding.UTF8.GetBytes("This is a secret message.");
        byte[] key = new byte[24];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(key);
        }

        // Act
        var encryptedData = tripleDesEncryptor.Encrypt(plaintext, key);

        // Assert
        Assert.NotNull(encryptedData);
        Assert.True(encryptedData.Length > 0);

        // Ensure the encrypted data contains the initialization vector (IV)
        Assert.Equal(16, encryptedData.Take(16).ToArray().Length);
    }

    [Fact]
    public void Encrypt_NullPlaintext_ThrowsArgumentNullException()
    {
        // Arrange
        var tripleDesEncryptor = new TripleDesEncryptor();
        byte[] key = new byte[24];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => tripleDesEncryptor.Encrypt(null, key));
    }

    [Fact]
    public void Encrypt_NullKey_ThrowsArgumentNullException()
    {
        // Arrange
        var tripleDesEncryptor = new TripleDesEncryptor();
        byte[] plaintext = Encoding.UTF8.GetBytes("This is a secret message.");

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => tripleDesEncryptor.Encrypt(plaintext, null));
    }

    [Fact]
    public void Encrypt_InvalidKeyLength_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var tripleDesEncryptor = new TripleDesEncryptor();
        byte[] plaintext = Encoding.UTF8.GetBytes("This is a secret message.");
        byte[] key = new byte[23];

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => tripleDesEncryptor.Encrypt(plaintext, key));
    }

    [Fact]
    public void Decrypt_ValidInput_ReturnsDecryptedPlaintext()
    {
        // Arrange
        var tripleDesEncryptor = new TripleDesEncryptor();
        byte[] originalPlaintext = Encoding.UTF8.GetBytes("This is a secret message.");
        byte[] key = new byte[24];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(key);
        }

        // encrypt plaintext
        var encryptedData = tripleDesEncryptor.Encrypt(originalPlaintext, key);

        // Act
        var decryptedPlaintext = tripleDesEncryptor.Decrypt(encryptedData, key);

        // Assert
        Assert.Equal(originalPlaintext, decryptedPlaintext);
    }

    [Fact]
    public void Decrypt_NullCiphertext_ThrowsArgumentNullException()
    {
        // Arrange
        var tripleDesEncryptor = new TripleDesEncryptor();
        byte[] key = new byte[24];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => tripleDesEncryptor.Decrypt(null, key));
    }

    [Fact]
    public void Decrypt_NullKey_ThrowsArgumentNullException()
    {
        // Arrange
        var tripleDesEncryptor = new TripleDesEncryptor();
        byte[] ciphertextAndIv = new byte[16];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => tripleDesEncryptor.Decrypt(ciphertextAndIv, null));
    }

    [Fact]
    public void Decrypt_InvalidCiphertextLength_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var tripleDesEncryptor = new TripleDesEncryptor();
        byte[] key = new byte[24];

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => tripleDesEncryptor.Decrypt(new byte[1], key));
    }

    [Fact]
    public void Decrypt_InvalidKeyLength_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var tripleDesEncryptor = new TripleDesEncryptor();
        byte[] ciphertextAndIv = new byte[16];
        byte[] key = new byte[23];

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => tripleDesEncryptor.Decrypt(ciphertextAndIv, key));
    }
}
