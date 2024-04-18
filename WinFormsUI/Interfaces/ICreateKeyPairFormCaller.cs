using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsUI.Interfaces;

/// <summary>
/// Represents a caller for a create key pair form.
/// </summary>
public interface ICreateKeyPairFormCaller
{
    /// <summary>
    /// Notifies the caller that the key pair creation process has been completed.
    /// </summary>
    void KeyPairCreationComplete();
}
