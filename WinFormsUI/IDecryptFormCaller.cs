using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsUI;

/// <summary>
/// Represents a caller for a decrypt form.
/// </summary>
public interface IDecryptFormCaller
{
    /// <summary>
    /// Notifies the caller that the decryption process has been completed.
    /// </summary>
    void DecryptionComplete();
}
