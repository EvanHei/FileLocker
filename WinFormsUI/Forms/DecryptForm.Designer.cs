namespace WinFormsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecryptForm));
            PasswordLabel = new Label();
            PasswordMaskedTextBox = new MaskedTextBox();
            EyeballLabel = new Label();
            EnterButton = new Button();
            SuspendLayout();
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI Emoji", 12F);
            PasswordLabel.ForeColor = SystemColors.ButtonFace;
            PasswordLabel.Location = new Point(34, 67);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(80, 21);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password:";
            // 
            // PasswordMaskedTextBox
            // 
            PasswordMaskedTextBox.BackColor = Color.FromArgb(52, 52, 52);
            PasswordMaskedTextBox.Font = new Font("Segoe UI Emoji", 12F);
            PasswordMaskedTextBox.ForeColor = SystemColors.ButtonFace;
            PasswordMaskedTextBox.Location = new Point(122, 64);
            PasswordMaskedTextBox.Name = "PasswordMaskedTextBox";
            PasswordMaskedTextBox.Size = new Size(277, 29);
            PasswordMaskedTextBox.TabIndex = 1;
            PasswordMaskedTextBox.UseSystemPasswordChar = true;
            // 
            // EyeballLabel
            // 
            EyeballLabel.AutoSize = true;
            EyeballLabel.BackColor = Color.FromArgb(52, 52, 52);
            EyeballLabel.Font = new Font("Segoe UI Emoji", 12F);
            EyeballLabel.ForeColor = SystemColors.ButtonFace;
            EyeballLabel.Location = new Point(365, 67);
            EyeballLabel.Name = "EyeballLabel";
            EyeballLabel.Size = new Size(32, 21);
            EyeballLabel.TabIndex = 2;
            EyeballLabel.Text = "👁";
            EyeballLabel.Click += EyeballLabel_Click;
            // 
            // EnterButton
            // 
            EnterButton.BackColor = SystemColors.Highlight;
            EnterButton.Font = new Font("Segoe UI Emoji", 12F);
            EnterButton.ForeColor = SystemColors.ButtonFace;
            EnterButton.Location = new Point(405, 60);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(34, 37);
            EnterButton.TabIndex = 11;
            EnterButton.Text = "→\n";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // DecryptForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(470, 161);
            Controls.Add(EnterButton);
            Controls.Add(EyeballLabel);
            Controls.Add(PasswordMaskedTextBox);
            Controls.Add(PasswordLabel);
            Font = new Font("Segoe UI Emoji", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "DecryptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Decrypt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PasswordLabel;
        private MaskedTextBox PasswordMaskedTextBox;
        private Label EyeballLabel;
        private Button EnterButton;
    }
}