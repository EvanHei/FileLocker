namespace FileLockerLibrary;

/// <summary>
/// Represents a logger interface for logging messages at different severity levels.
/// </summary>
public interface ILogger
{
    /// <summary>
    /// Logs a debug message.
    /// </summary>
    /// <param name="message">The debug message to be logged.</param>
    void Debug(string message);

    /// <summary>
    /// Logs an informational message.
    /// </summary>
    /// <param name="message">The informational message to be logged.</param>
    void Info(string message);

    /// <summary>
    /// Logs a warning message.
    /// </summary>
    /// <param name="message">The warning message to be logged.</param>
    void Warning(string message);

    /// <summary>
    /// Logs an error message.
    /// </summary>
    /// <param name="message">The error message to be logged.</param>
    void Error(string message);

    /// <summary>
    /// Logs a fatal error message.
    /// </summary>
    /// <param name="message">The fatal error message to be logged.</param>
    void Fatal(string message);
}
