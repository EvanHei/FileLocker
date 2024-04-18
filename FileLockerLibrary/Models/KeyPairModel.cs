using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FileLockerLibrary.Models;

/// <summary>
/// Represents a model for a key pair used in digital signatures.
/// </summary>
public class KeyPairModel
{
    /// <summary>
    /// Gets or sets the name of the key pair.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the algorithm used for digital signatures.
    /// </summary>
    public DigSigAlgorithm Algorithm { get; set; }

    /// <summary>
    /// Gets or sets the public key.
    /// </summary>
    public byte[] PublicKey { get; set; }

    /// <summary>
    /// Gets or sets the private key.
    /// </summary>
    public byte[] PrivateKey { get; set; }

    /// <summary>
    /// Gets the display name of the key pair.
    /// </summary>
    [JsonIgnore]
    public string DisplayName
    {
        get
        {
            string output = "";

            if (Algorithm == DigSigAlgorithm.RSA)
                output += "RSA      ";
            else if (Algorithm == DigSigAlgorithm.ECDSA)
                output += "ECDSA ";

            string keyPairName = Name.Length > 35 ? Name.Substring(0, 32) + "..." : Name;
            output += $" {keyPairName}";

            return output;
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="KeyPairModel"/> class with the specified algorithm, public key, and private key.
    /// </summary>
    /// <param name="algorithm">The algorithm used for digital signatures.</param>
    /// <param name="publicKey">The public key.</param>
    /// <param name="privateKey">The private key.</param>
    public KeyPairModel(DigSigAlgorithm algorithm, byte[] publicKey, byte[] privateKey)
    {
        Algorithm = algorithm;
        PublicKey = publicKey;
        PrivateKey = privateKey;
    }
}
