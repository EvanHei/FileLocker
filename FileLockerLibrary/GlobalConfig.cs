using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary
{
    public static class GlobalConfig
    {
        public static TextAccessor DataAccessor { get; set; } = new TextAccessor();
        public static BCryptHasher Hasher { get; set; } = new BCryptHasher();
    }
}
