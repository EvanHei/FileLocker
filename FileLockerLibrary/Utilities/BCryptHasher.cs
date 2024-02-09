using BCrypt.Net;

namespace FileLockerLibrary;

/// <summary>
/// Provides methods for hashing and verifying passwords using the BCrypt hashing algorithm.
/// </summary>
public class BCryptHasher
{
    /// <summary>
    /// Generates a BCrypt hash for the provided password.
    /// </summary>
    /// <param name="password">The password to be hashed.</param>
    /// <returns>The BCrypt hash of the provided password.</returns>
    public string HashPassword(string password)
    {
        string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
        return passwordHash;
    }

    /// <summary>
    /// Verifies an entered password against a stored BCrypt password hash.
    /// </summary>
    /// <param name="enteredPassword">The input password to be verified.</param>
    /// <param name="storedPasswordHash">The stored BCrypt password hash.</param>
    /// <exception cref="SaltParseException">Thrown when the salt is in the incorrect format.</exception>
    /// <returns>True if the password was verified; false otherwise.</returns>
    public bool VerifyPassword(string enteredPassword, string storedPasswordHash)
    {
        try
        {
            bool output = BCrypt.Net.BCrypt.Verify(enteredPassword, storedPasswordHash);
            return output;
        }
        catch (SaltParseException)
        {
            throw;
        }
    }
}
