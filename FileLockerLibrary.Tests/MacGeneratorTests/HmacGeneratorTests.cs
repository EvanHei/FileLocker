using System;
using Xunit;

namespace FileLockerLibrary.Tests.EncryptorTests;

public class HmacGeneratorTests
{
    [Fact]
    public void Key_SetKey_HmacKeyIsSet()
    {
        // Arrange
        var hmacGenerator = new HmacGenerator();
        byte[] key = new byte[32];

        // Act
        hmacGenerator.Key = key;

        // Assert
        Assert.Equal(key, hmacGenerator.Key);
    }

    [Fact]
    public void Key_SetNullKey_ThrowsArgumentNullException()
    {
        // Arrange
        var hmacGenerator = new HmacGenerator();

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => hmacGenerator.Key = null);
    }

    [Fact]
    public void GenerateMac_KeyNotSet_ThrowsNullReferenceException()
    {
        // Arrange
        var hmacGenerator = new HmacGenerator();
        byte[] data = { 1, 2, 3 };

        // Act & Assert
        Assert.Throws<NullReferenceException>(() => hmacGenerator.GenerateMac(data));
    }

    [Fact]
    public void Key_SetInvalidKeyLength_ThrowsArgumentException()
    {
        // Arrange
        var hmacGenerator = new HmacGenerator();
        byte[] invalidKey = new byte[16];

        // Act & Assert
        Assert.Throws<ArgumentException>(() => hmacGenerator.Key = invalidKey);
    }

    [Fact]
    public void GenerateMac_ValidInput_ReturnsHmac()
    {
        // Arrange
        var hmacGenerator = new HmacGenerator();
        byte[] key = new byte[32];
        byte[] data = { 1, 2, 3 };

        // Act
        hmacGenerator.Key = key;
        var hmac = hmacGenerator.GenerateMac(data);

        // Assert
        Assert.NotNull(hmac);
        Assert.NotEmpty(hmac);
    }

    [Fact]
    public void GenerateMac_NullData_ThrowsArgumentNullException()
    {
        // Arrange
        var hmacGenerator = new HmacGenerator();
        byte[] key = new byte[32];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => hmacGenerator.GenerateMac(null));
    }

    [Fact]
    public void ValidateMac_ValidInput_ReturnsTrue()
    {
        // Arrange
        var hmacGenerator = new HmacGenerator();
        byte[] key = new byte[32];
        byte[] data = { 1, 2, 3 };
        hmacGenerator.Key = key;
        var expectedHmac = hmacGenerator.GenerateMac(data);

        // Act
        hmacGenerator.Key = key;
        var isValid = hmacGenerator.ValidateMac(data, expectedHmac);

        // Assert
        Assert.True(isValid);
    }

    [Fact]
    public void ValidateMac_NullData_ThrowsArgumentNullException()
    {
        // Arrange
        var hmacGenerator = new HmacGenerator();
        byte[] key = new byte[32];
        byte[] expectedHmac = new byte[32];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => hmacGenerator.ValidateMac(null, expectedHmac));
    }

    [Fact]
    public void ValidateMac_NullExpectedHmac_ThrowsArgumentNullException()
    {
        // Arrange
        var hmacGenerator = new HmacGenerator();
        byte[] key = new byte[32];
        byte[] data = { 1, 2, 3 };

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => hmacGenerator.ValidateMac(data, null));
    }
}
