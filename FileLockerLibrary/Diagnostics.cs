using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public class Diagnostics
{
    public double AlgorithmDuration(FileModel model, EncryptionAlgorithm algorithm)
    {
        string fileName = model.EncryptionStatus ? Path.GetFileNameWithoutExtension(model.FileName) : model.FileName;

        List<LogModel> fileLogs = GlobalConfig.Logger.GetAllLogs().Where(log => log.Message.Contains(fileName)).OrderBy(log => log.Timestamp).ToList();
        DateTime start = DateTime.MinValue;
        int encryptionCount = 0;
        double duration = 0;
        string algorithmExtension = "";

        switch (algorithm)
        {
            case EncryptionAlgorithm.AES:
                algorithmExtension = Constants.AesExtension;
                break;
            case EncryptionAlgorithm.TripleDES:
                algorithmExtension = Constants.TripleDesExtension;
                break;
            default:
                throw new ArgumentException("Unsupported encryption algorithm.", nameof(algorithm));
        }

        foreach (LogModel log in fileLogs.Where(log => log.Message.Contains(algorithm.ToString())))
        {
            if (log.Message.Contains("encrypted"))
            {
                if (encryptionCount == 0)
                    start = log.Timestamp;

                encryptionCount++;
            }
            else if (log.Message.Contains("decrypted"))
            {
                encryptionCount--;
                if (encryptionCount == 0)
                    duration += (log.Timestamp - start).TotalDays;
            }
        }

        if (encryptionCount > 0)
            duration += (DateTime.Now - start).TotalDays;

        return duration;
    }

    public double UnencryptedDuration(FileModel model)
    {
        List<LogModel> fileLogs = GlobalConfig.Logger.GetAllLogs().Where(log => log.Message.Contains(model.FileName)).OrderBy(log => log.Timestamp).ToList();
        DateTime start = model.DateAdded;
        double duration = 0;
        int encryptionCount = 0;

        foreach (LogModel log in fileLogs)
        {
            if (log.Message.Contains("encrypted"))
            {
                if (start != DateTime.MinValue)
                {
                    encryptionCount++;
                    duration += (log.Timestamp - start).TotalDays;
                    start = DateTime.MinValue;
                }
            }
            else if (log.Message.Contains("decrypted"))
            {
                if (encryptionCount > 0)
                {
                    encryptionCount--;
                    if (start == DateTime.MinValue && encryptionCount == 0)
                        start = log.Timestamp;
                }
            }
        }

        if (encryptionCount == 0 && start != DateTime.MinValue)
            duration += (DateTime.Now - start).TotalDays;

        return duration;
    }
}
