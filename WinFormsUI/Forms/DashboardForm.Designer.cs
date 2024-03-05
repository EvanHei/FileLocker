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
            FileMenuItem = new ToolStripMenuItem();
            ImportMenuItem = new ToolStripMenuItem();
            ExportMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            HelpMenuItem = new ToolStripMenuItem();
            UserGuideMenuItem = new ToolStripMenuItem();
            FileListBoxItemContextMenuStrip = new ContextMenuStrip(components);
            RemoveFromListItem = new ToolStripMenuItem();
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
            EncryptButton.Location = new Point(273, 329);
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
            DecryptButton.Location = new Point(360, 329);
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
            TrashButton.Location = new Point(48, 329);
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
            AddButton.Location = new Point(534, 329);
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
            FileLockerLabel.Location = new Point(288, 57);
            FileLockerLabel.Name = "FileLockerLabel";
            FileLockerLabel.Size = new Size(133, 36);
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
            MenuStrip.Size = new Size(695, 24);
            MenuStrip.TabIndex = 8;
            MenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.BackColor = Color.FromArgb(32, 32, 32);
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ImportMenuItem, ExportMenuItem, ExitMenuItem });
            FileMenuItem.Font = new Font("Segoe UI Emoji", 9F);
            FileMenuItem.ForeColor = SystemColors.AppWorkspace;
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(37, 20);
            FileMenuItem.Text = "&File";
            // 
            // ImportMenuItem
            // 
            ImportMenuItem.Name = "ImportMenuItem";
            ImportMenuItem.Size = new Size(153, 22);
            ImportMenuItem.Text = "&Import Archive";
            ImportMenuItem.Click += ImportMenuItem_Click;
            // 
            // ExportMenuItem
            // 
            ExportMenuItem.Name = "ExportMenuItem";
            ExportMenuItem.Size = new Size(153, 22);
            ExportMenuItem.Text = "&Export Archive";
            ExportMenuItem.Click += ExportMenuItem_Click;
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.BackColor = SystemColors.Control;
            ExitMenuItem.ForeColor = SystemColors.ControlText;
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(153, 22);
            ExitMenuItem.Text = "E&xit";
            ExitMenuItem.Click += ExitMenuItem_Click;
            // 
            // HelpMenuItem
            // 
            HelpMenuItem.BackColor = Color.FromArgb(32, 32, 32);
            HelpMenuItem.DropDownItems.AddRange(new ToolStripItem[] { UserGuideMenuItem });
            HelpMenuItem.Font = new Font("Segoe UI Emoji", 9F);
            HelpMenuItem.ForeColor = SystemColors.AppWorkspace;
            HelpMenuItem.Name = "HelpMenuItem";
            HelpMenuItem.Size = new Size(44, 20);
            HelpMenuItem.Text = "&Help";
            // 
            // UserGuideMenuItem
            // 
            UserGuideMenuItem.BackColor = SystemColors.Control;
            UserGuideMenuItem.ForeColor = SystemColors.ControlText;
            UserGuideMenuItem.Name = "UserGuideMenuItem";
            UserGuideMenuItem.Size = new Size(131, 22);
            UserGuideMenuItem.Text = "User &Guide";
            UserGuideMenuItem.Click += UserGuideMenuItem_Click;
            // 
            // FileListBoxItemContextMenuStrip
            // 
            FileListBoxItemContextMenuStrip.Items.AddRange(new ToolStripItem[] { RemoveFromListItem });
            FileListBoxItemContextMenuStrip.Name = "FileListBoxItemContextMenuStrip";
            FileListBoxItemContextMenuStrip.Size = new Size(181, 48);
            FileListBoxItemContextMenuStrip.Tag = "FileListBox";
            FileListBoxItemContextMenuStrip.Text = "Remove File";
            // 
            // RemoveFromListItem
            // 
            RemoveFromListItem.Name = "RemoveFromListItem";
            RemoveFromListItem.Size = new Size(180, 22);
            RemoveFromListItem.Text = "Remove from list";
            RemoveFromListItem.Click += RemoveFileItem_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(695, 397);
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
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem HelpMenuItem;
        private ToolStripMenuItem UserGuideMenuItem;
        private ToolStripMenuItem ExportMenuItem;
        private ToolStripMenuItem ImportMenuItem;
        private ContextMenuStrip FileListBoxItemContextMenuStrip;
        private ToolStripMenuItem RemoveFromListItem;
    }
}
