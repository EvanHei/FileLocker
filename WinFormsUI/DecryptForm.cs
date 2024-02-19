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
    private bool isEyeballLabelClicked = false;

    public DecryptForm(IDecryptFormCaller caller, FileModel model)
    {
        InitializeComponent();

        this.caller = caller;
        this.model = model;
    }

    private void EnterButton_Click(object sender, EventArgs e)
    {
        if (model.EncryptionKeySalt == null)
            throw new ArgumentNullException("Encryption key salt cannot be null.", nameof(model.EncryptionKeySalt));
        if (!ValidateInputFields())
            return;

        try
        {
            model.Password = PasswordMaskedTextBox.Text;

            if (model.TamperedStatus == false)
            {
                model.Unlock();
                GlobalConfig.DataAccessor.SaveFileModel(model);
            }
            else
                MessageBox.Show("Unable to decrypt. If the password was correct, the data has been tampered.", "Error", MessageBoxButtons.OK);
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

    private void EyeballLabel_Click(object sender, EventArgs e)
    {
        // toggle off
        if (isEyeballLabelClicked)
        {
            PasswordMaskedTextBox.UseSystemPasswordChar = true;
            EyeballLabel.ForeColor = SystemColors.ButtonFace;

            isEyeballLabelClicked = false;
        }
        // toggle on
        else
        {
            PasswordMaskedTextBox.UseSystemPasswordChar = false;
            EyeballLabel.ForeColor = SystemColors.Highlight;

            isEyeballLabelClicked = true;
        }
    }
}
