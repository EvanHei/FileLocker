using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FileLockerLibrary;

public class EcdsaSigner : ISigner
{
    public KeyPair GenerateKeyPair()
    {
        byte[] publicKey;
        byte[] privateKey;

        using ECDsa ecdsa = ECDsa.Create();
        publicKey = ecdsa.ExportSubjectPublicKeyInfo();
        privateKey = ecdsa.ExportECPrivateKey();

        return new KeyPair(publicKey, privateKey);
    }

    public byte[] Sign(byte[] privateKey, byte[] data)
    {
        using ECDsa ecdsa = ECDsa.Create();
        ecdsa.ImportECPrivateKey(privateKey, out _);
        return ecdsa.SignData(data, HashAlgorithmName.SHA256);
    }

    public bool Verify(byte[] publicKey, byte[] signature, byte[] data)
    {
        try
        {
            using ECDsa ecdsa = ECDsa.Create();
            ecdsa.ImportSubjectPublicKeyInfo(publicKey, out _);
            return ecdsa.VerifyData(data, signature, HashAlgorithmName.SHA256);
        }
        catch (CryptographicException)
        {
            return false;
        }
    }
}
