using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public static class GlobalConfig
{
    public static IDataAccessor DataAccessor = new TextAccessor();

    public static IEncryptor Encryptor = new AesEncryptor();

    public static IKeyDeriver KeyDeriver = new Pbkdf2KeyDeriver();

    public static IMacGenerator MacGenerator = new HmacGenerator();

    public static ILogger Logger = new SerilogLogger();
}
