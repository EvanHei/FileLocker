using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public static class GlobalConfig
{
    public static IDataAccessor DataAccessor { get; set; } = new TextAccessor();

    public static IEncryptor Encryptor { get; set; } = new AesEncryptor();

    public static IKeyDeriver KeyDeriver { get; set; } = new Pbkdf2KeyDeriver();

    public static IMacGenerator MacGenerator { get; set; } = new HmacGenerator();
}
