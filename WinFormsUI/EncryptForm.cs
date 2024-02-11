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

public partial class EncryptForm : Form
{
    private IEncryptFormCaller caller;
    private FileModel model;

    public EncryptForm(IEncryptFormCaller caller, FileModel model)
    {
        InitializeComponent();

        this.caller = caller;
        this.model = model;
    }

    private void EnterButton_Click(object sender, EventArgs e)
    {
        if (!ValidateInputFields())
            return;

        try
        {
            model.Password = PasswordMaskedTextBox.Text;
            model.EncryptionKey = GlobalConfig.KeyDeriver.DeriveKey(model.Password, model.EncryptionKeySalt);
            model.Encrypt();
            GlobalConfig.DataAccessor.SaveFileModel(model);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
        }
        finally
        {
            this.Close();
            caller.EncryptionComplete();
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

        if (PasswordMaskedTextBox.Text.Length < 8)
        {
            MessageBox.Show("Password must be at least 8 characters long.", "Invalid Input", MessageBoxButtons.OK);
            output = false;
        }
        if (!PasswordMaskedTextBox.Text.Any(char.IsUpper))
        {
            MessageBox.Show("Password must contain at least one uppercase letter.", "Invalid Input", MessageBoxButtons.OK);
            output = false;
        }
        if (!PasswordMaskedTextBox.Text.Any(char.IsLower))
        {
            MessageBox.Show("Password must contain at least one lowercase letter.", "Invalid Input", MessageBoxButtons.OK);
            output = false;
        }
        if (!PasswordMaskedTextBox.Text.Any(char.IsDigit))
        {
            MessageBox.Show("Password must contain at least one digit.", "Invalid Input", MessageBoxButtons.OK);
            output = false;
        }
        if (!PasswordMaskedTextBox.Text.Any(ch => !char.IsLetterOrDigit(ch)))
        {
            MessageBox.Show("Password must contain at least one special character.", "Invalid Input", MessageBoxButtons.OK);
            output = false;
        }
        if (PasswordMaskedTextBox.Text != ConfirmPasswordMaskedTextBox.Text)
        {
            MessageBox.Show("Confirm password field does not match password field.", "Invalid Input", MessageBoxButtons.OK);
            output = false;
        }

        return output;
    }
}
