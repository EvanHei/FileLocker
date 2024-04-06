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
        AesEncryptor aesEncryptor = new();
        byte[] plaintext = Encoding.UTF8.GetBytes("This is a secret message.");
        byte[] key = new byte[32];
        using (RNGCryptoServiceProvider rng = new())
        {
            rng.GetBytes(key);
        }

        // Act
        byte[] encryptedData = aesEncryptor.Encrypt(plaintext, key);

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
        AesEncryptor aesEncryptor = new();
        byte[] key = new byte[32];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => aesEncryptor.Encrypt(null, key));
    }

    [Fact]
    public void Encrypt_NullKey_ThrowsArgumentNullException()
    {
        // Arrange
        AesEncryptor aesEncryptor = new();
        byte[] plaintext = Encoding.UTF8.GetBytes("This is a secret message.");

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => aesEncryptor.Encrypt(plaintext, null));
    }

    [Fact]
    public void Encrypt_InvalidKeyLength_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        AesEncryptor aesEncryptor = new();
        byte[] plaintext = Encoding.UTF8.GetBytes("This is a secret message.");
        byte[] key = new byte[31];

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => aesEncryptor.Encrypt(plaintext, key));
    }

    [Fact]
    public void Decrypt_ValidInput_ReturnsDecryptedPlaintext()
    {
        // Arrange
        AesEncryptor aesEncryptor = new();
        byte[] originalPlaintext = Encoding.UTF8.GetBytes("This is a secret message.");
        byte[] key = new byte[32];
        using (RNGCryptoServiceProvider rng = new())
        {
            rng.GetBytes(key);
        }

        // encrypt plaintext
        byte[] encryptedData = aesEncryptor.Encrypt(originalPlaintext, key);

        // Act
        byte[] decryptedPlaintext = aesEncryptor.Decrypt(encryptedData, key);

        // Assert
        Assert.Equal(originalPlaintext, decryptedPlaintext);
    }

    [Fact]
    public void Decrypt_NullCiphertext_ThrowsArgumentNullException()
    {
        // Arrange
        AesEncryptor aesEncryptor = new();
        byte[] key = new byte[32];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => aesEncryptor.Decrypt(null, key));
    }

    [Fact]
    public void Decrypt_NullKey_ThrowsArgumentNullException()
    {
        // Arrange
        AesEncryptor aesEncryptor = new();
        byte[] ciphertextAndIv = new byte[16];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => aesEncryptor.Decrypt(ciphertextAndIv, null));
    }

    [Fact]
    public void Decrypt_InvalidCiphertextLength_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        AesEncryptor aesEncryptor = new();
        byte[] key = new byte[32];

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => aesEncryptor.Decrypt(new byte[1], key));
    }

    [Fact]
    public void Decrypt_InvalidKeyLength_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        AesEncryptor aesEncryptor = new();
        byte[] ciphertextAndIv = new byte[16];
        byte[] key = new byte[31];

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => aesEncryptor.Decrypt(ciphertextAndIv, key));
    }

    [Fact]
    public void Encrypt_WithMinPaddingLength_ReturnsPaddedData()
    {
        // Arrange
        AesEncryptor encryptor = new();
        byte[] plaintext = new byte[16];
        byte[] key = new byte[32];
        long minPaddingLength = 32;

        // Act
        byte[] ciphertext = encryptor.Encrypt(plaintext, key, minPaddingLength);

        // Assert
        Assert.True(ciphertext.Length >= minPaddingLength);
    }

    [Fact]
    public void Decrypt_PaddedData_ReturnsOriginalData()
    {
        // Arrange
        AesEncryptor encryptor = new();
        byte[] plaintext = new byte[16];
        byte[] key = new byte[32];
        long minPaddingLength = 32;

        // Encrypt with additional padding
        byte[] ciphertext = encryptor.Encrypt(plaintext, key, minPaddingLength);

        // Act
        byte[] decryptedPlaintext = encryptor.Decrypt(ciphertext, key);

        // Assert
        Assert.Equal(plaintext.Length, decryptedPlaintext.Length);
    }
}
