using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FileLockerLibrary.Tests.SignerTests;

public class RsaSignerTests
{
    [Fact]
    public void GenerateKeyPair_ReturnsValidKeyPair()
    {
        // Arrange
        RsaSigner signer = new();

        // Act
        KeyPair keyPair = signer.GenerateKeyPair();

        // Assert
        Assert.NotNull(keyPair);
        Assert.NotNull(keyPair.PublicKey);
        Assert.NotNull(keyPair.PrivateKey);
        Assert.NotEmpty(keyPair.PublicKey);
        Assert.NotEmpty(keyPair.PrivateKey);
    }

    [Fact]
    public void SignAndVerify_ReturnsTrueWhenSignatureIsValid()
    {
        // Arrange
        RsaSigner signer = new();
        KeyPair keyPair = signer.GenerateKeyPair();
        byte[] data = new byte[] { 0x01, 0x02, 0x03, 0x04 };

        // Act
        byte[] signature = signer.Sign(keyPair.PrivateKey, data);
        bool isValid = signer.Verify(keyPair.PublicKey, signature, data);

        // Assert
        Assert.True(isValid);
    }

    [Fact]
    public void Verify_ReturnsFalseWhenSignatureIsInvalid()
    {
        // Arrange
        RsaSigner signer = new();
        KeyPair keyPair1 = signer.GenerateKeyPair();
        KeyPair keyPair2 = signer.GenerateKeyPair();
        byte[] data = new byte[] { 0x01, 0x02, 0x03, 0x04 };

        // Act
        byte[] signature = signer.Sign(keyPair1.PrivateKey, data);
        bool isValid = signer.Verify(keyPair2.PublicKey, signature, data);

        // Assert
        Assert.False(isValid);
    }
}
