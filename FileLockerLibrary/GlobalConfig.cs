using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public static class GlobalConfig
{
    public static IDataAccessor DataAccessor = new TextAccessor();

    public static IKeyDeriver KeyDeriver = new Pbkdf2KeyDeriver();

    public static IMacGenerator MacGenerator = new HmacGenerator();

    public static ILogger Logger = new SerilogLogger();

    public static IEncryptor Encryptor(EncryptionAlgorithm algorithm)
    {
        switch (algorithm)
        {
            case EncryptionAlgorithm.AES:
                return new AesEncryptor();
            case EncryptionAlgorithm.TripleDES:
                return new TripleDesEncryptor();
            default:
                throw new ArgumentException("Unsupported encryption algorithm.", nameof(algorithm));
        }
    }
}
