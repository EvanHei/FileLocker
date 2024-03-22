namespace WinFormsUI_2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptForm));
            ClearButton = new Button();
            PasswordWarningLabel = new Label();
            EncryptionAlgorithmComboBox = new ComboBox();
            EncryptionAlgorithmLabel = new Label();
            GenerateRandomButton = new Button();
            EyeballLabel = new Label();
            ConfirmPasswordMaskedTextBox = new MaskedTextBox();
            ConfirmPasswordLabel = new Label();
            EnterButton = new Button();
            SpecialCharacterLabel = new Label();
            LowercaseLetterLabel = new Label();
            UppercaseLetterLabel = new Label();
            DigitLabel = new Label();
            NumberOfCharactersLabel = new Label();
            PasswordMaskedTextBox = new MaskedTextBox();
            PasswordLabel = new Label();
            InactivityTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.Silver;
            ClearButton.Enabled = false;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Font = new Font("Segoe UI Emoji", 12F);
            ClearButton.ForeColor = SystemColors.ButtonFace;
            ClearButton.Location = new Point(310, 305);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(148, 37);
            ClearButton.TabIndex = 33;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // PasswordWarningLabel
            // 
            PasswordWarningLabel.AutoSize = true;
            PasswordWarningLabel.Font = new Font("Segoe UI Emoji", 10F);
            PasswordWarningLabel.ForeColor = Color.Red;
            PasswordWarningLabel.Location = new Point(184, 156);
            PasswordWarningLabel.Name = "PasswordWarningLabel";
            PasswordWarningLabel.Size = new Size(250, 19);
            PasswordWarningLabel.TabIndex = 32;
            PasswordWarningLabel.Text = "If your password is lost, so is your data.";
            PasswordWarningLabel.Visible = false;
            // 
            // EncryptionAlgorithmComboBox
            // 
            EncryptionAlgorithmComboBox.BackColor = Color.FromArgb(52, 52, 52);
            EncryptionAlgorithmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EncryptionAlgorithmComboBox.ForeColor = SystemColors.ButtonFace;
            EncryptionAlgorithmComboBox.FormattingEnabled = true;
            EncryptionAlgorithmComboBox.Location = new Point(170, 124);
            EncryptionAlgorithmComboBox.Name = "EncryptionAlgorithmComboBox";
            EncryptionAlgorithmComboBox.Size = new Size(277, 29);
            EncryptionAlgorithmComboBox.TabIndex = 31;
            EncryptionAlgorithmComboBox.SelectedIndexChanged += EncryptionAlgorithmComboBox_SelectedIndexChanged;
            EncryptionAlgorithmComboBox.Click += EncryptionAlgorithmComboBox_Click;
            // 
            // EncryptionAlgorithmLabel
            // 
            EncryptionAlgorithmLabel.AutoSize = true;
            EncryptionAlgorithmLabel.Font = new Font("Segoe UI Emoji", 12F);
            EncryptionAlgorithmLabel.ForeColor = SystemColors.ButtonFace;
            EncryptionAlgorithmLabel.Location = new Point(3, 127);
            EncryptionAlgorithmLabel.Name = "EncryptionAlgorithmLabel";
            EncryptionAlgorithmLabel.Size = new Size(161, 21);
            EncryptionAlgorithmLabel.TabIndex = 30;
            EncryptionAlgorithmLabel.Text = "Encryption Algorithm:";
            // 
            // GenerateRandomButton
            // 
            GenerateRandomButton.BackColor = SystemColors.Highlight;
            GenerateRandomButton.FlatStyle = FlatStyle.Flat;
            GenerateRandomButton.Font = new Font("Segoe UI Emoji", 12F);
            GenerateRandomButton.ForeColor = SystemColors.ButtonFace;
            GenerateRandomButton.Location = new Point(156, 305);
            GenerateRandomButton.Name = "GenerateRandomButton";
            GenerateRandomButton.Size = new Size(148, 37);
            GenerateRandomButton.TabIndex = 29;
            GenerateRandomButton.Text = "Generate Random";
            GenerateRandomButton.UseVisualStyleBackColor = false;
            GenerateRandomButton.Click += GenerateRandomButton_Click;
            // 
            // EyeballLabel
            // 
            EyeballLabel.AutoSize = true;
            EyeballLabel.BackColor = Color.FromArgb(52, 52, 52);
            EyeballLabel.Font = new Font("Segoe UI Emoji", 12F);
            EyeballLabel.ForeColor = SystemColors.ButtonFace;
            EyeballLabel.Location = new Point(413, 92);
            EyeballLabel.Name = "EyeballLabel";
            EyeballLabel.Size = new Size(32, 21);
            EyeballLabel.TabIndex = 19;
            EyeballLabel.Text = "👁";
            EyeballLabel.Click += EyeballLabel_Click;
            // 
            // ConfirmPasswordMaskedTextBox
            // 
            ConfirmPasswordMaskedTextBox.BackColor = Color.FromArgb(52, 52, 52);
            ConfirmPasswordMaskedTextBox.Font = new Font("Segoe UI Emoji", 12F);
            ConfirmPasswordMaskedTextBox.ForeColor = SystemColors.ButtonFace;
            ConfirmPasswordMaskedTextBox.Location = new Point(170, 89);
            ConfirmPasswordMaskedTextBox.Name = "ConfirmPasswordMaskedTextBox";
            ConfirmPasswordMaskedTextBox.Size = new Size(277, 29);
            ConfirmPasswordMaskedTextBox.TabIndex = 27;
            ConfirmPasswordMaskedTextBox.UseSystemPasswordChar = true;
            ConfirmPasswordMaskedTextBox.Click += ConfirmPasswordMaskedTextBox_Click;
            ConfirmPasswordMaskedTextBox.TextChanged += ConfirmPasswordMaskedTextBox_TextChanged;
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Font = new Font("Segoe UI Emoji", 12F);
            ConfirmPasswordLabel.ForeColor = SystemColors.ButtonFace;
            ConfirmPasswordLabel.Location = new Point(23, 92);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(141, 21);
            ConfirmPasswordLabel.TabIndex = 28;
            ConfirmPasswordLabel.Text = "Confirm Password:";
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.Silver;
            EnterButton.Enabled = false;
            EnterButton.FlatStyle = FlatStyle.Flat;
            EnterButton.Font = new Font("Segoe UI Emoji", 12F);
            EnterButton.ForeColor = SystemColors.ButtonFace;
            EnterButton.Location = new Point(453, 85);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(34, 37);
            EnterButton.TabIndex = 26;
            EnterButton.Text = "→\n";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // SpecialCharacterLabel
            // 
            SpecialCharacterLabel.AutoSize = true;
            SpecialCharacterLabel.Font = new Font("Segoe UI Emoji", 12F);
            SpecialCharacterLabel.ForeColor = SystemColors.AppWorkspace;
            SpecialCharacterLabel.Location = new Point(170, 268);
            SpecialCharacterLabel.Name = "SpecialCharacterLabel";
            SpecialCharacterLabel.Size = new Size(138, 21);
            SpecialCharacterLabel.TabIndex = 25;
            SpecialCharacterLabel.Text = "• Special character";
            // 
            // LowercaseLetterLabel
            // 
            LowercaseLetterLabel.AutoSize = true;
            LowercaseLetterLabel.Font = new Font("Segoe UI Emoji", 12F);
            LowercaseLetterLabel.ForeColor = SystemColors.AppWorkspace;
            LowercaseLetterLabel.Location = new Point(170, 226);
            LowercaseLetterLabel.Name = "LowercaseLetterLabel";
            LowercaseLetterLabel.Size = new Size(134, 21);
            LowercaseLetterLabel.TabIndex = 24;
            LowercaseLetterLabel.Text = "• Lowercase letter";
            // 
            // UppercaseLetterLabel
            // 
            UppercaseLetterLabel.AutoSize = true;
            UppercaseLetterLabel.Font = new Font("Segoe UI Emoji", 12F);
            UppercaseLetterLabel.ForeColor = SystemColors.AppWorkspace;
            UppercaseLetterLabel.Location = new Point(170, 205);
            UppercaseLetterLabel.Name = "UppercaseLetterLabel";
            UppercaseLetterLabel.Size = new Size(134, 21);
            UppercaseLetterLabel.TabIndex = 23;
            UppercaseLetterLabel.Text = "• Uppercase letter";
            // 
            // DigitLabel
            // 
            DigitLabel.AutoSize = true;
            DigitLabel.Font = new Font("Segoe UI Emoji", 12F);
            DigitLabel.ForeColor = SystemColors.AppWorkspace;
            DigitLabel.Location = new Point(170, 247);
            DigitLabel.Name = "DigitLabel";
            DigitLabel.Size = new Size(54, 21);
            DigitLabel.TabIndex = 22;
            DigitLabel.Text = "• Digit";
            // 
            // NumberOfCharactersLabel
            // 
            NumberOfCharactersLabel.AutoSize = true;
            NumberOfCharactersLabel.Font = new Font("Segoe UI Emoji", 12F);
            NumberOfCharactersLabel.ForeColor = SystemColors.AppWorkspace;
            NumberOfCharactersLabel.Location = new Point(170, 184);
            NumberOfCharactersLabel.Name = "NumberOfCharactersLabel";
            NumberOfCharactersLabel.Size = new Size(158, 21);
            NumberOfCharactersLabel.TabIndex = 21;
            NumberOfCharactersLabel.Text = "• <range> characters";
            // 
            // PasswordMaskedTextBox
            // 
            PasswordMaskedTextBox.BackColor = Color.FromArgb(52, 52, 52);
            PasswordMaskedTextBox.Font = new Font("Segoe UI Emoji", 12F);
            PasswordMaskedTextBox.ForeColor = SystemColors.ButtonFace;
            PasswordMaskedTextBox.Location = new Point(170, 56);
            PasswordMaskedTextBox.Name = "PasswordMaskedTextBox";
            PasswordMaskedTextBox.Size = new Size(277, 29);
            PasswordMaskedTextBox.TabIndex = 18;
            PasswordMaskedTextBox.UseSystemPasswordChar = true;
            PasswordMaskedTextBox.Click += PasswordMaskedTextBox_Click;
            PasswordMaskedTextBox.TextChanged += PasswordMaskedTextBox_TextChanged;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI Emoji", 12F);
            PasswordLabel.ForeColor = SystemColors.ButtonFace;
            PasswordLabel.Location = new Point(82, 59);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(80, 21);
            PasswordLabel.TabIndex = 20;
            PasswordLabel.Text = "Password:";
            // 
            // InactivityTimer
            // 
            InactivityTimer.Enabled = true;
            InactivityTimer.Interval = 30000;
            InactivityTimer.Tick += InactivityTimer_Tick;
            // 
            // EncryptForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(541, 367);
            Controls.Add(ClearButton);
            Controls.Add(PasswordWarningLabel);
            Controls.Add(EncryptionAlgorithmComboBox);
            Controls.Add(EncryptionAlgorithmLabel);
            Controls.Add(GenerateRandomButton);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "EncryptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Encrypt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Label PasswordWarningLabel;
        private ComboBox EncryptionAlgorithmComboBox;
        private Label EncryptionAlgorithmLabel;
        private Button GenerateRandomButton;
        private Label EyeballLabel;
        private MaskedTextBox ConfirmPasswordMaskedTextBox;
        private Label ConfirmPasswordLabel;
        private Button EnterButton;
        private Label SpecialCharacterLabel;
        private Label LowercaseLetterLabel;
        private Label UppercaseLetterLabel;
        private Label DigitLabel;
        private Label NumberOfCharactersLabel;
        private MaskedTextBox PasswordMaskedTextBox;
        private Label PasswordLabel;
        private System.Windows.Forms.Timer InactivityTimer;
    }
}