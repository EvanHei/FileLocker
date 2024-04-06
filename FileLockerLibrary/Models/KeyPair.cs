using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public class KeyPair
{
    public byte[] PublicKey { get; private set; }
    public byte[] PrivateKey { get; private set; }

    public KeyPair(byte[] publicKey, byte[] privateKey)
    {
        PublicKey = publicKey;
        PrivateKey = privateKey;
    }
}
