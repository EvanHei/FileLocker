using System;
using System.IO;
using Serilog;

namespace FileLockerLibrary;

/// <summary>
/// Implementation of the <see cref="ILogger"/> interface using Serilog.
/// </summary>
public class SerilogLogger : ILogger
{
    /// <summary>
    /// Gets or sets the path to the directory where log files are stored.
    /// </summary>
    private string LogDirectoryPath { get; set; }

    /// <summary>
    /// Gets all logs stored in log files.
    /// </summary>
    /// <returns>A list of log models containing log entries.</returns>
    public List<LogModel> LoadAllLogs()
    {
        List<LogModel> logs = new();

        List<string> logFiles = Directory.GetFiles(LogDirectoryPath).ToList();
        foreach (string logFile in logFiles)
        {
            List<string> logEntries = File.ReadAllLines(logFile).ToList();
            foreach (string logEntry in logEntries)
            {
                List<string> parts = logEntry.Split(' ').ToList();

                // timestamp
                if (!DateTime.TryParse(parts[0] + " " + parts[1], out DateTime timestamp))
                    throw new FormatException("Invalid timestamp format.");

                // level
                if (!Enum.TryParse(parts[2], true, out LogLevel level))
                    throw new FormatException("Invalid log level format.");

                // message
                string message = string.Join(" ", parts.GetRange(3, parts.Count - 3));

                logs.Add(new LogModel(timestamp, level, message));
            }
        }

        return logs;
    }

    /// <summary>
    /// Logs a message with the specified log level.
    /// </summary>
    /// <param name="message">The message to log.</param>
    /// <param name="level">The log level of the message.</param>
    public void Log(string message, LogLevel level)
    {
        // create system log file
        string logFilePath = Path.Combine(LogDirectoryPath, ".txt");

        // configure logger
        Serilog.Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.File(logFilePath,
                          outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} {Level:u} {Message:lj}{NewLine}{Exception}",
                          rollingInterval: RollingInterval.Day)
            .CreateLogger();

        switch (level)
        {
            case LogLevel.Information:
                Serilog.Log.Information(message);
                break;
            case LogLevel.Debug:
                Serilog.Log.Debug(message);
                break;
            case LogLevel.Warning:
                Serilog.Log.Warning(message);
                break;
            case LogLevel.Error:
                Serilog.Log.Error(message);
                break;
            case LogLevel.Fatal:
                Serilog.Log.Fatal(message);
                break;
        }

        Serilog.Log.CloseAndFlush();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SerilogLogger"/> class.
    /// </summary>
    public SerilogLogger()
    {
        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        LogDirectoryPath = Path.Combine(appDataPath, Constants.AppDirectoryName, Constants.LogDirectoryName);

        // create hidden log folder if it doesn't exist
        Directory.CreateDirectory(LogDirectoryPath);
        FileAttributes attributes = File.GetAttributes(LogDirectoryPath);
        attributes |= FileAttributes.Hidden;
        File.SetAttributes(LogDirectoryPath, attributes);
    }
}
