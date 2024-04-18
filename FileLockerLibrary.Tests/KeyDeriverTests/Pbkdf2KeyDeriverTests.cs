using FileLockerLibrary.KeyDerivers;
using System;
using Xunit;

namespace FileLockerLibrary.Tests.KeyDeriverTests;

public class Pbkdf2KeyDeriverTests
{
    [Fact]
    public void GenerateSalt_ReturnsValidSalt()
    {
        // Arrange
        Pbkdf2KeyDeriver pbkdf2KeyDeriver = new();

        // Act
        byte[] salt = pbkdf2KeyDeriver.GenerateSalt();

        // Assert
        Assert.NotNull(salt);
        Assert.Equal(32, salt.Length);
    }

    [Fact]
    public void DeriveKey_ValidInput_ReturnsDerivedKey()
    {
        // Arrange
        Pbkdf2KeyDeriver pbkdf2KeyDeriver = new();
        string password = "SecurePassword123";
        byte[] salt = pbkdf2KeyDeriver.GenerateSalt();

        // Act
        byte[] derivedKey = pbkdf2KeyDeriver.DeriveKey(password, salt);

        // Assert
        Assert.NotNull(derivedKey);
        Assert.Equal(32, derivedKey.Length);
    }

    [Fact]
    public void DeriveKey_NullPassword_ThrowsArgumentNullException()
    {
        // Arrange
        Pbkdf2KeyDeriver pbkdf2KeyDeriver = new();
        byte[] salt = new byte[32];

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => pbkdf2KeyDeriver.DeriveKey(null, salt));
    }

    [Fact]
    public void DeriveKey_NullSalt_ThrowsArgumentNullException()
    {
        // Arrange
        Pbkdf2KeyDeriver pbkdf2KeyDeriver = new();
        string password = "SecurePassword123";

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => pbkdf2KeyDeriver.DeriveKey(password, null));
    }
}
