using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public class Sha256Hasher : IHasher
{
    public byte[] Hash(byte[] data)
    {
        byte[] hash = SHA256.HashData(data);
        return hash;
    }
}
