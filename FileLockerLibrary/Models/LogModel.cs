using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public class LogModel
{
    public DateTime Timestamp { get; set; }
    public LogLevel Level { get; set; }
    public string Message { get; set; }

    public LogModel(LogLevel level, string message)
    {
        Timestamp = DateTime.Now;
        Level = level;
        Message = message;
    }

    public LogModel(DateTime timestamp, LogLevel level, string message)
    {
        Timestamp = timestamp;
        Level = level;
        Message = message;
    }
}