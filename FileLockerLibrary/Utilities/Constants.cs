using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

/// <summary>
/// Provides constants for files.
/// </summary>
public static class Constants
{
    public const string EncryptedExtension = ".ciphertext";
    public const string FilePathFileName = "Path.txt";
    public const string EncryptionKeySaltFileName = "EncryptionKey.salt";
    public const string GitHubUrl = "https://github.com/EvanHei/FileLocker";
}
