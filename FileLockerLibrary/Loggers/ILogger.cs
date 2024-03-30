namespace FileLockerLibrary;

/// <summary>
/// Represents a logger interface for logging messages with different log levels.
/// </summary>
public interface ILogger
{
    /// <summary>
    /// Logs a message with the specified log level.
    /// </summary>
    /// <param name="message">The message to log.</param>
    /// <param name="level">The log level of the message.</param>
    void Log(string message, LogLevel level);

    /// <summary>
    /// Retrieves all logs stored by the logger.
    /// </summary>
    /// <returns>A list of log models containing log entries.</returns>
    List<LogModel> GetAllLogs();
}
