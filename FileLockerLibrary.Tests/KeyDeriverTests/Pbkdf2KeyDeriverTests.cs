using System;
using Xunit;

namespace FileLockerLibrary.Tests.EncryptorTests;

public class Pbkdf2KeyDeriverTests
{
    [Fact]
    public void GenerateSalt_ReturnsValidSalt()
    {
        // Arrange
        var pbkdf2KeyDeriver = new Pbkdf2KeyDeriver();

        // Act
        var salt = pbkdf2KeyDeriver.GenerateSalt();

        // Assert
        Assert.NotNull(salt);
        Assert.Equal(32, salt.Length);
    }

    [Fact]
    public void DeriveKey_ValidInput_ReturnsDerivedKey()
    {
        // Arrange
        var pbkdf2KeyDeriver = new Pbkdf2KeyDeriver();
        string password = "SecurePassword123";
        var salt = pbkdf2KeyDeriver.GenerateSalt();

        // Act
        var derivedKey = pbkdf2KeyDeriver.DeriveKey(password, salt);

        // Assert
        Assert.NotNull(derivedKey);
        Assert.Equal(32, derivedKey.Length);
    }

    [Fact]
    public void DeriveKey_NullPassword_ThrowsArgumentNullException()
    {
        // Arrange
        var pbkdf2KeyDeriver = new Pbkdf2KeyDeriver();
        byte[] salt = new byte[32];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => pbkdf2KeyDeriver.DeriveKey(null, salt));
    }

    [Fact]
    public void DeriveKey_NullSalt_ThrowsArgumentNullException()
    {
        // Arrange
        var pbkdf2KeyDeriver = new Pbkdf2KeyDeriver();
        string password = "SecurePassword123";

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => pbkdf2KeyDeriver.DeriveKey(password, null));
    }
}
