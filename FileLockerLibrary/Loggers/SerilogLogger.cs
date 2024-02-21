using System;
using System.IO;
using Serilog;

namespace FileLockerLibrary;

public class SerilogLogger : ILogger
{
    public SerilogLogger()
    {
        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string logDirectoryPath = Path.Combine(appDataPath, Constants.AppDirectoryName, Constants.LogDirectoryName);

        // create hidden log folder
        Directory.CreateDirectory(logDirectoryPath);
        FileAttributes attributes = File.GetAttributes(logDirectoryPath);
        attributes |= FileAttributes.Hidden;
        File.SetAttributes(logDirectoryPath, attributes);

        // create system log file
        string logFilePath = Path.Combine(logDirectoryPath, ".txt");

        // configure logger
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.File(logFilePath, rollingInterval: RollingInterval.Day)
            .CreateLogger();
    }

    public void Debug(string message)
    {
        Log.Debug(message);
    }

    public void Info(string message)
    {
        Log.Information(message);
    }

    public void Warning(string message)
    {
        Log.Warning(message);
    }

    public void Error(string message)
    {
        Log.Error(message);
    }

    public void Fatal(string message)
    {
        Log.Fatal(message);
    }
}
