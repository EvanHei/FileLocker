using FileLockerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI;

public partial class DecryptForm : Form
{
    private IDecryptFormCaller caller;
    private FileModel model;

    public DecryptForm(IDecryptFormCaller caller, FileModel model)
    {
        InitializeComponent();

        this.caller = caller;
        this.model = model;
    }

    private void EnterButton_Click(object sender, EventArgs e)
    {
        if (model.PasswordHash == null)
            throw new ArgumentNullException("Password hash cannot be null.", nameof(model.PasswordHash));
        if (model.EncryptionKeySalt == null)
            throw new ArgumentNullException("Encryption key salt cannot be null.", nameof(model.EncryptionKeySalt));
        if (!ValidateInputFields())
            return;

        // validate password hash
        model.Password = PasswordMaskedTextBox.Text;
        if (!GlobalConfig.Hasher.VerifyPassword(model.Password, model.PasswordHash))
        {
            MessageBox.Show("Invalid password.", "Error", MessageBoxButtons.OK);
            return;
        }

        try
        {
            model.EncryptionKey = GlobalConfig.KeyDeriver.DeriveKey(model.Password, model.EncryptionKeySalt);
            model.Decrypt();
            GlobalConfig.DataAccessor.SaveFileModel(model);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
        }
        finally
        {
            this.Close();
            caller.DecryptionComplete();
        }
    }

    /// <summary>
    /// Validates the input fields on the form.
    /// </summary>
    /// <returns>
    /// True if the input fields are valid; otherwise, false.
    /// </returns>
    private bool ValidateInputFields()
    {
        bool output = true;

        if (string.IsNullOrWhiteSpace(PasswordMaskedTextBox.Text))
        {
            MessageBox.Show("No password provided.", "Invalid Input", MessageBoxButtons.OK);
            output = false;
        }

        return output;
    }
}
