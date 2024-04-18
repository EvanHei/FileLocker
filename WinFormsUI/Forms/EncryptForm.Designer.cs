namespace WinFormsUI.Forms
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
            AlgorithmLabel = new Label();
            GenerateRandomButton = new Button();
            EyeballLabel = new Label();
            ConfirmPasswordMaskedTextBox = new MaskedTextBox();
            ConfirmLabel = new Label();
            EnterButton = new Button();
            SpecialCharacterLabel = new Label();
            LowercaseLetterLabel = new Label();
            UppercaseLetterLabel = new Label();
            DigitLabel = new Label();
            NumberOfCharactersLabel = new Label();
            PasswordMaskedTextBox = new MaskedTextBox();
            PasswordLabel = new Label();
            InactivityTimer = new System.Windows.Forms.Timer(components);
            MenuStrip = new MenuStrip();
            CloseMenuItem = new ToolStripMenuItem();
            EncryptToolStripMenuItem = new ToolStripMenuItem();
            MenuStrip.SuspendLayout();
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
            EncryptionAlgorithmComboBox.Click += Control_Click;
            // 
            // AlgorithmLabel
            // 
            AlgorithmLabel.AutoSize = true;
            AlgorithmLabel.Font = new Font("Segoe UI Emoji", 12F);
            AlgorithmLabel.ForeColor = SystemColors.ButtonFace;
            AlgorithmLabel.Location = new Point(79, 127);
            AlgorithmLabel.Name = "AlgorithmLabel";
            AlgorithmLabel.Size = new Size(83, 21);
            AlgorithmLabel.TabIndex = 30;
            AlgorithmLabel.Text = "Algorithm:";
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
            ConfirmPasswordMaskedTextBox.Click += Control_Click;
            ConfirmPasswordMaskedTextBox.TextChanged += ConfirmPasswordMaskedTextBox_TextChanged;
            // 
            // ConfirmLabel
            // 
            ConfirmLabel.AutoSize = true;
            ConfirmLabel.Font = new Font("Segoe UI Emoji", 12F);
            ConfirmLabel.ForeColor = SystemColors.ButtonFace;
            ConfirmLabel.Location = new Point(92, 92);
            ConfirmLabel.Name = "ConfirmLabel";
            ConfirmLabel.Size = new Size(70, 21);
            ConfirmLabel.TabIndex = 28;
            ConfirmLabel.Text = "Confirm:";
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
            PasswordMaskedTextBox.Click += Control_Click;
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
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.FromArgb(32, 32, 32);
            MenuStrip.Font = new Font("Segoe UI Emoji", 10F);
            MenuStrip.Items.AddRange(new ToolStripItem[] { CloseMenuItem, EncryptToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(541, 29);
            MenuStrip.TabIndex = 34;
            MenuStrip.Text = "menuStrip1";
            // 
            // CloseMenuItem
            // 
            CloseMenuItem.Alignment = ToolStripItemAlignment.Right;
            CloseMenuItem.Font = new Font("Segoe UI Emoji", 10F);
            CloseMenuItem.ForeColor = SystemColors.AppWorkspace;
            CloseMenuItem.Margin = new Padding(0, 2, 0, 0);
            CloseMenuItem.Name = "CloseMenuItem";
            CloseMenuItem.Size = new Size(40, 23);
            CloseMenuItem.Text = "❌";
            CloseMenuItem.Click += CloseMenuItem_Click;
            // 
            // EncryptToolStripMenuItem
            // 
            EncryptToolStripMenuItem.Enabled = false;
            EncryptToolStripMenuItem.ForeColor = SystemColors.AppWorkspace;
            EncryptToolStripMenuItem.Name = "EncryptToolStripMenuItem";
            EncryptToolStripMenuItem.Size = new Size(67, 25);
            EncryptToolStripMenuItem.Text = "Encrypt";
            // 
            // EncryptForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(541, 367);
            ControlBox = false;
            Controls.Add(MenuStrip);
            Controls.Add(ClearButton);
            Controls.Add(PasswordWarningLabel);
            Controls.Add(EncryptionAlgorithmComboBox);
            Controls.Add(AlgorithmLabel);
            Controls.Add(GenerateRandomButton);
            Controls.Add(EyeballLabel);
            Controls.Add(ConfirmPasswordMaskedTextBox);
            Controls.Add(ConfirmLabel);
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
            MouseDown += EncryptForm_MouseDown;
            MouseMove += EncryptForm_MouseMove;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClearButton;
        private Label PasswordWarningLabel;
        private ComboBox EncryptionAlgorithmComboBox;
        private Label AlgorithmLabel;
        private Button GenerateRandomButton;
        private Label EyeballLabel;
        private MaskedTextBox ConfirmPasswordMaskedTextBox;
        private Label ConfirmLabel;
        private Button EnterButton;
        private Label SpecialCharacterLabel;
        private Label LowercaseLetterLabel;
        private Label UppercaseLetterLabel;
        private Label DigitLabel;
        private Label NumberOfCharactersLabel;
        private MaskedTextBox PasswordMaskedTextBox;
        private Label PasswordLabel;
        private System.Windows.Forms.Timer InactivityTimer;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem CloseMenuItem;
        private ToolStripMenuItem EncryptToolStripMenuItem;
    }
}