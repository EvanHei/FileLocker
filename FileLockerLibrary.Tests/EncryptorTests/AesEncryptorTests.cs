using FileLockerLibrary;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace FileLockerLibrary.Tests.EncryptorTests;

public class AesEncryptorTests
{
    [Fact]
    public void Encrypt_ValidInput_ReturnsEncryptedDataWithIV()
    {
        // Arrange
        var aesEncryptor = new AesEncryptor();
        byte[] plaintext = Encoding.UTF8.GetBytes("This is a secret message.");
        byte[] key = new byte[32];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(key);
        }

        // Act
        var encryptedData = aesEncryptor.Encrypt(plaintext, key);

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
        var aesEncryptor = new AesEncryptor();
        byte[] key = new byte[32];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => aesEncryptor.Encrypt(null, key));
    }

    [Fact]
    public void Encrypt_NullKey_ThrowsArgumentNullException()
    {
        // Arrange
        var aesEncryptor = new AesEncryptor();
        byte[] plaintext = Encoding.UTF8.GetBytes("This is a secret message.");

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => aesEncryptor.Encrypt(plaintext, null));
    }

    [Fact]
    public void Encrypt_InvalidKeyLength_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var aesEncryptor = new AesEncryptor();
        byte[] plaintext = Encoding.UTF8.GetBytes("This is a secret message.");
        byte[] key = new byte[31];

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => aesEncryptor.Encrypt(plaintext, key));
    }

    [Fact]
    public void Decrypt_ValidInput_ReturnsDecryptedPlaintext()
    {
        // Arrange
        var aesEncryptor = new AesEncryptor();
        byte[] originalPlaintext = Encoding.UTF8.GetBytes("This is a secret message.");
        byte[] key = new byte[32];
        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(key);
        }

        // encrypt plaintext
        var encryptedData = aesEncryptor.Encrypt(originalPlaintext, key);

        // Act
        var decryptedPlaintext = aesEncryptor.Decrypt(encryptedData, key);

        // Assert
        Assert.Equal(originalPlaintext, decryptedPlaintext);
    }

    [Fact]
    public void Decrypt_NullCiphertext_ThrowsArgumentNullException()
    {
        // Arrange
        var aesEncryptor = new AesEncryptor();
        byte[] key = new byte[32];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => aesEncryptor.Decrypt(null, key));
    }

    [Fact]
    public void Decrypt_NullKey_ThrowsArgumentNullException()
    {
        // Arrange
        var aesEncryptor = new AesEncryptor();
        byte[] ciphertextAndIv = new byte[16];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => aesEncryptor.Decrypt(ciphertextAndIv, null));
    }

    [Fact]
    public void Decrypt_InvalidCiphertextLength_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var aesEncryptor = new AesEncryptor();
        byte[] key = new byte[32];

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => aesEncryptor.Decrypt(new byte[1], key));
    }

    [Fact]
    public void Decrypt_InvalidKeyLength_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var aesEncryptor = new AesEncryptor();
        byte[] ciphertextAndIv = new byte[16];
        byte[] key = new byte[31];

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => aesEncryptor.Decrypt(ciphertextAndIv, key));
    }
}
