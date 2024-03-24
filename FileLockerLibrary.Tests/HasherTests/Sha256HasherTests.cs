using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FileLockerLibrary.Tests.HasherTests;

public class Sha256HasherTests
{
    [Fact]
    public void Hash_ValidData_ReturnsNonNullHash()
    {
        // Arrange
        Sha256Hasher hasher = new();
        byte[] testData = Encoding.UTF8.GetBytes("test data");

        // Act
        byte[] hash = hasher.Hash(testData);

        // Assert
        Assert.NotNull(hash);
    }

    [Fact]
    public void Hash_ValidData_ReturnsCorrectHashLength()
    {
        // Arrange
        Sha256Hasher hasher = new();
        byte[] testData = Encoding.UTF8.GetBytes("test data");

        // Act
        byte[] hash = hasher.Hash(testData);

        // Assert
        Assert.Equal(32, hash.Length); // SHA-256 produces a 32-byte hash
    }

    [Fact]
    public void Hash_SameInput_ReturnsSameHash()
    {
        // Arrange
        Sha256Hasher hasher = new();
        byte[] testData1 = Encoding.UTF8.GetBytes("test data");
        byte[] testData2 = Encoding.UTF8.GetBytes("test data");

        // Act
        byte[] hash1 = hasher.Hash(testData1);
        byte[] hash2 = hasher.Hash(testData2);

        // Assert
        Assert.Equal(hash1, hash2);
    }

    [Fact]
    public void Hash_DifferentInput_ReturnsDifferentHash()
    {
        // Arrange
        Sha256Hasher hasher = new();
        byte[] testData1 = Encoding.UTF8.GetBytes("test data 1");
        byte[] testData2 = Encoding.UTF8.GetBytes("test data 2");

        // Act
        byte[] hash1 = hasher.Hash(testData1);
        byte[] hash2 = hasher.Hash(testData2);

        // Assert
        Assert.NotEqual(hash1, hash2);
    }

    [Fact]
    public void Hash_NullData_ThrowsArgumentNullException()
    {
        // Arrange
        Sha256Hasher hasher = new();

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => hasher.Hash(null));
    }
}
