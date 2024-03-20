using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public enum EncryptionAlgorithm
{
    AES,
    TripleDES
}

public enum LogLevel
{
    Information,
    Debug,
    Warning,
    Error,
    Fatal
}