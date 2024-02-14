using FileLockerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;

namespace WinFormsUI;

public partial class EncryptForm : Form
{
    private IEncryptFormCaller caller;
    private FileModel model;
    private bool isEyeballLabelClicked = false;

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
        string password = PasswordMaskedTextBox.Text;
        string confirmPassword = ConfirmPasswordMaskedTextBox.Text;

        if (password.Length < 8 || password.Length > 20)
            output = false;
        if (!password.Any(char.IsUpper))
            output = false;
        if (!password.Any(char.IsLower))
            output = false;
        if (!password.Any(char.IsDigit))
            output = false;
        if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            output = false;
        if (password != confirmPassword)
            output = false;

        return output;
    }

    private void EyeballLabel_Click(object sender, EventArgs e)
    {
        // toggle off
        if (isEyeballLabelClicked)
        {
            PasswordMaskedTextBox.UseSystemPasswordChar = true;
            ConfirmPasswordMaskedTextBox.UseSystemPasswordChar = true;
            EyeballLabel.ForeColor = SystemColors.ButtonFace;

            isEyeballLabelClicked = false;
        }
        // toggle on
        else
        {
            PasswordMaskedTextBox.UseSystemPasswordChar = false;
            ConfirmPasswordMaskedTextBox.UseSystemPasswordChar = false;
            EyeballLabel.ForeColor = SystemColors.Highlight;

            isEyeballLabelClicked = true;
        }
    }

    private void PasswordMaskedTextBox_TextChanged(object sender, EventArgs e)
    {
        string password = PasswordMaskedTextBox.Text;
        string confirmPassword = ConfirmPasswordMaskedTextBox.Text;

        // NumberOfCharactersLabel
        if (password.Length >= 8 && password.Length <= 20)
        {
            if (NumberOfCharactersLabel.Text.Contains('•'))
            {
                NumberOfCharactersLabel.Text = '✓' + NumberOfCharactersLabel.Text.Substring(1);
                NumberOfCharactersLabel.ForeColor = Color.Green;
            }
        }
        else if (NumberOfCharactersLabel.Text[0] == '✓')
        {
            NumberOfCharactersLabel.Text = '•' + NumberOfCharactersLabel.Text.Substring(1);
            NumberOfCharactersLabel.ForeColor = SystemColors.AppWorkspace;
        }

        // UppercaseLetterLabel
        if (password.Any(char.IsUpper))
        {
            if (UppercaseLetterLabel.Text.Contains('•'))
            {
                UppercaseLetterLabel.Text = '✓' + UppercaseLetterLabel.Text.Substring(1);
                UppercaseLetterLabel.ForeColor = Color.Green;
            }
        }
        else if (UppercaseLetterLabel.Text[0] == '✓')
        {
            UppercaseLetterLabel.Text = '•' + UppercaseLetterLabel.Text.Substring(1);
            UppercaseLetterLabel.ForeColor = SystemColors.AppWorkspace;
        }

        // LowercaseLetterLabel
        if (password.Any(char.IsLower))
        {
            if (LowercaseLetterLabel.Text.Contains('•'))
            {
                LowercaseLetterLabel.Text = '✓' + LowercaseLetterLabel.Text.Substring(1);
                LowercaseLetterLabel.ForeColor = Color.Green;
            }
        }
        else if (LowercaseLetterLabel.Text[0] == '✓')
        {
            LowercaseLetterLabel.Text = '•' + LowercaseLetterLabel.Text.Substring(1);
            LowercaseLetterLabel.ForeColor = SystemColors.AppWorkspace;
        }

        // DigitLabel
        if (password.Any(char.IsDigit))
        {
            if (DigitLabel.Text.Contains('•'))
            {
                DigitLabel.Text = '✓' + DigitLabel.Text.Substring(1);
                DigitLabel.ForeColor = Color.Green;
            }
        }
        else if (DigitLabel.Text[0] == '✓')
        {
            DigitLabel.Text = '•' + DigitLabel.Text.Substring(1);
            DigitLabel.ForeColor = SystemColors.AppWorkspace;
        }

        // SpecialCharacterLabel
        if (password.Any(ch => !char.IsLetterOrDigit(ch)))
        {
            if (SpecialCharacterLabel.Text.Contains('•'))
            {
                SpecialCharacterLabel.Text = '✓' + SpecialCharacterLabel.Text.Substring(1);
                SpecialCharacterLabel.ForeColor = Color.Green;
            }
        }
        else if (SpecialCharacterLabel.Text[0] == '✓')
        {
            SpecialCharacterLabel.Text = '•' + SpecialCharacterLabel.Text.Substring(1);
            SpecialCharacterLabel.ForeColor = SystemColors.AppWorkspace;
        }

        if (ValidateInputFields())
        {
            EnterButton.BackColor = Color.FromArgb(52, 52, 52);
            EnterButton.Enabled = true;
        }
        else
        {
            EnterButton.BackColor = Color.Silver;
            EnterButton.Enabled = false;
        }
    }

    private void ConfirmPasswordMaskedTextBox_TextChanged(object sender, EventArgs e)
    {
        if (ValidateInputFields())
        {
            EnterButton.BackColor = Color.FromArgb(52, 52, 52);
            EnterButton.Enabled = true;
        }
        else
        {
            EnterButton.BackColor = Color.Silver;
            EnterButton.Enabled = false;
        }
    }
}
