using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsUI;

/// <summary>
/// Represents a caller for a sign form.
/// </summary>
public interface ISignFormCaller
{
    /// <summary>
    /// Notifies the caller that the signing process has been completed.
    /// </summary>
    void SigningComplete();
}
