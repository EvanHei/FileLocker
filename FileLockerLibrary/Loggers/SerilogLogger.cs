using System;
using System.IO;
using Serilog;

namespace FileLockerLibrary;

public class SerilogLogger : ILogger
{
    private string LogDirectoryPath { get; set; }

    public List<LogModel> GetAllLogs()
    {
        List<LogModel> logs = new List<LogModel>();

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

    public SerilogLogger()
    {
        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        LogDirectoryPath = Path.Combine(appDataPath, Constants.AppDirectoryName, Constants.LogDirectoryName);

        // create hidden log folder if it doesn't exist
        Directory.CreateDirectory(LogDirectoryPath);
        FileAttributes attributes = File.GetAttributes(LogDirectoryPath);
        attributes |= FileAttributes.Hidden;
        File.SetAttributes(LogDirectoryPath, attributes);

        //// create system log file
        //string logFilePath = Path.Combine(LogDirectoryPath, ".txt");

        //// configure logger
        //Serilog.Log.Logger = new LoggerConfiguration()
        //    .MinimumLevel.Debug()
        //    .WriteTo.File(logFilePath,
        //                  outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} {Level:u} {Message:lj}{NewLine}{Exception}",
        //                  rollingInterval: RollingInterval.Day)
        //    .CreateLogger();
    }
}
