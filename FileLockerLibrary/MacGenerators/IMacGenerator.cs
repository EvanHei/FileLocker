namespace FileLockerLibrary.MacGenerators;

/// <summary>
/// Interface for generating and validating message authentication codes (MACs).
/// </summary>
public interface IMacGenerator
{
    /// <summary>
    /// Generates a MAC for the given data.
    /// </summary>
    /// <param name="data">The data to generate the MAC for.</param>
    /// <returns>The generated MAC.</returns>
    byte[] GenerateMac(byte[] data);

    /// <summary>
    /// Validates whether the provided MAC matches the calculated MAC for the given data.
    /// </summary>
    /// <param name="data">The data to validate the MAC against.</param>
    /// <param name="expectedHmac">The expected MAC to validate against.</param>
    /// <returns><c>true</c> if the MAC is valid, <c>false</c> otherwise.</returns>
    bool ValidateMac(byte[] data, byte[] expectedHmac);

    /// <summary>
    /// Gets or sets the key used for MAC generation and validation.
    /// </summary>
    byte[] Key { get; set; }
}
