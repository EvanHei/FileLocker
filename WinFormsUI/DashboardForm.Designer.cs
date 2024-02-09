namespace WinFormsUI
{
    partial class DashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FileLabel = new Label();
            StatusLabel = new Label();
            FileListBox = new ListBox();
            EncryptButton = new Button();
            DecryptButton = new Button();
            TrashButton = new Button();
            AddButton = new Button();
            DashboardLabel = new Label();
            SuspendLayout();
            // 
            // FileLabel
            // 
            FileLabel.AutoSize = true;
            FileLabel.ForeColor = SystemColors.ButtonFace;
            FileLabel.Location = new Point(61, 89);
            FileLabel.Name = "FileLabel";
            FileLabel.Size = new Size(34, 20);
            FileLabel.TabIndex = 0;
            FileLabel.Text = "File";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.ForeColor = SystemColors.ButtonFace;
            StatusLabel.Location = new Point(838, 89);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(56, 20);
            StatusLabel.TabIndex = 1;
            StatusLabel.Text = "Status";
            // 
            // FileListBox
            // 
            FileListBox.BackColor = Color.FromArgb(40, 40, 40);
            FileListBox.ForeColor = SystemColors.ButtonFace;
            FileListBox.FormattingEnabled = true;
            FileListBox.ItemHeight = 20;
            FileListBox.Location = new Point(61, 112);
            FileListBox.Name = "FileListBox";
            FileListBox.Size = new Size(833, 204);
            FileListBox.TabIndex = 2;
            // 
            // EncryptButton
            // 
            EncryptButton.BackColor = Color.FromArgb(28, 28, 28);
            EncryptButton.ForeColor = SystemColors.ButtonFace;
            EncryptButton.Location = new Point(404, 322);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(81, 35);
            EncryptButton.TabIndex = 3;
            EncryptButton.Text = "Encrypt";
            EncryptButton.UseVisualStyleBackColor = false;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // DecryptButton
            // 
            DecryptButton.BackColor = Color.FromArgb(28, 28, 28);
            DecryptButton.ForeColor = SystemColors.ButtonFace;
            DecryptButton.Location = new Point(491, 322);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(81, 35);
            DecryptButton.TabIndex = 4;
            DecryptButton.Text = "Decrypt";
            DecryptButton.UseVisualStyleBackColor = false;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // TrashButton
            // 
            TrashButton.BackColor = Color.FromArgb(28, 28, 28);
            TrashButton.ForeColor = SystemColors.ButtonFace;
            TrashButton.Location = new Point(61, 322);
            TrashButton.Name = "TrashButton";
            TrashButton.Size = new Size(34, 35);
            TrashButton.TabIndex = 5;
            TrashButton.Text = "🗑️";
            TrashButton.UseVisualStyleBackColor = false;
            TrashButton.Click += TrashButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.DarkGreen;
            AddButton.ForeColor = SystemColors.ButtonFace;
            AddButton.Location = new Point(860, 322);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(34, 35);
            AddButton.TabIndex = 6;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // DashboardLabel
            // 
            DashboardLabel.AutoSize = true;
            DashboardLabel.Font = new Font("Microsoft Sans Serif", 20.25F);
            DashboardLabel.ForeColor = SystemColors.ButtonFace;
            DashboardLabel.Location = new Point(404, 30);
            DashboardLabel.Name = "DashboardLabel";
            DashboardLabel.Size = new Size(147, 31);
            DashboardLabel.TabIndex = 7;
            DashboardLabel.Text = "Dashboard";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(966, 438);
            Controls.Add(DashboardLabel);
            Controls.Add(AddButton);
            Controls.Add(TrashButton);
            Controls.Add(DecryptButton);
            Controls.Add(EncryptButton);
            Controls.Add(FileListBox);
            Controls.Add(StatusLabel);
            Controls.Add(FileLabel);
            Font = new Font("Microsoft Sans Serif", 12F);
            Margin = new Padding(4);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FileLocker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FileLabel;
        private Label StatusLabel;
        private ListBox FileListBox;
        private Button EncryptButton;
        private Button DecryptButton;
        private Button TrashButton;
        private Button AddButton;
        private Label DashboardLabel;
    }
}
