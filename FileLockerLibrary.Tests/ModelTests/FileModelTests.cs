using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FileLockerLibrary.Tests.ModelTests;

public class FileModelTests
{
    private const string TestFilePath = "testfile.txt";
    private const string TestPassword = "TestPassword123";

    [Fact]
    public void Lock_FileNotFound_ThrowsFileNotFoundException()
    {
        // Arrange
        string nonExistentFilePath = "nonexistentfile.txt";
        FileModel fileModel = new(nonExistentFilePath);
        fileModel.Password = TestPassword;

        // Act & Assert
        FileNotFoundException exception = Assert.Throws<FileNotFoundException>(() => fileModel.Lock(EncryptionAlgorithm.AES));
    }

    [Fact]
    public void Unlock_FileNotFound_ThrowsFileNotFoundException()
    {
        // Arrange
        FileModel fileModel = new(TestFilePath);
        fileModel.Password = TestPassword;

        // Act & Assert
        Assert.Throws<FileNotFoundException>(fileModel.Unlock);
    }
}
