using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public class KeyPairModel
{
    public string Name { get; set; }
    public DigSigAlgorithm Algorithm { get; set; }
    public byte[] PublicKey { get; set; }
    public byte[] PrivateKey { get; set; }

    [JsonIgnore]
    public string DisplayName
    {
        get
        {
            string output = "";

            if (Algorithm == DigSigAlgorithm.RSA)
                output += "RSA    ";
            else if (Algorithm == DigSigAlgorithm.ECDSA)
                output += "ECDSA";

            string keyPairName = Name.Length > 35 ? Name.Substring(0, 32) + "..." : Name;
            output += $" {keyPairName}";

            return output;
        }
    }

    public KeyPairModel(DigSigAlgorithm algorithm, byte[] publicKey, byte[] privateKey)
    {
        Algorithm = algorithm;
        PublicKey = publicKey;
        PrivateKey = privateKey;
    }
}
