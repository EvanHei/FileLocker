using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileLockerLibrary.Models;

/// <summary>
/// Represents a log entry containing information about the timestamp, log level, and message.
/// </summary>
public class LogModel
{
    /// <summary>
    /// Gets or sets the timestamp when the log entry was created.
    /// </summary>
    public DateTime Timestamp { get; set; }

    /// <summary>
    /// Gets or sets the log level of the log entry.
    /// </summary>
    public LogLevel Level { get; set; }

    /// <summary>
    /// Gets or sets the message associated with the log entry.
    /// </summary>
    public string Message { get; set; }

    public string DisplayName
    {
        get
        {
            return $"{Level} {Timestamp.ToShortDateString()} {Message}";
        }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LogModel"/> class with the current timestamp.
    /// </summary>
    /// <param name="level">The log level of the log entry.</param>
    /// <param name="message">The message associated with the log entry.</param>
    public LogModel(LogLevel level, string message)
    {
        Timestamp = DateTime.Now;
        Level = level;
        Message = message;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LogModel"/> class with the specified timestamp.
    /// </summary>
    /// <param name="timestamp">The timestamp of the log entry.</param>
    /// <param name="level">The log level of the log entry.</param>
    /// <param name="message">The message associated with the log entry.</param>
    public LogModel(DateTime timestamp, LogLevel level, string message)
    {
        Timestamp = timestamp;
        Level = level;
        Message = message;
    }
}
