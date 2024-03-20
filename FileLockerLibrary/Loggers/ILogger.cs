namespace FileLockerLibrary;

public interface ILogger
{
    void Log(string message, LogLevel level);
    List<LogModel> GetAllLogs();
}
