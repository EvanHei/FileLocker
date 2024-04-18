namespace WinFormsUI.Forms
{
    partial class DecryptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecryptForm));
            FailureLabel = new Label();
            EnterButton = new Button();
            EyeballLabel = new Label();
            PasswordMaskedTextBox = new MaskedTextBox();
            PasswordLabel = new Label();
            InactivityTimer = new System.Windows.Forms.Timer(components);
            MenuStrip = new MenuStrip();
            CloseMenuItem = new ToolStripMenuItem();
            DecryptToolStripMenuItem = new ToolStripMenuItem();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // FailureLabel
            // 
            FailureLabel.AutoSize = true;
            FailureLabel.Font = new Font("Segoe UI Emoji", 10F);
            FailureLabel.ForeColor = Color.Red;
            FailureLabel.Location = new Point(81, 101);
            FailureLabel.Name = "FailureLabel";
            FailureLabel.Size = new Size(359, 19);
            FailureLabel.TabIndex = 22;
            FailureLabel.Text = "If the password was correct, the data has been tampered.";
            FailureLabel.Visible = false;
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.Silver;
            EnterButton.Enabled = false;
            EnterButton.FlatStyle = FlatStyle.Flat;
            EnterButton.Font = new Font("Segoe UI Emoji", 12F);
            EnterButton.ForeColor = SystemColors.ButtonFace;
            EnterButton.Location = new Point(405, 61);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(34, 37);
            EnterButton.TabIndex = 21;
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
            EyeballLabel.Location = new Point(365, 68);
            EyeballLabel.Name = "EyeballLabel";
            EyeballLabel.Size = new Size(32, 21);
            EyeballLabel.TabIndex = 20;
            EyeballLabel.Text = "👁";
            EyeballLabel.Click += EyeballLabel_Click;
            // 
            // PasswordMaskedTextBox
            // 
            PasswordMaskedTextBox.BackColor = Color.FromArgb(52, 52, 52);
            PasswordMaskedTextBox.Font = new Font("Segoe UI Emoji", 12F);
            PasswordMaskedTextBox.ForeColor = SystemColors.ButtonFace;
            PasswordMaskedTextBox.Location = new Point(122, 65);
            PasswordMaskedTextBox.Name = "PasswordMaskedTextBox";
            PasswordMaskedTextBox.Size = new Size(277, 29);
            PasswordMaskedTextBox.TabIndex = 18;
            PasswordMaskedTextBox.UseSystemPasswordChar = true;
            PasswordMaskedTextBox.TextChanged += PasswordMaskedTextBox_TextChanged;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI Emoji", 12F);
            PasswordLabel.ForeColor = SystemColors.ButtonFace;
            PasswordLabel.Location = new Point(34, 68);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(80, 21);
            PasswordLabel.TabIndex = 19;
            PasswordLabel.Text = "Password:";
            // 
            // InactivityTimer
            // 
            InactivityTimer.Enabled = true;
            InactivityTimer.Interval = 30000;
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.FromArgb(32, 32, 32);
            MenuStrip.Font = new Font("Segoe UI Emoji", 10F);
            MenuStrip.Items.AddRange(new ToolStripItem[] { CloseMenuItem, DecryptToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(470, 29);
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
            // DecryptToolStripMenuItem
            // 
            DecryptToolStripMenuItem.Enabled = false;
            DecryptToolStripMenuItem.ForeColor = SystemColors.AppWorkspace;
            DecryptToolStripMenuItem.Name = "DecryptToolStripMenuItem";
            DecryptToolStripMenuItem.Size = new Size(69, 25);
            DecryptToolStripMenuItem.Text = "Decrypt";
            // 
            // DecryptForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(470, 161);
            ControlBox = false;
            Controls.Add(MenuStrip);
            Controls.Add(FailureLabel);
            Controls.Add(EnterButton);
            Controls.Add(EyeballLabel);
            Controls.Add(PasswordMaskedTextBox);
            Controls.Add(PasswordLabel);
            Font = new Font("Segoe UI Emoji", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "DecryptForm";
            StartPosition = FormStartPosition.CenterParent;
            MouseDown += DecryptForm_MouseDown;
            MouseMove += DecryptForm_MouseMove;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FailureLabel;
        private Button EnterButton;
        private Label EyeballLabel;
        private MaskedTextBox PasswordMaskedTextBox;
        private Label PasswordLabel;
        private System.Windows.Forms.Timer InactivityTimer;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem CloseMenuItem;
        private ToolStripMenuItem DecryptToolStripMenuItem;
    }
}