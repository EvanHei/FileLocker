using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public interface ISigner
{
    KeyPairModel GenerateKeyPair();
    byte[] Sign(byte[] privateKey, byte[] data);
    bool Verify(byte[] publicKey, byte[] signature, byte[] data);
}
