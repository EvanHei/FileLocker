namespace FileLockerLibrary;

/// <summary>
/// Represents an interface for generating and validating a Message Authentication Code (MAC).
/// </summary>
public interface IMacGenerator
{
    /// <summary>
    /// Generates an MAC for the provided data.
    /// </summary>
    /// <param name="data">The data for which to generate the MAC.</param>
    /// <returns>The generated MAC as a byte array.</returns>
    byte[] GenerateMac(byte[] data);

    /// <summary>
    /// Validates a MAC for the provided data against an expected MAC.
    /// </summary>
    /// <param name="data">The data for which to validate the MAC.</param>
    /// <param name="expectedHmac">The expected MAC to compare against.</param>
    /// <returns>True if the MAC is valid; otherwise, false.</returns>
    bool ValidateMac(byte[] data, byte[] expectedHmac);

    /// <summary>
    /// The key used for MAC generation and validation.
    /// </summary>
    byte[] Key { get; set; }
}
