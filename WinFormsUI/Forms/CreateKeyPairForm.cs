﻿using FileLockerLibrary;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI;

public partial class CreateKeyPairForm : Form
{
    private ICreateKeyPairFormCaller caller;
    private bool isEyeballLabelClicked = false;

    public CreateKeyPairForm(ICreateKeyPairFormCaller caller)
    {
        InitializeComponent();

        NumberOfCharactersLabel.Text = $"• {Constants.MinPasswordLength} - {Constants.MaxPasswordLength} characters";
        SigningAlgorithmComboBox.DataSource = Enum.GetNames(typeof(DigSigAlgorithm));

        this.caller = caller;
    }

    private void EnterButton_Click(object sender, EventArgs e)
    {
        if (!ValidateInputFields())
            return;

        try
        {
            Enum.TryParse(SigningAlgorithmComboBox.SelectedItem.ToString(), out DigSigAlgorithm algorithm);

            KeyPairModel model = GlobalConfig.Signer(algorithm).GenerateKeyPair();
            model.Name = NameMaskedTextBox.Text;

            string password = PasswordMaskedTextBox.Text;
            GlobalConfig.DataAccessor.CreateKeyPairModel(model, password);

            this.Close();
            caller.KeyPairCreationComplete();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
        }
    }

    private void GenerateRandomButton_Click(object sender, EventArgs e)
    {
        string password = GenerateRandomPassword();
        PasswordMaskedTextBox.Text = password;
        ConfirmPasswordMaskedTextBox.Text = password;

        if (!isEyeballLabelClicked)
            EyeballLabel_Click(null, null);

        ResetTimer();
    }

    static string GenerateRandomPassword()
    {
        const string lowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
        const string upperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string digits = "0123456789";
        const string specialChars = " !@#$%^&*()_+-=[]{}|;:,.<>?";
        string validChars = lowerCaseChars + upperCaseChars + digits + specialChars;
        Random rng = new();

        // generate password length within the specified range
        int length = rng.Next(Constants.MinPasswordLength, Constants.MaxPasswordLength + 1);

        // choose characters
        char[] passwordChars = new char[length];
        for (int i = 0; i < length; i++)
        {
            int index = rng.Next(0, validChars.Length);
            passwordChars[i] = validChars[index];
        }

        // check password validity
        if (!passwordChars.Any(char.IsUpper))
            passwordChars[rng.Next(0, length)] = upperCaseChars[rng.Next(0, upperCaseChars.Length)];

        if (!passwordChars.Any(char.IsLower))
            passwordChars[rng.Next(0, length)] = lowerCaseChars[rng.Next(0, lowerCaseChars.Length)];

        if (!passwordChars.Any(char.IsDigit))
            passwordChars[rng.Next(0, length)] = digits[rng.Next(0, digits.Length)];

        if (!passwordChars.Any(ch => specialChars.Contains(ch)))
            passwordChars[rng.Next(0, length)] = specialChars[rng.Next(0, specialChars.Length)];

        // shuffle the characters
        for (int i = length - 1; i > 0; i--)
        {
            int swapIndex = rng.Next(0, i + 1);
            char temp = passwordChars[i];
            passwordChars[i] = passwordChars[swapIndex];
            passwordChars[swapIndex] = temp;
        }

        return new string(passwordChars);
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        ClearPasswords();
        ResetTimer();
    }

    private void ClearPasswords()
    {
        PasswordMaskedTextBox.Text = "";
        ConfirmPasswordMaskedTextBox.Text = "";
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

        ResetTimer();
    }

    private void InactivityTimer_Tick(object sender, EventArgs e)
    {
        ClearPasswords();
    }

    private void UpdateControls()
    {
        if (ValidateInputFields())
        {
            EnableEnterButton();
            PasswordWarningLabel.Visible = true;
        }
        else
        {
            DisableEnterButton();
            PasswordWarningLabel.Visible = false;
        }

        if (PasswordMaskedTextBox.Text.Length > 0 ||
            ConfirmPasswordMaskedTextBox.Text.Length > 0)
            EnableClearButton();
        else
            DisableClearButton();
    }

    private bool ValidateInputFields()
    {
        bool output = true;
        string password = PasswordMaskedTextBox.Text;
        string confirmPassword = ConfirmPasswordMaskedTextBox.Text;
        string name = NameMaskedTextBox.Text;

        if (password.Length < Constants.MinPasswordLength || password.Length > Constants.MaxPasswordLength)
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
        if (SigningAlgorithmComboBox.SelectedItem == null ||
            !Enum.TryParse(SigningAlgorithmComboBox.SelectedItem.ToString(), out DigSigAlgorithm algorithm))
            output = false;

        // name must be alphanumeric
        string alphanumericPattern = @"^[A-Za-z0-9]+$";
        if (!Regex.IsMatch(name, alphanumericPattern))
            output = false;

        return output;
    }

    private void EnableClearButton()
    {
        ClearButton.Enabled = true;
        ClearButton.BackColor = SystemColors.Highlight;
    }

    private void DisableClearButton()
    {
        ClearButton.Enabled = false;
        ClearButton.BackColor = Color.Silver;
    }

    private void EnableEnterButton()
    {
        EnterButton.BackColor = SystemColors.Highlight;
        EnterButton.Enabled = true;
    }

    private void DisableEnterButton()
    {
        EnterButton.BackColor = Color.Silver;
        EnterButton.Enabled = false;
    }

    private void ResetTimer()
    {
        InactivityTimer.Stop();
        InactivityTimer.Start();
    }

    private void CreateKeyPairForm_MouseDown(object sender, MouseEventArgs e)
    {
        ResetTimer();
    }

    private void CreateKeyPairForm_MouseMove(object sender, MouseEventArgs e)
    {
        ResetTimer();
    }

    private void Control_Click(object sender, EventArgs e)
    {
        ResetTimer();
    }

    private void PasswordMaskedTextBox_TextChanged(object sender, EventArgs e)
    {
        string password = PasswordMaskedTextBox.Text;
        string confirmPassword = ConfirmPasswordMaskedTextBox.Text;

        // NumberOfCharactersLabel
        if (password.Length >= Constants.MinPasswordLength && password.Length <= Constants.MaxPasswordLength)
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

        UpdateControls();
        ResetTimer();
    }

    private void ConfirmPasswordMaskedTextBox_TextChanged(object sender, EventArgs e)
    {
        UpdateControls();
        ResetTimer();
    }

    private void SigningAlgorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateControls();
        ResetTimer();
    }

    private void CloseMenuItem_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void NameMaskedTextBox_TextChanged(object sender, EventArgs e)
    {
        string name = NameMaskedTextBox.Text;
        string alphanumericPattern = @"^[A-Za-z0-9]+$";

        // AlphanumericLabel
        if (name.Length > 0 && Regex.IsMatch(name, alphanumericPattern))
        {
            if (AlphanumericLabel.Text.Contains('•'))
            {
                AlphanumericLabel.Text = '✓' + AlphanumericLabel.Text.Substring(1);
                AlphanumericLabel.ForeColor = Color.Green;
            }
        }
        else if (AlphanumericLabel.Text[0] == '✓')
        {
            AlphanumericLabel.Text = '•' + AlphanumericLabel.Text.Substring(1);
            AlphanumericLabel.ForeColor = SystemColors.AppWorkspace;
        }

        UpdateControls();
        ResetTimer();
    }
}