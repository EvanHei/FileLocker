using FileLockerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        ResetTimer();

        try
        {
            model.Password = PasswordMaskedTextBox.Text;
            model.Unlock();
            GlobalConfig.DataAccessor.SaveFileModel(model);
            this.Close();
            caller.DecryptionComplete();
        }
        catch (Exception ex)
        {
            FailureLabel.Visible = true;
        }
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

        ResetTimer();
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

    private void ResetTimer()
    {
        InactivityTimer.Stop();
        InactivityTimer.Start();
    }

    private void DecryptForm_MouseDown(object sender, MouseEventArgs e)
    {
        ResetTimer();
    }

    private void DecryptForm_MouseMove(object sender, MouseEventArgs e)
    {
        ResetTimer();
    }
}
