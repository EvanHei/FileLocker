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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            FileLabel = new Label();
            StatusLabel = new Label();
            FileListBox = new ListBox();
            EncryptButton = new Button();
            DecryptButton = new Button();
            TrashButton = new Button();
            AddButton = new Button();
            FileLockerLabel = new Label();
            MenuStrip = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            HelpMenuItem = new ToolStripMenuItem();
            UserGuideMenuItem = new ToolStripMenuItem();
            MenuStrip.SuspendLayout();
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
            StatusLabel.Location = new Point(582, 89);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(56, 20);
            StatusLabel.TabIndex = 1;
            StatusLabel.Text = "Status";
            // 
            // FileListBox
            // 
            FileListBox.BackColor = Color.FromArgb(40, 40, 40);
            FileListBox.DrawMode = DrawMode.OwnerDrawFixed;
            FileListBox.ForeColor = SystemColors.ButtonFace;
            FileListBox.FormattingEnabled = true;
            FileListBox.ItemHeight = 20;
            FileListBox.Location = new Point(61, 112);
            FileListBox.Name = "FileListBox";
            FileListBox.Size = new Size(577, 204);
            FileListBox.TabIndex = 1;
            FileListBox.DrawItem += FileListBox_DrawItem;
            FileListBox.SelectedIndexChanged += FileListBox_SelectedIndexChanged;
            // 
            // EncryptButton
            // 
            EncryptButton.BackColor = Color.Silver;
            EncryptButton.ForeColor = SystemColors.ButtonFace;
            EncryptButton.Location = new Point(286, 322);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(81, 35);
            EncryptButton.TabIndex = 2;
            EncryptButton.Text = "Encrypt";
            EncryptButton.UseVisualStyleBackColor = false;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // DecryptButton
            // 
            DecryptButton.BackColor = Color.Silver;
            DecryptButton.ForeColor = SystemColors.ButtonFace;
            DecryptButton.Location = new Point(373, 322);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(81, 35);
            DecryptButton.TabIndex = 3;
            DecryptButton.Text = "Decrypt";
            DecryptButton.UseVisualStyleBackColor = false;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // TrashButton
            // 
            TrashButton.BackColor = Color.Silver;
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
            AddButton.Location = new Point(604, 322);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(34, 35);
            AddButton.TabIndex = 4;
            AddButton.Text = "+";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // FileLockerLabel
            // 
            FileLockerLabel.AutoSize = true;
            FileLockerLabel.Font = new Font("Microsoft Sans Serif", 20.25F);
            FileLockerLabel.ForeColor = SystemColors.ButtonFace;
            FileLockerLabel.Location = new Point(298, 44);
            FileLockerLabel.Name = "FileLockerLabel";
            FileLockerLabel.Size = new Size(140, 31);
            FileLockerLabel.TabIndex = 7;
            FileLockerLabel.Text = "FileLocker";
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.FromArgb(32, 32, 32);
            MenuStrip.Font = new Font("Microsoft Sans Serif", 9F);
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileMenuItem, HelpMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(711, 24);
            MenuStrip.TabIndex = 8;
            MenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.BackColor = Color.FromArgb(32, 32, 32);
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitMenuItem });
            FileMenuItem.ForeColor = SystemColors.AppWorkspace;
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(39, 20);
            FileMenuItem.Text = "&File";
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.BackColor = SystemColors.Control;
            ExitMenuItem.ForeColor = SystemColors.ControlText;
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(94, 22);
            ExitMenuItem.Text = "E&xit";
            // 
            // HelpMenuItem
            // 
            HelpMenuItem.BackColor = Color.FromArgb(32, 32, 32);
            HelpMenuItem.DropDownItems.AddRange(new ToolStripItem[] { UserGuideMenuItem });
            HelpMenuItem.ForeColor = SystemColors.AppWorkspace;
            HelpMenuItem.Name = "HelpMenuItem";
            HelpMenuItem.Size = new Size(45, 20);
            HelpMenuItem.Text = "&Help";
            // 
            // UserGuideMenuItem
            // 
            UserGuideMenuItem.BackColor = SystemColors.Control;
            UserGuideMenuItem.ForeColor = SystemColors.ControlText;
            UserGuideMenuItem.Name = "UserGuideMenuItem";
            UserGuideMenuItem.Size = new Size(136, 22);
            UserGuideMenuItem.Text = "User &Guide";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(711, 438);
            Controls.Add(FileLockerLabel);
            Controls.Add(AddButton);
            Controls.Add(TrashButton);
            Controls.Add(DecryptButton);
            Controls.Add(EncryptButton);
            Controls.Add(FileListBox);
            Controls.Add(StatusLabel);
            Controls.Add(FileLabel);
            Controls.Add(MenuStrip);
            Font = new Font("Microsoft Sans Serif", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuStrip;
            Margin = new Padding(4);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
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
        private Label FileLockerLabel;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem HelpMenuItem;
        private ToolStripMenuItem UserGuideMenuItem;
    }
}
