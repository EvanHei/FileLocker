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
            PasswordLabel.ForeColor = SystemColors.ButtonFace;
            PasswordLabel.Location = new Point(34, 64);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(82, 20);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password:";
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
            // EyeballLabel
            // 
            EyeballLabel.AutoSize = true;
            EyeballLabel.BackColor = Color.FromArgb(52, 52, 52);
            EyeballLabel.ForeColor = SystemColors.ButtonFace;
            EyeballLabel.Location = new Point(369, 64);
            EyeballLabel.Name = "EyeballLabel";
            EyeballLabel.Size = new Size(25, 20);
            EyeballLabel.TabIndex = 2;
            EyeballLabel.Text = "👁";
            EyeballLabel.Click += EyeballLabel_Click;
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.FromArgb(52, 52, 52);
            EnterButton.ForeColor = SystemColors.ButtonFace;
            EnterButton.Location = new Point(405, 57);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(34, 35);
            EnterButton.TabIndex = 11;
            EnterButton.Text = "→\n";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // DecryptForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(470, 153);
            Controls.Add(EnterButton);
            Controls.Add(EyeballLabel);
            Controls.Add(PasswordMaskedTextBox);
            Controls.Add(PasswordLabel);
            Font = new Font("Microsoft Sans Serif", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "DecryptForm";
            StartPosition = FormStartPosition.CenterScreen;
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