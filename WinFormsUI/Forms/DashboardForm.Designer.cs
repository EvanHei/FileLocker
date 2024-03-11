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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            FileListBox = new ListBox();
            EncryptButton = new Button();
            DecryptButton = new Button();
            TrashButton = new Button();
            AddButton = new Button();
            FileLockerLabel = new Label();
            MenuStrip = new MenuStrip();
            UserGuideMenuItem = new ToolStripMenuItem();
            FileListBoxItemContextMenuStrip = new ContextMenuStrip(components);
            RemoveFromListItem = new ToolStripMenuItem();
            ExportButton = new Button();
            ImportButton = new Button();
            MenuStrip.SuspendLayout();
            FileListBoxItemContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // FileListBox
            // 
            FileListBox.AllowDrop = true;
            FileListBox.BackColor = Color.FromArgb(40, 40, 40);
            FileListBox.DrawMode = DrawMode.OwnerDrawFixed;
            FileListBox.Font = new Font("Segoe UI Emoji", 12F);
            FileListBox.ForeColor = SystemColors.ButtonFace;
            FileListBox.FormattingEnabled = true;
            FileListBox.ItemHeight = 20;
            FileListBox.Location = new Point(48, 109);
            FileListBox.Name = "FileListBox";
            FileListBox.SelectionMode = SelectionMode.MultiSimple;
            FileListBox.Size = new Size(577, 184);
            FileListBox.TabIndex = 1;
            FileListBox.DrawItem += FileListBox_DrawItem;
            FileListBox.SelectedIndexChanged += FileListBox_SelectedIndexChanged;
            FileListBox.DragDrop += FileListBox_DragDrop;
            FileListBox.DragEnter += FileListBox_DragEnter;
            FileListBox.MouseDown += FileListBox_MouseDown;
            // 
            // EncryptButton
            // 
            EncryptButton.BackColor = Color.Silver;
            EncryptButton.FlatStyle = FlatStyle.Flat;
            EncryptButton.Font = new Font("Segoe UI Emoji", 12F);
            EncryptButton.ForeColor = SystemColors.ButtonFace;
            EncryptButton.Location = new Point(273, 299);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(81, 37);
            EncryptButton.TabIndex = 2;
            EncryptButton.Text = "Encrypt";
            EncryptButton.UseVisualStyleBackColor = false;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // DecryptButton
            // 
            DecryptButton.BackColor = Color.Silver;
            DecryptButton.FlatStyle = FlatStyle.Flat;
            DecryptButton.Font = new Font("Segoe UI Emoji", 12F);
            DecryptButton.ForeColor = SystemColors.ButtonFace;
            DecryptButton.Location = new Point(360, 299);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(81, 37);
            DecryptButton.TabIndex = 3;
            DecryptButton.Text = "Decrypt";
            DecryptButton.UseVisualStyleBackColor = false;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // TrashButton
            // 
            TrashButton.BackColor = Color.DarkRed;
            TrashButton.FlatStyle = FlatStyle.Flat;
            TrashButton.Font = new Font("Segoe UI Emoji", 12F);
            TrashButton.ForeColor = SystemColors.ButtonFace;
            TrashButton.Location = new Point(48, 299);
            TrashButton.Name = "TrashButton";
            TrashButton.Size = new Size(34, 37);
            TrashButton.TabIndex = 5;
            TrashButton.Text = "🗑️";
            TrashButton.UseVisualStyleBackColor = false;
            TrashButton.Click += TrashButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.DarkGreen;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI Emoji", 12F);
            AddButton.ForeColor = SystemColors.ButtonFace;
            AddButton.Location = new Point(534, 299);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(91, 37);
            AddButton.TabIndex = 4;
            AddButton.Text = "+ Add File";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // FileLockerLabel
            // 
            FileLockerLabel.AutoSize = true;
            FileLockerLabel.Font = new Font("Segoe UI Emoji", 20.25F);
            FileLockerLabel.ForeColor = SystemColors.ButtonFace;
            FileLockerLabel.Location = new Point(295, 24);
            FileLockerLabel.Name = "FileLockerLabel";
            FileLockerLabel.Size = new Size(133, 36);
            FileLockerLabel.TabIndex = 7;
            FileLockerLabel.Text = "FileLocker";
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.FromArgb(32, 32, 32);
            MenuStrip.Font = new Font("Microsoft Sans Serif", 9F);
            MenuStrip.Items.AddRange(new ToolStripItem[] { UserGuideMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(682, 24);
            MenuStrip.TabIndex = 8;
            MenuStrip.Text = "menuStrip1";
            // 
            // UserGuideMenuItem
            // 
            UserGuideMenuItem.BackColor = Color.FromArgb(32, 32, 32);
            UserGuideMenuItem.Font = new Font("Segoe UI Emoji", 9F);
            UserGuideMenuItem.ForeColor = SystemColors.AppWorkspace;
            UserGuideMenuItem.Name = "UserGuideMenuItem";
            UserGuideMenuItem.Size = new Size(95, 20);
            UserGuideMenuItem.Text = "User &Guide 📖";
            UserGuideMenuItem.Click += UserGuideMenuItem_Click;
            // 
            // FileListBoxItemContextMenuStrip
            // 
            FileListBoxItemContextMenuStrip.Items.AddRange(new ToolStripItem[] { RemoveFromListItem });
            FileListBoxItemContextMenuStrip.Name = "FileListBoxItemContextMenuStrip";
            FileListBoxItemContextMenuStrip.Size = new Size(165, 26);
            FileListBoxItemContextMenuStrip.Tag = "FileListBox";
            FileListBoxItemContextMenuStrip.Text = "Remove File";
            // 
            // RemoveFromListItem
            // 
            RemoveFromListItem.Name = "RemoveFromListItem";
            RemoveFromListItem.Size = new Size(164, 22);
            RemoveFromListItem.Text = "Remove from list";
            RemoveFromListItem.Click += RemoveFile_Click;
            // 
            // ExportButton
            // 
            ExportButton.BackColor = Color.FromArgb(32, 32, 32);
            ExportButton.FlatStyle = FlatStyle.Flat;
            ExportButton.Font = new Font("Segoe UI Emoji", 10F);
            ExportButton.ForeColor = SystemColors.ButtonFace;
            ExportButton.Location = new Point(595, 73);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(30, 30);
            ExportButton.TabIndex = 9;
            ExportButton.Text = "📤";
            ExportButton.UseVisualStyleBackColor = false;
            ExportButton.Click += ExportButton_Click;
            // 
            // ImportButton
            // 
            ImportButton.BackColor = Color.FromArgb(32, 32, 32);
            ImportButton.FlatStyle = FlatStyle.Flat;
            ImportButton.Font = new Font("Segoe UI Emoji", 10F);
            ImportButton.ForeColor = SystemColors.ButtonFace;
            ImportButton.Location = new Point(559, 73);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(30, 30);
            ImportButton.TabIndex = 10;
            ImportButton.Text = "📥";
            ImportButton.UseVisualStyleBackColor = false;
            ImportButton.Click += ImportButton_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(682, 354);
            Controls.Add(ImportButton);
            Controls.Add(ExportButton);
            Controls.Add(FileLockerLabel);
            Controls.Add(AddButton);
            Controls.Add(TrashButton);
            Controls.Add(DecryptButton);
            Controls.Add(EncryptButton);
            Controls.Add(FileListBox);
            Controls.Add(MenuStrip);
            Font = new Font("Segoe UI Emoji", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuStrip;
            Margin = new Padding(4);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            FormClosing += DashboardForm_FormClosing;
            Load += DashboardForm_Load;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            FileListBoxItemContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox FileListBox;
        private Button EncryptButton;
        private Button DecryptButton;
        private Button TrashButton;
        private Button AddButton;
        private Label FileLockerLabel;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem UserGuideMenuItem;
        private ContextMenuStrip FileListBoxItemContextMenuStrip;
        private ToolStripMenuItem RemoveFromListItem;
        private Button ExportButton;
        private Button ImportButton;
    }
}
