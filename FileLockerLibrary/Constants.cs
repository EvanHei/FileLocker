using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public static class Constants
{
    // 10MB
    public const long MaxFileSize = 10 * 1024 * 1024;
    public const int MinPasswordLength = 8;
    public const int MaxPasswordLength = 64;
    public const string AppDirectoryName = "FileLocker";
    public const string FileModelsDirectoryName = "FileModels";
    public const string TempExportDirectoryName = "TempExport";
    public const string LogDirectoryName = "Logs";
    public const string AesExtension = ".aes";
    public const string TripleDesExtension = ".3des";
    public const string ExportExtension = ".filelocker";
    public const string FilePathFileName = "Path.txt";
    public const string EncryptionKeySaltFileName = "EncryptionKey.salt";
    public const string MacFileName = "Content.mac";
    public const string MacKeySaltFileName = "MacKey.salt";
    public const string GitHubUrl = "https://github.com/EvanHei/FileLocker";
}
