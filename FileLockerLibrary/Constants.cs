using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public static class Constants
{
    public const string EncryptedExtension = ".locked";
    public const string FilePathFileName = "Path.txt";
    public const string EncryptionKeySaltFileName = "EncryptionKey.salt";
    public const string MacFileName = "Content.mac";
    public const string MacKeySaltFileName = "MacKey.salt";
    public const string GitHubUrl = "https://github.com/EvanHei/FileLocker";
}
