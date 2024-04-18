namespace WinFormsUI.Forms
{
    partial class SignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignForm));
            MenuStrip = new MenuStrip();
            CloseMenuItem = new ToolStripMenuItem();
            SignToolStripMenuItem = new ToolStripMenuItem();
            KeyPairComboBox = new ComboBox();
            KeyPairLabel = new Label();
            EnterButton = new Button();
            EyeballLabel = new Label();
            PasswordMaskedTextBox = new MaskedTextBox();
            PasswordLabel = new Label();
            InactivityTimer = new System.Windows.Forms.Timer(components);
            FailureLabel = new Label();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.FromArgb(32, 32, 32);
            MenuStrip.Font = new Font("Segoe UI Emoji", 10F);
            MenuStrip.Items.AddRange(new ToolStripItem[] { CloseMenuItem, SignToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(541, 29);
            MenuStrip.TabIndex = 35;
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
            // SignToolStripMenuItem
            // 
            SignToolStripMenuItem.Enabled = false;
            SignToolStripMenuItem.ForeColor = SystemColors.AppWorkspace;
            SignToolStripMenuItem.Name = "SignToolStripMenuItem";
            SignToolStripMenuItem.Size = new Size(47, 25);
            SignToolStripMenuItem.Text = "Sign";
            // 
            // KeyPairComboBox
            // 
            KeyPairComboBox.BackColor = Color.FromArgb(52, 52, 52);
            KeyPairComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            KeyPairComboBox.ForeColor = SystemColors.ButtonFace;
            KeyPairComboBox.FormattingEnabled = true;
            KeyPairComboBox.Location = new Point(145, 84);
            KeyPairComboBox.Name = "KeyPairComboBox";
            KeyPairComboBox.Size = new Size(277, 29);
            KeyPairComboBox.TabIndex = 37;
            // 
            // KeyPairLabel
            // 
            KeyPairLabel.AutoSize = true;
            KeyPairLabel.Font = new Font("Segoe UI Emoji", 12F);
            KeyPairLabel.ForeColor = SystemColors.ButtonFace;
            KeyPairLabel.Location = new Point(70, 87);
            KeyPairLabel.Name = "KeyPairLabel";
            KeyPairLabel.Size = new Size(69, 21);
            KeyPairLabel.TabIndex = 36;
            KeyPairLabel.Text = "Key Pair:";
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.Silver;
            EnterButton.Enabled = false;
            EnterButton.FlatStyle = FlatStyle.Flat;
            EnterButton.Font = new Font("Segoe UI Emoji", 12F);
            EnterButton.ForeColor = SystemColors.ButtonFace;
            EnterButton.Location = new Point(428, 79);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(34, 37);
            EnterButton.TabIndex = 38;
            EnterButton.Text = "→\n";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // EyeballLabel
            // 
            EyeballLabel.AutoSize = true;
            EyeballLabel.BackColor = Color.FromArgb(52, 52, 52);
            EyeballLabel.Font = new Font("Segoe UI Emoji", 12F);
            EyeballLabel.ForeColor = SystemColors.ButtonFace;
            EyeballLabel.Location = new Point(388, 52);
            EyeballLabel.Name = "EyeballLabel";
            EyeballLabel.Size = new Size(32, 21);
            EyeballLabel.TabIndex = 41;
            EyeballLabel.Text = "👁";
            EyeballLabel.Click += EyeballLabel_Click;
            // 
            // PasswordMaskedTextBox
            // 
            PasswordMaskedTextBox.BackColor = Color.FromArgb(52, 52, 52);
            PasswordMaskedTextBox.Font = new Font("Segoe UI Emoji", 12F);
            PasswordMaskedTextBox.ForeColor = SystemColors.ButtonFace;
            PasswordMaskedTextBox.Location = new Point(145, 49);
            PasswordMaskedTextBox.Name = "PasswordMaskedTextBox";
            PasswordMaskedTextBox.Size = new Size(277, 29);
            PasswordMaskedTextBox.TabIndex = 39;
            PasswordMaskedTextBox.UseSystemPasswordChar = true;
            PasswordMaskedTextBox.TextChanged += PasswordMaskedTextBox_TextChanged;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI Emoji", 12F);
            PasswordLabel.ForeColor = SystemColors.ButtonFace;
            PasswordLabel.Location = new Point(57, 52);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(80, 21);
            PasswordLabel.TabIndex = 40;
            PasswordLabel.Text = "Password:";
            // 
            // InactivityTimer
            // 
            InactivityTimer.Enabled = true;
            InactivityTimer.Interval = 30000;
            // 
            // FailureLabel
            // 
            FailureLabel.AutoSize = true;
            FailureLabel.Font = new Font("Segoe UI Emoji", 10F);
            FailureLabel.ForeColor = Color.Red;
            FailureLabel.Location = new Point(221, 116);
            FailureLabel.Name = "FailureLabel";
            FailureLabel.Size = new Size(128, 19);
            FailureLabel.TabIndex = 42;
            FailureLabel.Text = "Incorrect password.";
            FailureLabel.Visible = false;
            // 
            // SignForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(541, 168);
            ControlBox = false;
            Controls.Add(FailureLabel);
            Controls.Add(EyeballLabel);
            Controls.Add(PasswordMaskedTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(EnterButton);
            Controls.Add(KeyPairComboBox);
            Controls.Add(KeyPairLabel);
            Controls.Add(MenuStrip);
            Font = new Font("Segoe UI Emoji", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "SignForm";
            StartPosition = FormStartPosition.CenterParent;
            MouseDown += SignForm_MouseDown;
            MouseMove += SignForm_MouseMove;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem CloseMenuItem;
        private ToolStripMenuItem SignToolStripMenuItem;
        private ComboBox KeyPairComboBox;
        private Label KeyPairLabel;
        private Button EnterButton;
        private Label EyeballLabel;
        private MaskedTextBox PasswordMaskedTextBox;
        private Label PasswordLabel;
        private System.Windows.Forms.Timer InactivityTimer;
        private Label FailureLabel;
    }
}