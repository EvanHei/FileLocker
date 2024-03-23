using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public interface IHasher
{
    byte[] Hash(byte[] data);
}
