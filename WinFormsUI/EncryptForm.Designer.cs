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
            EightCharacterLabel = new Label();
            DigitLabel = new Label();
            LowercaseLetterLabel = new Label();
            UppercaseLetterLabel = new Label();
            SpecialCharacterLabel = new Label();
            EyeballLabel = new Label();
            SuspendLayout();
            // 
            // PasswordMaskedTextBox
            // 
            PasswordMaskedTextBox.BackColor = Color.FromArgb(52, 52, 52);
            PasswordMaskedTextBox.ForeColor = SystemColors.ButtonFace;
            PasswordMaskedTextBox.Location = new Point(122, 61);
            PasswordMaskedTextBox.Name = "PasswordMaskedTextBox";
            PasswordMaskedTextBox.Size = new Size(277, 26);
            PasswordMaskedTextBox.TabIndex = 1;
            PasswordMaskedTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.ForeColor = SystemColors.ButtonFace;
            PasswordLabel.Location = new Point(34, 64);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(82, 20);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password:";
            // 
            // EightCharacterLabel
            // 
            EightCharacterLabel.AutoSize = true;
            EightCharacterLabel.ForeColor = SystemColors.AppWorkspace;
            EightCharacterLabel.Location = new Point(122, 99);
            EightCharacterLabel.Name = "EightCharacterLabel";
            EightCharacterLabel.Size = new Size(97, 20);
            EightCharacterLabel.TabIndex = 5;
            EightCharacterLabel.Text = "8 characters";
            // 
            // DigitLabel
            // 
            DigitLabel.AutoSize = true;
            DigitLabel.ForeColor = SystemColors.AppWorkspace;
            DigitLabel.Location = new Point(122, 119);
            DigitLabel.Name = "DigitLabel";
            DigitLabel.Size = new Size(41, 20);
            DigitLabel.TabIndex = 6;
            DigitLabel.Text = "Digit";
            // 
            // LowercaseLetterLabel
            // 
            LowercaseLetterLabel.AutoSize = true;
            LowercaseLetterLabel.ForeColor = SystemColors.AppWorkspace;
            LowercaseLetterLabel.Location = new Point(122, 159);
            LowercaseLetterLabel.Name = "LowercaseLetterLabel";
            LowercaseLetterLabel.Size = new Size(126, 20);
            LowercaseLetterLabel.TabIndex = 8;
            LowercaseLetterLabel.Text = "Lowercase letter";
            // 
            // UppercaseLetterLabel
            // 
            UppercaseLetterLabel.AutoSize = true;
            UppercaseLetterLabel.ForeColor = SystemColors.AppWorkspace;
            UppercaseLetterLabel.Location = new Point(122, 139);
            UppercaseLetterLabel.Name = "UppercaseLetterLabel";
            UppercaseLetterLabel.Size = new Size(127, 20);
            UppercaseLetterLabel.TabIndex = 7;
            UppercaseLetterLabel.Text = "Uppercase letter";
            // 
            // SpecialCharacterLabel
            // 
            SpecialCharacterLabel.AutoSize = true;
            SpecialCharacterLabel.ForeColor = SystemColors.AppWorkspace;
            SpecialCharacterLabel.Location = new Point(122, 179);
            SpecialCharacterLabel.Name = "SpecialCharacterLabel";
            SpecialCharacterLabel.Size = new Size(132, 20);
            SpecialCharacterLabel.TabIndex = 9;
            SpecialCharacterLabel.Text = "Special character";
            // 
            // EyeballLabel
            // 
            EyeballLabel.AutoSize = true;
            EyeballLabel.ForeColor = SystemColors.ButtonFace;
            EyeballLabel.Location = new Point(405, 64);
            EyeballLabel.Name = "EyeballLabel";
            EyeballLabel.Size = new Size(25, 20);
            EyeballLabel.TabIndex = 2;
            EyeballLabel.Text = "👁";
            // 
            // EncryptForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(470, 227);
            Controls.Add(EyeballLabel);
            Controls.Add(SpecialCharacterLabel);
            Controls.Add(LowercaseLetterLabel);
            Controls.Add(UppercaseLetterLabel);
            Controls.Add(DigitLabel);
            Controls.Add(EightCharacterLabel);
            Controls.Add(PasswordMaskedTextBox);
            Controls.Add(PasswordLabel);
            Font = new Font("Microsoft Sans Serif", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "EncryptForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FileLocker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox PasswordMaskedTextBox;
        private Label PasswordLabel;
        private Label EightCharacterLabel;
        private Label DigitLabel;
        private Label LowercaseLetterLabel;
        private Label UppercaseLetterLabel;
        private Label SpecialCharacterLabel;
        private Label EyeballLabel;
    }
}