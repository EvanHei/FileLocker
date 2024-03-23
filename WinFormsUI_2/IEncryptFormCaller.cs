using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsUI_2;

/// <summary>
/// Represents a caller for a encrypt form.
/// </summary>
public interface IEncryptFormCaller
{
    /// <summary>
    /// Notifies the caller that the encryption process has been completed.
    /// </summary>
    void EncryptionComplete();
}
