namespace WinFormsUI
{
    partial class EncryptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptForm));
            PasswordMaskedTextBox = new MaskedTextBox();
            PasswordLabel = new Label();
            NumberOfCharactersLabel = new Label();
            DigitLabel = new Label();
            LowercaseLetterLabel = new Label();
            UppercaseLetterLabel = new Label();
            SpecialCharacterLabel = new Label();
            EyeballLabel = new Label();
            EnterButton = new Button();
            ConfirmPasswordMaskedTextBox = new MaskedTextBox();
            ConfirmPasswordLabel = new Label();
            SuspendLayout();
            // 
            // PasswordMaskedTextBox
            // 
            PasswordMaskedTextBox.BackColor = Color.FromArgb(52, 52, 52);
            PasswordMaskedTextBox.Font = new Font("Segoe UI Emoji", 12F);
            PasswordMaskedTextBox.ForeColor = SystemColors.ButtonFace;
            PasswordMaskedTextBox.Location = new Point(171, 57);
            PasswordMaskedTextBox.Name = "PasswordMaskedTextBox";
            PasswordMaskedTextBox.Size = new Size(277, 29);
            PasswordMaskedTextBox.TabIndex = 1;
            PasswordMaskedTextBox.UseSystemPasswordChar = true;
            PasswordMaskedTextBox.TextChanged += PasswordMaskedTextBox_TextChanged;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI Emoji", 12F);
            PasswordLabel.ForeColor = SystemColors.ButtonFace;
            PasswordLabel.Location = new Point(83, 60);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(80, 21);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password:";
            // 
            // NumberOfCharactersLabel
            // 
            NumberOfCharactersLabel.AutoSize = true;
            NumberOfCharactersLabel.Font = new Font("Segoe UI Emoji", 12F);
            NumberOfCharactersLabel.ForeColor = SystemColors.AppWorkspace;
            NumberOfCharactersLabel.Location = new Point(171, 138);
            NumberOfCharactersLabel.Name = "NumberOfCharactersLabel";
            NumberOfCharactersLabel.Size = new Size(137, 21);
            NumberOfCharactersLabel.TabIndex = 5;
            NumberOfCharactersLabel.Text = "• 8 - 20 characters";
            // 
            // DigitLabel
            // 
            DigitLabel.AutoSize = true;
            DigitLabel.Font = new Font("Segoe UI Emoji", 12F);
            DigitLabel.ForeColor = SystemColors.AppWorkspace;
            DigitLabel.Location = new Point(171, 201);
            DigitLabel.Name = "DigitLabel";
            DigitLabel.Size = new Size(54, 21);
            DigitLabel.TabIndex = 6;
            DigitLabel.Text = "• Digit";
            // 
            // LowercaseLetterLabel
            // 
            LowercaseLetterLabel.AutoSize = true;
            LowercaseLetterLabel.Font = new Font("Segoe UI Emoji", 12F);
            LowercaseLetterLabel.ForeColor = SystemColors.AppWorkspace;
            LowercaseLetterLabel.Location = new Point(171, 180);
            LowercaseLetterLabel.Name = "LowercaseLetterLabel";
            LowercaseLetterLabel.Size = new Size(134, 21);
            LowercaseLetterLabel.TabIndex = 8;
            LowercaseLetterLabel.Text = "• Lowercase letter";
            // 
            // UppercaseLetterLabel
            // 
            UppercaseLetterLabel.AutoSize = true;
            UppercaseLetterLabel.Font = new Font("Segoe UI Emoji", 12F);
            UppercaseLetterLabel.ForeColor = SystemColors.AppWorkspace;
            UppercaseLetterLabel.Location = new Point(171, 159);
            UppercaseLetterLabel.Name = "UppercaseLetterLabel";
            UppercaseLetterLabel.Size = new Size(134, 21);
            UppercaseLetterLabel.TabIndex = 7;
            UppercaseLetterLabel.Text = "• Uppercase letter";
            // 
            // SpecialCharacterLabel
            // 
            SpecialCharacterLabel.AutoSize = true;
            SpecialCharacterLabel.Font = new Font("Segoe UI Emoji", 12F);
            SpecialCharacterLabel.ForeColor = SystemColors.AppWorkspace;
            SpecialCharacterLabel.Location = new Point(171, 222);
            SpecialCharacterLabel.Name = "SpecialCharacterLabel";
            SpecialCharacterLabel.Size = new Size(138, 21);
            SpecialCharacterLabel.TabIndex = 9;
            SpecialCharacterLabel.Text = "• Special character";
            // 
            // EyeballLabel
            // 
            EyeballLabel.AutoSize = true;
            EyeballLabel.BackColor = Color.FromArgb(52, 52, 52);
            EyeballLabel.Font = new Font("Segoe UI Emoji", 12F);
            EyeballLabel.ForeColor = SystemColors.ButtonFace;
            EyeballLabel.Location = new Point(414, 93);
            EyeballLabel.Name = "EyeballLabel";
            EyeballLabel.Size = new Size(32, 21);
            EyeballLabel.TabIndex = 2;
            EyeballLabel.Text = "👁";
            EyeballLabel.Click += EyeballLabel_Click;
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.Silver;
            EnterButton.Enabled = false;
            EnterButton.Font = new Font("Segoe UI Emoji", 12F);
            EnterButton.ForeColor = SystemColors.ButtonFace;
            EnterButton.Location = new Point(454, 86);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(34, 37);
            EnterButton.TabIndex = 10;
            EnterButton.Text = "→\n";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // ConfirmPasswordMaskedTextBox
            // 
            ConfirmPasswordMaskedTextBox.BackColor = Color.FromArgb(52, 52, 52);
            ConfirmPasswordMaskedTextBox.Font = new Font("Segoe UI Emoji", 12F);
            ConfirmPasswordMaskedTextBox.ForeColor = SystemColors.ButtonFace;
            ConfirmPasswordMaskedTextBox.Location = new Point(171, 90);
            ConfirmPasswordMaskedTextBox.Name = "ConfirmPasswordMaskedTextBox";
            ConfirmPasswordMaskedTextBox.Size = new Size(277, 29);
            ConfirmPasswordMaskedTextBox.TabIndex = 11;
            ConfirmPasswordMaskedTextBox.UseSystemPasswordChar = true;
            ConfirmPasswordMaskedTextBox.TextChanged += ConfirmPasswordMaskedTextBox_TextChanged;
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Font = new Font("Segoe UI Emoji", 12F);
            ConfirmPasswordLabel.ForeColor = SystemColors.ButtonFace;
            ConfirmPasswordLabel.Location = new Point(24, 93);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(141, 21);
            ConfirmPasswordLabel.TabIndex = 12;
            ConfirmPasswordLabel.Text = "Confirm Password:";
            // 
            // EncryptForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(541, 278);
            Controls.Add(EyeballLabel);
            Controls.Add(ConfirmPasswordMaskedTextBox);
            Controls.Add(ConfirmPasswordLabel);
            Controls.Add(EnterButton);
            Controls.Add(SpecialCharacterLabel);
            Controls.Add(LowercaseLetterLabel);
            Controls.Add(UppercaseLetterLabel);
            Controls.Add(DigitLabel);
            Controls.Add(NumberOfCharactersLabel);
            Controls.Add(PasswordMaskedTextBox);
            Controls.Add(PasswordLabel);
            Font = new Font("Segoe UI Emoji", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "EncryptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Encrypt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox PasswordMaskedTextBox;
        private Label PasswordLabel;
        private Label NumberOfCharactersLabel;
        private Label DigitLabel;
        private Label LowercaseLetterLabel;
        private Label UppercaseLetterLabel;
        private Label SpecialCharacterLabel;
        private Label EyeballLabel;
        private Button EnterButton;
        private MaskedTextBox ConfirmPasswordMaskedTextBox;
        private Label ConfirmPasswordLabel;
    }
}