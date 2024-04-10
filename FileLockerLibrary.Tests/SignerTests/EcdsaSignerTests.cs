using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FileLockerLibrary.Tests.SignerTests;

public class EcdsaSignerTests
{
    [Fact]
    public void GenerateKeyPair_ReturnsValidKeyPair()
    {
        // Arrange
        EcdsaSigner signer = new();

        // Act
        KeyPairModel keyPair = signer.GenerateKeyPair();

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
        EcdsaSigner signer = new();
        KeyPairModel keyPair = signer.GenerateKeyPair();
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
        EcdsaSigner signer = new();
        KeyPairModel keyPair1 = signer.GenerateKeyPair();
        KeyPairModel keyPair2 = signer.GenerateKeyPair();
        byte[] data = new byte[] { 0x01, 0x02, 0x03, 0x04 };

        // Act
        byte[] signature = signer.Sign(keyPair1.PrivateKey, data);
        bool isValid = signer.Verify(keyPair2.PublicKey, signature, data);

        // Assert
        Assert.False(isValid);
    }
}
