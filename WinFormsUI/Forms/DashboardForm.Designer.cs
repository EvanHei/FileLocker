﻿namespace WinFormsUI
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
            FileListBoxContextMenuStrip = new ContextMenuStrip(components);
            RemoveFromListItem = new ToolStripMenuItem();
            MenuStrip = new MenuStrip();
            SettingsMenuItem = new ToolStripMenuItem();
            DiagnosticsMenuItem = new ToolStripMenuItem();
            GuideMenuItem = new ToolStripMenuItem();
            SearchTextBox = new TextBox();
            MagnifyingGlassLabel = new Label();
            AddButton = new Button();
            AddButtonContextMenuStrip = new ContextMenuStrip(components);
            AddExistingFilesToolStripMenuItem = new ToolStripMenuItem();
            ImportArchiveToolStripMenuItem = new ToolStripMenuItem();
            NoFilesPanel = new Panel();
            NoFilesPanel_NoFilesDescriptionLabel = new Label();
            NoFilesPanel_NoFilesLabel = new Label();
            LockedPanel = new Panel();
            LockedPanel_ExplorerGroupBox = new GroupBox();
            LockedPanel_ExplorerDescriptionLabel = new Label();
            LockedPanel_ExplorerButton = new Button();
            LockedPanel_ShaClipboardLabel = new Label();
            LockedPanel_ExportGroupBox = new GroupBox();
            LockedPanel_ExportDescriptionLabel = new Label();
            LockedPanel_ExportButton = new Button();
            LockedPanel_PathClipboardLabel = new Label();
            LockedPanel_ShredGroupBox = new GroupBox();
            LockedPanel_ShredDescriptionLabel = new Label();
            LockedPanel_ShredButton = new Button();
            LockedPanel_DecryptGroupBox = new GroupBox();
            LockedPanel_DecryptDescriptionLabel = new Label();
            LockedPanel_DecryptButton = new Button();
            LockedPanel_ShaValueLabel = new Label();
            LockedPanel_ShaLabel = new Label();
            LockedPanel_SizeValueLabel = new Label();
            LockedPanel_SizeLabel = new Label();
            LockedPanel_PathValueLabel = new Label();
            LockedPanel_PathLabel = new Label();
            LockedPanel_AlgorithmValueLabel = new Label();
            LockedPanel_AlgorithmLabel = new Label();
            LockedPanel_StatusValueLabel = new Label();
            LockedPanel_StatusLabel = new Label();
            LockedPanel_FileNameLabel = new Label();
            RelocationPanel = new Panel();
            RelocationPanel_RemoveButton = new Button();
            RelocationPanel_RelocateButton = new Button();
            RelocationPanel_LastSeenLabel = new Label();
            RelocationPanel_CantLocateFileLabel = new Label();
            UnlockedPanel = new Panel();
            UnlockedPanel_ExplorerGroupBox = new GroupBox();
            UnlockedPanel_ExplorerDescriptionLabel = new Label();
            UnlockedPanel_ExplorerButton = new Button();
            UnlockedPanel_ShaClipboardLabel = new Label();
            UnlockedPanel_PathClipboardLabel = new Label();
            UnlockedPanel_ShredGroupBox = new GroupBox();
            UnlockedPanel_ShredDescriptionLabel = new Label();
            UnlockedPanel_ShredButton = new Button();
            UnlockedPanel_EncryptGroupBox = new GroupBox();
            UnlockedPanel_EncryptDescriptionLabel = new Label();
            UnlockedPanel_EncryptButton = new Button();
            UnlockedPanel_ShaValueLabel = new Label();
            UnlockedPanel_ShaLabel = new Label();
            UnlockedPanel_SizeValueLabel = new Label();
            UnlockedPanel_SizeLabel = new Label();
            UnlockedPanel_PathValueLabel = new Label();
            UnlockedPanel_PathLabel = new Label();
            UnlockedPanel_StatusValueLabel = new Label();
            UnlockedPanel_StatusLabel = new Label();
            UnlockedPanel_FileNameLabel = new Label();
            FileListBoxContextMenuStrip.SuspendLayout();
            MenuStrip.SuspendLayout();
            AddButtonContextMenuStrip.SuspendLayout();
            NoFilesPanel.SuspendLayout();
            LockedPanel.SuspendLayout();
            LockedPanel_ExplorerGroupBox.SuspendLayout();
            LockedPanel_ExportGroupBox.SuspendLayout();
            LockedPanel_ShredGroupBox.SuspendLayout();
            LockedPanel_DecryptGroupBox.SuspendLayout();
            RelocationPanel.SuspendLayout();
            UnlockedPanel.SuspendLayout();
            UnlockedPanel_ExplorerGroupBox.SuspendLayout();
            UnlockedPanel_ShredGroupBox.SuspendLayout();
            UnlockedPanel_EncryptGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FileListBox
            // 
            FileListBox.AllowDrop = true;
            FileListBox.BackColor = Color.FromArgb(40, 40, 40);
            FileListBox.BorderStyle = BorderStyle.None;
            FileListBox.ContextMenuStrip = FileListBoxContextMenuStrip;
            FileListBox.DrawMode = DrawMode.OwnerDrawFixed;
            FileListBox.Font = new Font("Segoe UI Emoji", 12F);
            FileListBox.ForeColor = SystemColors.ButtonFace;
            FileListBox.FormattingEnabled = true;
            FileListBox.ItemHeight = 25;
            FileListBox.Location = new Point(0, 66);
            FileListBox.Name = "FileListBox";
            FileListBox.Size = new Size(361, 875);
            FileListBox.TabIndex = 11;
            FileListBox.DrawItem += FileListBox_DrawItem;
            FileListBox.SelectedIndexChanged += FileListBox_SelectedIndexChanged;
            FileListBox.DragDrop += FileListBox_DragDrop;
            FileListBox.DragEnter += FileListBox_DragEnter;
            FileListBox.MouseDown += FileListBox_MouseDown;
            // 
            // FileListBoxContextMenuStrip
            // 
            FileListBoxContextMenuStrip.Items.AddRange(new ToolStripItem[] { RemoveFromListItem });
            FileListBoxContextMenuStrip.Name = "FileListBoxItemContextMenuStrip";
            FileListBoxContextMenuStrip.Size = new Size(165, 26);
            FileListBoxContextMenuStrip.Tag = "FileListBox";
            FileListBoxContextMenuStrip.Text = "Remove File";
            // 
            // RemoveFromListItem
            // 
            RemoveFromListItem.BackColor = Color.FromArgb(40, 40, 40);
            RemoveFromListItem.ForeColor = SystemColors.ButtonFace;
            RemoveFromListItem.Name = "RemoveFromListItem";
            RemoveFromListItem.Size = new Size(164, 22);
            RemoveFromListItem.Text = "Remove from list";
            RemoveFromListItem.Click += RemoveFromListItem_Click;
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.FromArgb(40, 40, 40);
            MenuStrip.Font = new Font("Segoe UI Emoji", 10F);
            MenuStrip.Items.AddRange(new ToolStripItem[] { SettingsMenuItem, DiagnosticsMenuItem, GuideMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(1217, 29);
            MenuStrip.TabIndex = 17;
            MenuStrip.Text = "menuStrip1";
            // 
            // SettingsMenuItem
            // 
            SettingsMenuItem.Alignment = ToolStripItemAlignment.Right;
            SettingsMenuItem.Font = new Font("Segoe UI Emoji", 10F);
            SettingsMenuItem.ForeColor = SystemColors.AppWorkspace;
            SettingsMenuItem.Margin = new Padding(0, 2, 0, 0);
            SettingsMenuItem.Name = "SettingsMenuItem";
            SettingsMenuItem.Size = new Size(93, 23);
            SettingsMenuItem.Text = "&Settings ⚙";
            // 
            // DiagnosticsMenuItem
            // 
            DiagnosticsMenuItem.Alignment = ToolStripItemAlignment.Right;
            DiagnosticsMenuItem.Font = new Font("Segoe UI Emoji", 10F);
            DiagnosticsMenuItem.ForeColor = SystemColors.AppWorkspace;
            DiagnosticsMenuItem.Margin = new Padding(0, 2, 0, 0);
            DiagnosticsMenuItem.Name = "DiagnosticsMenuItem";
            DiagnosticsMenuItem.Size = new Size(113, 23);
            DiagnosticsMenuItem.Text = "&Diagnostics 📊";
            // 
            // GuideMenuItem
            // 
            GuideMenuItem.Alignment = ToolStripItemAlignment.Right;
            GuideMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            GuideMenuItem.Font = new Font("Segoe UI Emoji", 10F);
            GuideMenuItem.ForeColor = SystemColors.AppWorkspace;
            GuideMenuItem.Margin = new Padding(0, 2, 0, 0);
            GuideMenuItem.Name = "GuideMenuItem";
            GuideMenuItem.Size = new Size(80, 23);
            GuideMenuItem.Text = "&Guide 📖";
            GuideMenuItem.Click += GuideMenuItem_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.BackColor = Color.FromArgb(32, 32, 32);
            SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchTextBox.Font = new Font("Segoe UI Emoji", 12F);
            SearchTextBox.ForeColor = SystemColors.ButtonFace;
            SearchTextBox.Location = new Point(9, 31);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(261, 29);
            SearchTextBox.TabIndex = 18;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // MagnifyingGlassLabel
            // 
            MagnifyingGlassLabel.AutoSize = true;
            MagnifyingGlassLabel.BackColor = Color.FromArgb(32, 32, 32);
            MagnifyingGlassLabel.Font = new Font("Segoe UI Emoji", 12F);
            MagnifyingGlassLabel.ForeColor = SystemColors.ButtonFace;
            MagnifyingGlassLabel.Location = new Point(234, 33);
            MagnifyingGlassLabel.Name = "MagnifyingGlassLabel";
            MagnifyingGlassLabel.Size = new Size(32, 21);
            MagnifyingGlassLabel.TabIndex = 20;
            MagnifyingGlassLabel.Text = "🔍";
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(52, 52, 52);
            AddButton.ContextMenuStrip = AddButtonContextMenuStrip;
            AddButton.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI Emoji", 12F);
            AddButton.ForeColor = SystemColors.ButtonFace;
            AddButton.Location = new Point(277, 31);
            AddButton.Name = "AddButton";
            AddButton.Padding = new Padding(7, 0, 0, 0);
            AddButton.Size = new Size(77, 29);
            AddButton.TabIndex = 21;
            AddButton.Text = "&Add ▼";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.MouseDown += AddButton_MouseDown;
            // 
            // AddButtonContextMenuStrip
            // 
            AddButtonContextMenuStrip.Items.AddRange(new ToolStripItem[] { AddExistingFilesToolStripMenuItem, ImportArchiveToolStripMenuItem });
            AddButtonContextMenuStrip.Name = "AddButtonContextMenuStrip";
            AddButtonContextMenuStrip.Size = new Size(173, 48);
            AddButtonContextMenuStrip.Tag = "";
            // 
            // AddExistingFilesToolStripMenuItem
            // 
            AddExistingFilesToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            AddExistingFilesToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            AddExistingFilesToolStripMenuItem.Name = "AddExistingFilesToolStripMenuItem";
            AddExistingFilesToolStripMenuItem.Size = new Size(172, 22);
            AddExistingFilesToolStripMenuItem.Text = "Add existing file(s)";
            AddExistingFilesToolStripMenuItem.Click += AddExistingFileToolStripMenuItem_Click;
            // 
            // ImportArchiveToolStripMenuItem
            // 
            ImportArchiveToolStripMenuItem.BackColor = Color.FromArgb(40, 40, 40);
            ImportArchiveToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            ImportArchiveToolStripMenuItem.Name = "ImportArchiveToolStripMenuItem";
            ImportArchiveToolStripMenuItem.Size = new Size(172, 22);
            ImportArchiveToolStripMenuItem.Text = "Import archive";
            ImportArchiveToolStripMenuItem.Click += ImportArchiveToolStripMenuItem_Click;
            // 
            // NoFilesPanel
            // 
            NoFilesPanel.BackColor = Color.FromArgb(32, 32, 32);
            NoFilesPanel.BorderStyle = BorderStyle.FixedSingle;
            NoFilesPanel.Controls.Add(NoFilesPanel_NoFilesDescriptionLabel);
            NoFilesPanel.Controls.Add(NoFilesPanel_NoFilesLabel);
            NoFilesPanel.Location = new Point(361, 31);
            NoFilesPanel.Name = "NoFilesPanel";
            NoFilesPanel.Size = new Size(864, 921);
            NoFilesPanel.TabIndex = 22;
            // 
            // NoFilesPanel_NoFilesDescriptionLabel
            // 
            NoFilesPanel_NoFilesDescriptionLabel.AutoSize = true;
            NoFilesPanel_NoFilesDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            NoFilesPanel_NoFilesDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            NoFilesPanel_NoFilesDescriptionLabel.Location = new Point(270, 420);
            NoFilesPanel_NoFilesDescriptionLabel.Name = "NoFilesPanel_NoFilesDescriptionLabel";
            NoFilesPanel_NoFilesDescriptionLabel.Size = new Size(399, 42);
            NoFilesPanel_NoFilesDescriptionLabel.TabIndex = 23;
            NoFilesPanel_NoFilesDescriptionLabel.Text = "Click Add button to import an archive or manually select\r\nfiles, or drag and drop onto the left list.\r\n";
            // 
            // NoFilesPanel_NoFilesLabel
            // 
            NoFilesPanel_NoFilesLabel.AutoSize = true;
            NoFilesPanel_NoFilesLabel.Font = new Font("Segoe UI Emoji", 20.25F);
            NoFilesPanel_NoFilesLabel.ForeColor = SystemColors.ButtonFace;
            NoFilesPanel_NoFilesLabel.Location = new Point(401, 378);
            NoFilesPanel_NoFilesLabel.Name = "NoFilesPanel_NoFilesLabel";
            NoFilesPanel_NoFilesLabel.Size = new Size(105, 36);
            NoFilesPanel_NoFilesLabel.TabIndex = 8;
            NoFilesPanel_NoFilesLabel.Text = "No files";
            // 
            // LockedPanel
            // 
            LockedPanel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel.BorderStyle = BorderStyle.FixedSingle;
            LockedPanel.Controls.Add(LockedPanel_ExplorerGroupBox);
            LockedPanel.Controls.Add(LockedPanel_ShaClipboardLabel);
            LockedPanel.Controls.Add(LockedPanel_ExportGroupBox);
            LockedPanel.Controls.Add(LockedPanel_PathClipboardLabel);
            LockedPanel.Controls.Add(LockedPanel_ShredGroupBox);
            LockedPanel.Controls.Add(LockedPanel_DecryptGroupBox);
            LockedPanel.Controls.Add(LockedPanel_ShaValueLabel);
            LockedPanel.Controls.Add(LockedPanel_ShaLabel);
            LockedPanel.Controls.Add(LockedPanel_SizeValueLabel);
            LockedPanel.Controls.Add(LockedPanel_SizeLabel);
            LockedPanel.Controls.Add(LockedPanel_PathValueLabel);
            LockedPanel.Controls.Add(LockedPanel_PathLabel);
            LockedPanel.Controls.Add(LockedPanel_AlgorithmValueLabel);
            LockedPanel.Controls.Add(LockedPanel_AlgorithmLabel);
            LockedPanel.Controls.Add(LockedPanel_StatusValueLabel);
            LockedPanel.Controls.Add(LockedPanel_StatusLabel);
            LockedPanel.Controls.Add(LockedPanel_FileNameLabel);
            LockedPanel.Location = new Point(361, 31);
            LockedPanel.Name = "LockedPanel";
            LockedPanel.Size = new Size(864, 921);
            LockedPanel.TabIndex = 24;
            // 
            // LockedPanel_ExplorerGroupBox
            // 
            LockedPanel_ExplorerGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_ExplorerGroupBox.Controls.Add(LockedPanel_ExplorerDescriptionLabel);
            LockedPanel_ExplorerGroupBox.Controls.Add(LockedPanel_ExplorerButton);
            LockedPanel_ExplorerGroupBox.FlatStyle = FlatStyle.Flat;
            LockedPanel_ExplorerGroupBox.ForeColor = SystemColors.ButtonFace;
            LockedPanel_ExplorerGroupBox.Location = new Point(22, 480);
            LockedPanel_ExplorerGroupBox.Name = "LockedPanel_ExplorerGroupBox";
            LockedPanel_ExplorerGroupBox.Size = new Size(807, 116);
            LockedPanel_ExplorerGroupBox.TabIndex = 45;
            LockedPanel_ExplorerGroupBox.TabStop = false;
            LockedPanel_ExplorerGroupBox.Text = "Explorer";
            // 
            // LockedPanel_ExplorerDescriptionLabel
            // 
            LockedPanel_ExplorerDescriptionLabel.AutoSize = true;
            LockedPanel_ExplorerDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_ExplorerDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_ExplorerDescriptionLabel.Location = new Point(74, 53);
            LockedPanel_ExplorerDescriptionLabel.Name = "LockedPanel_ExplorerDescriptionLabel";
            LockedPanel_ExplorerDescriptionLabel.Size = new Size(213, 21);
            LockedPanel_ExplorerDescriptionLabel.TabIndex = 34;
            LockedPanel_ExplorerDescriptionLabel.Text = "Reveal the file in File Explorer";
            // 
            // LockedPanel_ExplorerButton
            // 
            LockedPanel_ExplorerButton.BackColor = SystemColors.Highlight;
            LockedPanel_ExplorerButton.FlatStyle = FlatStyle.Flat;
            LockedPanel_ExplorerButton.Font = new Font("Segoe UI Emoji", 12F);
            LockedPanel_ExplorerButton.ForeColor = SystemColors.ButtonFace;
            LockedPanel_ExplorerButton.Location = new Point(669, 45);
            LockedPanel_ExplorerButton.Name = "LockedPanel_ExplorerButton";
            LockedPanel_ExplorerButton.Size = new Size(105, 37);
            LockedPanel_ExplorerButton.TabIndex = 6;
            LockedPanel_ExplorerButton.Text = "Explorer 📁";
            LockedPanel_ExplorerButton.UseVisualStyleBackColor = false;
            LockedPanel_ExplorerButton.Click += ShowInExplorerButton_Click;
            // 
            // LockedPanel_ShaClipboardLabel
            // 
            LockedPanel_ShaClipboardLabel.AutoSize = true;
            LockedPanel_ShaClipboardLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_ShaClipboardLabel.Font = new Font("Segoe UI Emoji", 10F);
            LockedPanel_ShaClipboardLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_ShaClipboardLabel.Location = new Point(19, 123);
            LockedPanel_ShaClipboardLabel.Name = "LockedPanel_ShaClipboardLabel";
            LockedPanel_ShaClipboardLabel.Size = new Size(25, 19);
            LockedPanel_ShaClipboardLabel.TabIndex = 44;
            LockedPanel_ShaClipboardLabel.Text = "📋";
            LockedPanel_ShaClipboardLabel.Click += ShaClipboardLabel_Click;
            LockedPanel_ShaClipboardLabel.MouseEnter += Label_MouseEnter;
            LockedPanel_ShaClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // LockedPanel_ExportGroupBox
            // 
            LockedPanel_ExportGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_ExportGroupBox.Controls.Add(LockedPanel_ExportDescriptionLabel);
            LockedPanel_ExportGroupBox.Controls.Add(LockedPanel_ExportButton);
            LockedPanel_ExportGroupBox.FlatStyle = FlatStyle.Flat;
            LockedPanel_ExportGroupBox.ForeColor = SystemColors.ButtonFace;
            LockedPanel_ExportGroupBox.Location = new Point(19, 630);
            LockedPanel_ExportGroupBox.Name = "LockedPanel_ExportGroupBox";
            LockedPanel_ExportGroupBox.Size = new Size(807, 116);
            LockedPanel_ExportGroupBox.TabIndex = 37;
            LockedPanel_ExportGroupBox.TabStop = false;
            LockedPanel_ExportGroupBox.Text = "Export";
            // 
            // LockedPanel_ExportDescriptionLabel
            // 
            LockedPanel_ExportDescriptionLabel.AutoSize = true;
            LockedPanel_ExportDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_ExportDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_ExportDescriptionLabel.Location = new Point(74, 40);
            LockedPanel_ExportDescriptionLabel.Name = "LockedPanel_ExportDescriptionLabel";
            LockedPanel_ExportDescriptionLabel.Size = new Size(259, 42);
            LockedPanel_ExportDescriptionLabel.TabIndex = 34;
            LockedPanel_ExportDescriptionLabel.Text = "Export the file and its cryptographic \r\ndata to a .zip archive";
            // 
            // LockedPanel_ExportButton
            // 
            LockedPanel_ExportButton.BackColor = SystemColors.Highlight;
            LockedPanel_ExportButton.FlatStyle = FlatStyle.Flat;
            LockedPanel_ExportButton.Font = new Font("Segoe UI Emoji", 12F);
            LockedPanel_ExportButton.ForeColor = SystemColors.ButtonFace;
            LockedPanel_ExportButton.Location = new Point(669, 45);
            LockedPanel_ExportButton.Name = "LockedPanel_ExportButton";
            LockedPanel_ExportButton.Size = new Size(105, 37);
            LockedPanel_ExportButton.TabIndex = 6;
            LockedPanel_ExportButton.Text = "Export 📤";
            LockedPanel_ExportButton.UseVisualStyleBackColor = false;
            LockedPanel_ExportButton.Click += ExportButton_Click;
            // 
            // LockedPanel_PathClipboardLabel
            // 
            LockedPanel_PathClipboardLabel.AutoSize = true;
            LockedPanel_PathClipboardLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_PathClipboardLabel.Font = new Font("Segoe UI Emoji", 10F);
            LockedPanel_PathClipboardLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_PathClipboardLabel.Location = new Point(19, 102);
            LockedPanel_PathClipboardLabel.Name = "LockedPanel_PathClipboardLabel";
            LockedPanel_PathClipboardLabel.Size = new Size(25, 19);
            LockedPanel_PathClipboardLabel.TabIndex = 43;
            LockedPanel_PathClipboardLabel.Text = "📋";
            LockedPanel_PathClipboardLabel.Click += PathClipboardLabel_Click;
            LockedPanel_PathClipboardLabel.MouseEnter += Label_MouseEnter;
            LockedPanel_PathClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // LockedPanel_ShredGroupBox
            // 
            LockedPanel_ShredGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_ShredGroupBox.Controls.Add(LockedPanel_ShredDescriptionLabel);
            LockedPanel_ShredGroupBox.Controls.Add(LockedPanel_ShredButton);
            LockedPanel_ShredGroupBox.FlatStyle = FlatStyle.Flat;
            LockedPanel_ShredGroupBox.ForeColor = SystemColors.ButtonFace;
            LockedPanel_ShredGroupBox.Location = new Point(22, 338);
            LockedPanel_ShredGroupBox.Name = "LockedPanel_ShredGroupBox";
            LockedPanel_ShredGroupBox.Size = new Size(807, 116);
            LockedPanel_ShredGroupBox.TabIndex = 36;
            LockedPanel_ShredGroupBox.TabStop = false;
            LockedPanel_ShredGroupBox.Text = "Shred";
            // 
            // LockedPanel_ShredDescriptionLabel
            // 
            LockedPanel_ShredDescriptionLabel.AutoSize = true;
            LockedPanel_ShredDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_ShredDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_ShredDescriptionLabel.Location = new Point(74, 40);
            LockedPanel_ShredDescriptionLabel.Name = "LockedPanel_ShredDescriptionLabel";
            LockedPanel_ShredDescriptionLabel.Size = new Size(233, 42);
            LockedPanel_ShredDescriptionLabel.TabIndex = 34;
            LockedPanel_ShredDescriptionLabel.Text = "Overwrites the file with \r\nrandom data and then deletes it.";
            // 
            // LockedPanel_ShredButton
            // 
            LockedPanel_ShredButton.BackColor = Color.DarkRed;
            LockedPanel_ShredButton.FlatStyle = FlatStyle.Flat;
            LockedPanel_ShredButton.Font = new Font("Segoe UI Emoji", 12F);
            LockedPanel_ShredButton.ForeColor = SystemColors.ButtonFace;
            LockedPanel_ShredButton.Location = new Point(669, 45);
            LockedPanel_ShredButton.Name = "LockedPanel_ShredButton";
            LockedPanel_ShredButton.Size = new Size(105, 37);
            LockedPanel_ShredButton.TabIndex = 6;
            LockedPanel_ShredButton.Text = "Shred 🗑️";
            LockedPanel_ShredButton.UseVisualStyleBackColor = false;
            LockedPanel_ShredButton.Click += ShredButton_Click;
            // 
            // LockedPanel_DecryptGroupBox
            // 
            LockedPanel_DecryptGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_DecryptGroupBox.Controls.Add(LockedPanel_DecryptDescriptionLabel);
            LockedPanel_DecryptGroupBox.Controls.Add(LockedPanel_DecryptButton);
            LockedPanel_DecryptGroupBox.FlatStyle = FlatStyle.Flat;
            LockedPanel_DecryptGroupBox.ForeColor = SystemColors.ButtonFace;
            LockedPanel_DecryptGroupBox.Location = new Point(22, 197);
            LockedPanel_DecryptGroupBox.Name = "LockedPanel_DecryptGroupBox";
            LockedPanel_DecryptGroupBox.Size = new Size(807, 116);
            LockedPanel_DecryptGroupBox.TabIndex = 35;
            LockedPanel_DecryptGroupBox.TabStop = false;
            LockedPanel_DecryptGroupBox.Text = "Decrypt";
            // 
            // LockedPanel_DecryptDescriptionLabel
            // 
            LockedPanel_DecryptDescriptionLabel.AutoSize = true;
            LockedPanel_DecryptDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_DecryptDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_DecryptDescriptionLabel.Location = new Point(74, 42);
            LockedPanel_DecryptDescriptionLabel.Name = "LockedPanel_DecryptDescriptionLabel";
            LockedPanel_DecryptDescriptionLabel.Size = new Size(168, 42);
            LockedPanel_DecryptDescriptionLabel.TabIndex = 33;
            LockedPanel_DecryptDescriptionLabel.Text = "Decrypts the file using \r\nthe input password.";
            // 
            // LockedPanel_DecryptButton
            // 
            LockedPanel_DecryptButton.BackColor = SystemColors.Highlight;
            LockedPanel_DecryptButton.FlatStyle = FlatStyle.Flat;
            LockedPanel_DecryptButton.Font = new Font("Segoe UI Emoji", 12F);
            LockedPanel_DecryptButton.ForeColor = SystemColors.ButtonFace;
            LockedPanel_DecryptButton.Location = new Point(669, 42);
            LockedPanel_DecryptButton.Name = "LockedPanel_DecryptButton";
            LockedPanel_DecryptButton.Size = new Size(105, 37);
            LockedPanel_DecryptButton.TabIndex = 29;
            LockedPanel_DecryptButton.Text = "Decrypt 🔑";
            LockedPanel_DecryptButton.UseVisualStyleBackColor = false;
            LockedPanel_DecryptButton.Click += DecryptButton_Click;
            // 
            // LockedPanel_ShaValueLabel
            // 
            LockedPanel_ShaValueLabel.AutoSize = true;
            LockedPanel_ShaValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_ShaValueLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_ShaValueLabel.Location = new Point(128, 122);
            LockedPanel_ShaValueLabel.Name = "LockedPanel_ShaValueLabel";
            LockedPanel_ShaValueLabel.Size = new Size(56, 21);
            LockedPanel_ShaValueLabel.TabIndex = 34;
            LockedPanel_ShaValueLabel.Text = "<sha>";
            // 
            // LockedPanel_ShaLabel
            // 
            LockedPanel_ShaLabel.AutoSize = true;
            LockedPanel_ShaLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_ShaLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_ShaLabel.Location = new Point(46, 122);
            LockedPanel_ShaLabel.Name = "LockedPanel_ShaLabel";
            LockedPanel_ShaLabel.Size = new Size(43, 21);
            LockedPanel_ShaLabel.TabIndex = 33;
            LockedPanel_ShaLabel.Text = "SHA:";
            // 
            // LockedPanel_SizeValueLabel
            // 
            LockedPanel_SizeValueLabel.AutoSize = true;
            LockedPanel_SizeValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_SizeValueLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_SizeValueLabel.Location = new Point(128, 80);
            LockedPanel_SizeValueLabel.Name = "LockedPanel_SizeValueLabel";
            LockedPanel_SizeValueLabel.Size = new Size(58, 21);
            LockedPanel_SizeValueLabel.TabIndex = 32;
            LockedPanel_SizeValueLabel.Text = "<size>";
            // 
            // LockedPanel_SizeLabel
            // 
            LockedPanel_SizeLabel.AutoSize = true;
            LockedPanel_SizeLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_SizeLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_SizeLabel.Location = new Point(46, 80);
            LockedPanel_SizeLabel.Name = "LockedPanel_SizeLabel";
            LockedPanel_SizeLabel.Size = new Size(41, 21);
            LockedPanel_SizeLabel.TabIndex = 31;
            LockedPanel_SizeLabel.Text = "Size:";
            // 
            // LockedPanel_PathValueLabel
            // 
            LockedPanel_PathValueLabel.AutoSize = true;
            LockedPanel_PathValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_PathValueLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_PathValueLabel.Location = new Point(128, 101);
            LockedPanel_PathValueLabel.Name = "LockedPanel_PathValueLabel";
            LockedPanel_PathValueLabel.Size = new Size(63, 21);
            LockedPanel_PathValueLabel.TabIndex = 30;
            LockedPanel_PathValueLabel.Text = "<path>";
            // 
            // LockedPanel_PathLabel
            // 
            LockedPanel_PathLabel.AutoSize = true;
            LockedPanel_PathLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_PathLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_PathLabel.Location = new Point(46, 101);
            LockedPanel_PathLabel.Name = "LockedPanel_PathLabel";
            LockedPanel_PathLabel.Size = new Size(44, 21);
            LockedPanel_PathLabel.TabIndex = 29;
            LockedPanel_PathLabel.Text = "Path:";
            // 
            // LockedPanel_AlgorithmValueLabel
            // 
            LockedPanel_AlgorithmValueLabel.AutoSize = true;
            LockedPanel_AlgorithmValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_AlgorithmValueLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_AlgorithmValueLabel.Location = new Point(128, 143);
            LockedPanel_AlgorithmValueLabel.Name = "LockedPanel_AlgorithmValueLabel";
            LockedPanel_AlgorithmValueLabel.Size = new Size(100, 21);
            LockedPanel_AlgorithmValueLabel.TabIndex = 26;
            LockedPanel_AlgorithmValueLabel.Text = "<algorithm>";
            // 
            // LockedPanel_AlgorithmLabel
            // 
            LockedPanel_AlgorithmLabel.AutoSize = true;
            LockedPanel_AlgorithmLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_AlgorithmLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_AlgorithmLabel.Location = new Point(46, 143);
            LockedPanel_AlgorithmLabel.Name = "LockedPanel_AlgorithmLabel";
            LockedPanel_AlgorithmLabel.Size = new Size(83, 21);
            LockedPanel_AlgorithmLabel.TabIndex = 25;
            LockedPanel_AlgorithmLabel.Text = "Algorithm:";
            // 
            // LockedPanel_StatusValueLabel
            // 
            LockedPanel_StatusValueLabel.AutoSize = true;
            LockedPanel_StatusValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_StatusValueLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_StatusValueLabel.Location = new Point(128, 59);
            LockedPanel_StatusValueLabel.Name = "LockedPanel_StatusValueLabel";
            LockedPanel_StatusValueLabel.Size = new Size(59, 21);
            LockedPanel_StatusValueLabel.TabIndex = 24;
            LockedPanel_StatusValueLabel.Text = "Locked";
            // 
            // LockedPanel_StatusLabel
            // 
            LockedPanel_StatusLabel.AutoSize = true;
            LockedPanel_StatusLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_StatusLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_StatusLabel.Location = new Point(46, 59);
            LockedPanel_StatusLabel.Name = "LockedPanel_StatusLabel";
            LockedPanel_StatusLabel.Size = new Size(56, 21);
            LockedPanel_StatusLabel.TabIndex = 23;
            LockedPanel_StatusLabel.Text = "Status:";
            // 
            // LockedPanel_FileNameLabel
            // 
            LockedPanel_FileNameLabel.AutoSize = true;
            LockedPanel_FileNameLabel.Font = new Font("Segoe UI Emoji", 20.25F);
            LockedPanel_FileNameLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_FileNameLabel.Location = new Point(46, 17);
            LockedPanel_FileNameLabel.Name = "LockedPanel_FileNameLabel";
            LockedPanel_FileNameLabel.Size = new Size(153, 36);
            LockedPanel_FileNameLabel.TabIndex = 8;
            LockedPanel_FileNameLabel.Text = "<filename>";
            // 
            // RelocationPanel
            // 
            RelocationPanel.BackColor = Color.FromArgb(32, 32, 32);
            RelocationPanel.BorderStyle = BorderStyle.FixedSingle;
            RelocationPanel.Controls.Add(RelocationPanel_RemoveButton);
            RelocationPanel.Controls.Add(RelocationPanel_RelocateButton);
            RelocationPanel.Controls.Add(RelocationPanel_LastSeenLabel);
            RelocationPanel.Controls.Add(RelocationPanel_CantLocateFileLabel);
            RelocationPanel.Location = new Point(361, 31);
            RelocationPanel.Name = "RelocationPanel";
            RelocationPanel.Size = new Size(864, 921);
            RelocationPanel.TabIndex = 35;
            // 
            // RelocationPanel_RemoveButton
            // 
            RelocationPanel_RemoveButton.BackColor = SystemColors.Highlight;
            RelocationPanel_RemoveButton.FlatStyle = FlatStyle.Flat;
            RelocationPanel_RemoveButton.Font = new Font("Segoe UI Emoji", 12F);
            RelocationPanel_RemoveButton.ForeColor = SystemColors.ButtonFace;
            RelocationPanel_RemoveButton.Location = new Point(434, 460);
            RelocationPanel_RemoveButton.Name = "RelocationPanel_RemoveButton";
            RelocationPanel_RemoveButton.Size = new Size(83, 37);
            RelocationPanel_RemoveButton.TabIndex = 20;
            RelocationPanel_RemoveButton.Text = "Remove";
            RelocationPanel_RemoveButton.UseVisualStyleBackColor = false;
            RelocationPanel_RemoveButton.Click += RemoveButton_Click;
            // 
            // RelocationPanel_RelocateButton
            // 
            RelocationPanel_RelocateButton.BackColor = SystemColors.Highlight;
            RelocationPanel_RelocateButton.FlatStyle = FlatStyle.Flat;
            RelocationPanel_RelocateButton.Font = new Font("Segoe UI Emoji", 12F);
            RelocationPanel_RelocateButton.ForeColor = SystemColors.ButtonFace;
            RelocationPanel_RelocateButton.Location = new Point(345, 460);
            RelocationPanel_RelocateButton.Name = "RelocationPanel_RelocateButton";
            RelocationPanel_RelocateButton.Size = new Size(83, 37);
            RelocationPanel_RelocateButton.TabIndex = 19;
            RelocationPanel_RelocateButton.Text = "Relocate";
            RelocationPanel_RelocateButton.UseVisualStyleBackColor = false;
            RelocationPanel_RelocateButton.Click += RelocateButton_Click;
            // 
            // RelocationPanel_LastSeenLabel
            // 
            RelocationPanel_LastSeenLabel.AutoSize = true;
            RelocationPanel_LastSeenLabel.Font = new Font("Segoe UI Emoji", 12F);
            RelocationPanel_LastSeenLabel.ForeColor = SystemColors.AppWorkspace;
            RelocationPanel_LastSeenLabel.Location = new Point(344, 415);
            RelocationPanel_LastSeenLabel.Name = "RelocationPanel_LastSeenLabel";
            RelocationPanel_LastSeenLabel.Size = new Size(191, 21);
            RelocationPanel_LastSeenLabel.TabIndex = 18;
            RelocationPanel_LastSeenLabel.Text = "It was last seen at <path>.";
            RelocationPanel_LastSeenLabel.TextChanged += CenterLabel_TextChanged;
            // 
            // RelocationPanel_CantLocateFileLabel
            // 
            RelocationPanel_CantLocateFileLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RelocationPanel_CantLocateFileLabel.AutoSize = true;
            RelocationPanel_CantLocateFileLabel.Font = new Font("Segoe UI Emoji", 20.25F);
            RelocationPanel_CantLocateFileLabel.ForeColor = SystemColors.ButtonFace;
            RelocationPanel_CantLocateFileLabel.Location = new Point(320, 379);
            RelocationPanel_CantLocateFileLabel.Name = "RelocationPanel_CantLocateFileLabel";
            RelocationPanel_CantLocateFileLabel.Size = new Size(238, 36);
            RelocationPanel_CantLocateFileLabel.TabIndex = 17;
            RelocationPanel_CantLocateFileLabel.Text = "Can't locate \"path\"";
            RelocationPanel_CantLocateFileLabel.TextChanged += CenterLabel_TextChanged;
            // 
            // UnlockedPanel
            // 
            UnlockedPanel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel.BorderStyle = BorderStyle.FixedSingle;
            UnlockedPanel.Controls.Add(UnlockedPanel_ExplorerGroupBox);
            UnlockedPanel.Controls.Add(UnlockedPanel_ShaClipboardLabel);
            UnlockedPanel.Controls.Add(UnlockedPanel_PathClipboardLabel);
            UnlockedPanel.Controls.Add(UnlockedPanel_ShredGroupBox);
            UnlockedPanel.Controls.Add(UnlockedPanel_EncryptGroupBox);
            UnlockedPanel.Controls.Add(UnlockedPanel_ShaValueLabel);
            UnlockedPanel.Controls.Add(UnlockedPanel_ShaLabel);
            UnlockedPanel.Controls.Add(UnlockedPanel_SizeValueLabel);
            UnlockedPanel.Controls.Add(UnlockedPanel_SizeLabel);
            UnlockedPanel.Controls.Add(UnlockedPanel_PathValueLabel);
            UnlockedPanel.Controls.Add(UnlockedPanel_PathLabel);
            UnlockedPanel.Controls.Add(UnlockedPanel_StatusValueLabel);
            UnlockedPanel.Controls.Add(UnlockedPanel_StatusLabel);
            UnlockedPanel.Controls.Add(UnlockedPanel_FileNameLabel);
            UnlockedPanel.Location = new Point(361, 31);
            UnlockedPanel.Name = "UnlockedPanel";
            UnlockedPanel.Size = new Size(864, 921);
            UnlockedPanel.TabIndex = 35;
            // 
            // UnlockedPanel_ExplorerGroupBox
            // 
            UnlockedPanel_ExplorerGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_ExplorerGroupBox.Controls.Add(UnlockedPanel_ExplorerDescriptionLabel);
            UnlockedPanel_ExplorerGroupBox.Controls.Add(UnlockedPanel_ExplorerButton);
            UnlockedPanel_ExplorerGroupBox.FlatStyle = FlatStyle.Flat;
            UnlockedPanel_ExplorerGroupBox.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_ExplorerGroupBox.Location = new Point(22, 480);
            UnlockedPanel_ExplorerGroupBox.Name = "UnlockedPanel_ExplorerGroupBox";
            UnlockedPanel_ExplorerGroupBox.Size = new Size(807, 116);
            UnlockedPanel_ExplorerGroupBox.TabIndex = 35;
            UnlockedPanel_ExplorerGroupBox.TabStop = false;
            UnlockedPanel_ExplorerGroupBox.Text = "Explorer";
            // 
            // UnlockedPanel_ExplorerDescriptionLabel
            // 
            UnlockedPanel_ExplorerDescriptionLabel.AutoSize = true;
            UnlockedPanel_ExplorerDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_ExplorerDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_ExplorerDescriptionLabel.Location = new Point(74, 53);
            UnlockedPanel_ExplorerDescriptionLabel.Name = "UnlockedPanel_ExplorerDescriptionLabel";
            UnlockedPanel_ExplorerDescriptionLabel.Size = new Size(213, 21);
            UnlockedPanel_ExplorerDescriptionLabel.TabIndex = 34;
            UnlockedPanel_ExplorerDescriptionLabel.Text = "Reveal the file in File Explorer";
            // 
            // UnlockedPanel_ExplorerButton
            // 
            UnlockedPanel_ExplorerButton.BackColor = SystemColors.Highlight;
            UnlockedPanel_ExplorerButton.FlatStyle = FlatStyle.Flat;
            UnlockedPanel_ExplorerButton.Font = new Font("Segoe UI Emoji", 12F);
            UnlockedPanel_ExplorerButton.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_ExplorerButton.Location = new Point(669, 45);
            UnlockedPanel_ExplorerButton.Name = "UnlockedPanel_ExplorerButton";
            UnlockedPanel_ExplorerButton.Size = new Size(105, 37);
            UnlockedPanel_ExplorerButton.TabIndex = 6;
            UnlockedPanel_ExplorerButton.Text = "Explorer 📁";
            UnlockedPanel_ExplorerButton.UseVisualStyleBackColor = false;
            UnlockedPanel_ExplorerButton.Click += ShowInExplorerButton_Click;
            // 
            // UnlockedPanel_ShaClipboardLabel
            // 
            UnlockedPanel_ShaClipboardLabel.AutoSize = true;
            UnlockedPanel_ShaClipboardLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_ShaClipboardLabel.Font = new Font("Segoe UI Emoji", 10F);
            UnlockedPanel_ShaClipboardLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_ShaClipboardLabel.Location = new Point(19, 123);
            UnlockedPanel_ShaClipboardLabel.Name = "UnlockedPanel_ShaClipboardLabel";
            UnlockedPanel_ShaClipboardLabel.Size = new Size(25, 19);
            UnlockedPanel_ShaClipboardLabel.TabIndex = 42;
            UnlockedPanel_ShaClipboardLabel.Text = "📋";
            UnlockedPanel_ShaClipboardLabel.Click += ShaClipboardLabel_Click;
            UnlockedPanel_ShaClipboardLabel.MouseEnter += Label_MouseEnter;
            UnlockedPanel_ShaClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // UnlockedPanel_PathClipboardLabel
            // 
            UnlockedPanel_PathClipboardLabel.AutoSize = true;
            UnlockedPanel_PathClipboardLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_PathClipboardLabel.Font = new Font("Segoe UI Emoji", 10F);
            UnlockedPanel_PathClipboardLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_PathClipboardLabel.Location = new Point(19, 102);
            UnlockedPanel_PathClipboardLabel.Name = "UnlockedPanel_PathClipboardLabel";
            UnlockedPanel_PathClipboardLabel.Size = new Size(25, 19);
            UnlockedPanel_PathClipboardLabel.TabIndex = 41;
            UnlockedPanel_PathClipboardLabel.Text = "📋";
            UnlockedPanel_PathClipboardLabel.Click += PathClipboardLabel_Click;
            UnlockedPanel_PathClipboardLabel.MouseEnter += Label_MouseEnter;
            UnlockedPanel_PathClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // UnlockedPanel_ShredGroupBox
            // 
            UnlockedPanel_ShredGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_ShredGroupBox.Controls.Add(UnlockedPanel_ShredDescriptionLabel);
            UnlockedPanel_ShredGroupBox.Controls.Add(UnlockedPanel_ShredButton);
            UnlockedPanel_ShredGroupBox.FlatStyle = FlatStyle.Flat;
            UnlockedPanel_ShredGroupBox.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_ShredGroupBox.Location = new Point(22, 338);
            UnlockedPanel_ShredGroupBox.Name = "UnlockedPanel_ShredGroupBox";
            UnlockedPanel_ShredGroupBox.Size = new Size(807, 116);
            UnlockedPanel_ShredGroupBox.TabIndex = 32;
            UnlockedPanel_ShredGroupBox.TabStop = false;
            UnlockedPanel_ShredGroupBox.Text = "Shred";
            // 
            // UnlockedPanel_ShredDescriptionLabel
            // 
            UnlockedPanel_ShredDescriptionLabel.AutoSize = true;
            UnlockedPanel_ShredDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_ShredDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_ShredDescriptionLabel.Location = new Point(74, 40);
            UnlockedPanel_ShredDescriptionLabel.Name = "UnlockedPanel_ShredDescriptionLabel";
            UnlockedPanel_ShredDescriptionLabel.Size = new Size(233, 42);
            UnlockedPanel_ShredDescriptionLabel.TabIndex = 34;
            UnlockedPanel_ShredDescriptionLabel.Text = "Overwrites the file with \r\nrandom data and then deletes it.";
            // 
            // UnlockedPanel_ShredButton
            // 
            UnlockedPanel_ShredButton.BackColor = Color.DarkRed;
            UnlockedPanel_ShredButton.FlatStyle = FlatStyle.Flat;
            UnlockedPanel_ShredButton.Font = new Font("Segoe UI Emoji", 12F);
            UnlockedPanel_ShredButton.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_ShredButton.Location = new Point(669, 45);
            UnlockedPanel_ShredButton.Name = "UnlockedPanel_ShredButton";
            UnlockedPanel_ShredButton.Size = new Size(105, 37);
            UnlockedPanel_ShredButton.TabIndex = 6;
            UnlockedPanel_ShredButton.Text = "Shred 🗑️";
            UnlockedPanel_ShredButton.UseVisualStyleBackColor = false;
            UnlockedPanel_ShredButton.Click += ShredButton_Click;
            // 
            // UnlockedPanel_EncryptGroupBox
            // 
            UnlockedPanel_EncryptGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_EncryptGroupBox.Controls.Add(UnlockedPanel_EncryptDescriptionLabel);
            UnlockedPanel_EncryptGroupBox.Controls.Add(UnlockedPanel_EncryptButton);
            UnlockedPanel_EncryptGroupBox.FlatStyle = FlatStyle.Flat;
            UnlockedPanel_EncryptGroupBox.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_EncryptGroupBox.Location = new Point(22, 197);
            UnlockedPanel_EncryptGroupBox.Name = "UnlockedPanel_EncryptGroupBox";
            UnlockedPanel_EncryptGroupBox.Size = new Size(807, 116);
            UnlockedPanel_EncryptGroupBox.TabIndex = 31;
            UnlockedPanel_EncryptGroupBox.TabStop = false;
            UnlockedPanel_EncryptGroupBox.Text = "Encrypt";
            // 
            // UnlockedPanel_EncryptDescriptionLabel
            // 
            UnlockedPanel_EncryptDescriptionLabel.AutoSize = true;
            UnlockedPanel_EncryptDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_EncryptDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_EncryptDescriptionLabel.Location = new Point(74, 27);
            UnlockedPanel_EncryptDescriptionLabel.Name = "UnlockedPanel_EncryptDescriptionLabel";
            UnlockedPanel_EncryptDescriptionLabel.Size = new Size(184, 63);
            UnlockedPanel_EncryptDescriptionLabel.TabIndex = 33;
            UnlockedPanel_EncryptDescriptionLabel.Text = "Encrypts the file with the \r\nselected algorithm using \r\nthe input password.";
            // 
            // UnlockedPanel_EncryptButton
            // 
            UnlockedPanel_EncryptButton.BackColor = SystemColors.Highlight;
            UnlockedPanel_EncryptButton.FlatStyle = FlatStyle.Flat;
            UnlockedPanel_EncryptButton.Font = new Font("Segoe UI Emoji", 12F);
            UnlockedPanel_EncryptButton.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_EncryptButton.Location = new Point(669, 42);
            UnlockedPanel_EncryptButton.Name = "UnlockedPanel_EncryptButton";
            UnlockedPanel_EncryptButton.Size = new Size(105, 37);
            UnlockedPanel_EncryptButton.TabIndex = 29;
            UnlockedPanel_EncryptButton.Text = "Encrypt 🔐";
            UnlockedPanel_EncryptButton.UseVisualStyleBackColor = false;
            UnlockedPanel_EncryptButton.Click += EncryptButton_Click;
            // 
            // UnlockedPanel_ShaValueLabel
            // 
            UnlockedPanel_ShaValueLabel.AutoSize = true;
            UnlockedPanel_ShaValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_ShaValueLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_ShaValueLabel.Location = new Point(128, 122);
            UnlockedPanel_ShaValueLabel.Name = "UnlockedPanel_ShaValueLabel";
            UnlockedPanel_ShaValueLabel.Size = new Size(56, 21);
            UnlockedPanel_ShaValueLabel.TabIndex = 30;
            UnlockedPanel_ShaValueLabel.Text = "<sha>";
            // 
            // UnlockedPanel_ShaLabel
            // 
            UnlockedPanel_ShaLabel.AutoSize = true;
            UnlockedPanel_ShaLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_ShaLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_ShaLabel.Location = new Point(46, 122);
            UnlockedPanel_ShaLabel.Name = "UnlockedPanel_ShaLabel";
            UnlockedPanel_ShaLabel.Size = new Size(43, 21);
            UnlockedPanel_ShaLabel.TabIndex = 29;
            UnlockedPanel_ShaLabel.Text = "SHA:";
            // 
            // UnlockedPanel_SizeValueLabel
            // 
            UnlockedPanel_SizeValueLabel.AutoSize = true;
            UnlockedPanel_SizeValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_SizeValueLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_SizeValueLabel.Location = new Point(128, 80);
            UnlockedPanel_SizeValueLabel.Name = "UnlockedPanel_SizeValueLabel";
            UnlockedPanel_SizeValueLabel.Size = new Size(58, 21);
            UnlockedPanel_SizeValueLabel.TabIndex = 28;
            UnlockedPanel_SizeValueLabel.Text = "<size>";
            // 
            // UnlockedPanel_SizeLabel
            // 
            UnlockedPanel_SizeLabel.AutoSize = true;
            UnlockedPanel_SizeLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_SizeLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_SizeLabel.Location = new Point(46, 80);
            UnlockedPanel_SizeLabel.Name = "UnlockedPanel_SizeLabel";
            UnlockedPanel_SizeLabel.Size = new Size(41, 21);
            UnlockedPanel_SizeLabel.TabIndex = 27;
            UnlockedPanel_SizeLabel.Text = "Size:";
            // 
            // UnlockedPanel_PathValueLabel
            // 
            UnlockedPanel_PathValueLabel.AutoSize = true;
            UnlockedPanel_PathValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_PathValueLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_PathValueLabel.Location = new Point(128, 101);
            UnlockedPanel_PathValueLabel.Name = "UnlockedPanel_PathValueLabel";
            UnlockedPanel_PathValueLabel.Size = new Size(63, 21);
            UnlockedPanel_PathValueLabel.TabIndex = 26;
            UnlockedPanel_PathValueLabel.Text = "<path>";
            // 
            // UnlockedPanel_PathLabel
            // 
            UnlockedPanel_PathLabel.AutoSize = true;
            UnlockedPanel_PathLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_PathLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_PathLabel.Location = new Point(46, 101);
            UnlockedPanel_PathLabel.Name = "UnlockedPanel_PathLabel";
            UnlockedPanel_PathLabel.Size = new Size(44, 21);
            UnlockedPanel_PathLabel.TabIndex = 25;
            UnlockedPanel_PathLabel.Text = "Path:";
            // 
            // UnlockedPanel_StatusValueLabel
            // 
            UnlockedPanel_StatusValueLabel.AutoSize = true;
            UnlockedPanel_StatusValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_StatusValueLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_StatusValueLabel.Location = new Point(128, 59);
            UnlockedPanel_StatusValueLabel.Name = "UnlockedPanel_StatusValueLabel";
            UnlockedPanel_StatusValueLabel.Size = new Size(75, 21);
            UnlockedPanel_StatusValueLabel.TabIndex = 24;
            UnlockedPanel_StatusValueLabel.Text = "Unlocked";
            // 
            // UnlockedPanel_StatusLabel
            // 
            UnlockedPanel_StatusLabel.AutoSize = true;
            UnlockedPanel_StatusLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_StatusLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_StatusLabel.Location = new Point(46, 59);
            UnlockedPanel_StatusLabel.Name = "UnlockedPanel_StatusLabel";
            UnlockedPanel_StatusLabel.Size = new Size(56, 21);
            UnlockedPanel_StatusLabel.TabIndex = 23;
            UnlockedPanel_StatusLabel.Text = "Status:";
            // 
            // UnlockedPanel_FileNameLabel
            // 
            UnlockedPanel_FileNameLabel.AutoSize = true;
            UnlockedPanel_FileNameLabel.Font = new Font("Segoe UI Emoji", 20.25F);
            UnlockedPanel_FileNameLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_FileNameLabel.Location = new Point(46, 17);
            UnlockedPanel_FileNameLabel.Name = "UnlockedPanel_FileNameLabel";
            UnlockedPanel_FileNameLabel.Size = new Size(153, 36);
            UnlockedPanel_FileNameLabel.TabIndex = 8;
            UnlockedPanel_FileNameLabel.Text = "<filename>";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1217, 950);
            Controls.Add(AddButton);
            Controls.Add(MagnifyingGlassLabel);
            Controls.Add(SearchTextBox);
            Controls.Add(FileListBox);
            Controls.Add(MenuStrip);
            Controls.Add(RelocationPanel);
            Controls.Add(LockedPanel);
            Controls.Add(UnlockedPanel);
            Controls.Add(NoFilesPanel);
            Font = new Font("Segoe UI Emoji", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FileLocker";
            FileListBoxContextMenuStrip.ResumeLayout(false);
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            AddButtonContextMenuStrip.ResumeLayout(false);
            NoFilesPanel.ResumeLayout(false);
            NoFilesPanel.PerformLayout();
            LockedPanel.ResumeLayout(false);
            LockedPanel.PerformLayout();
            LockedPanel_ExplorerGroupBox.ResumeLayout(false);
            LockedPanel_ExplorerGroupBox.PerformLayout();
            LockedPanel_ExportGroupBox.ResumeLayout(false);
            LockedPanel_ExportGroupBox.PerformLayout();
            LockedPanel_ShredGroupBox.ResumeLayout(false);
            LockedPanel_ShredGroupBox.PerformLayout();
            LockedPanel_DecryptGroupBox.ResumeLayout(false);
            LockedPanel_DecryptGroupBox.PerformLayout();
            RelocationPanel.ResumeLayout(false);
            RelocationPanel.PerformLayout();
            UnlockedPanel.ResumeLayout(false);
            UnlockedPanel.PerformLayout();
            UnlockedPanel_ExplorerGroupBox.ResumeLayout(false);
            UnlockedPanel_ExplorerGroupBox.PerformLayout();
            UnlockedPanel_ShredGroupBox.ResumeLayout(false);
            UnlockedPanel_ShredGroupBox.PerformLayout();
            UnlockedPanel_EncryptGroupBox.ResumeLayout(false);
            UnlockedPanel_EncryptGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label NoFilesPanel_NoFilesLabel;
        private Button UnlockedPanel_ShredButton;
        private Button LockedPanel_DecryptButton;
        private ListBox FileListBox;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem GuideMenuItem;
        private TextBox SearchTextBox;
        private Label MagnifyingGlassLabel;
        private Button AddButton;
        private Panel NoFilesPanel;
        private Label NoFilesPanel_NoFilesDescriptionLabel;
        private ToolStripMenuItem SettingsMenuItem;
        private ToolStripMenuItem DiagnosticsMenuItem;
        private ContextMenuStrip AddButtonContextMenuStrip;
        private ToolStripMenuItem AddExistingFilesToolStripMenuItem;
        private ToolStripMenuItem ImportArchiveToolStripMenuItem;
        private Panel LockedPanel;
        private Label LockedPanel_StatusLabel;
        private Label LockedPanel_FileNameLabel;
        private Label LockedPanel_StatusValueLabel;
        private Label LockedPanel_ShaValueLabel;
        private Label LockedPanel_ShaLabel;
        private Label LockedPanel_SizeValueLabel;
        private Label LockedPanel_SizeLabel;
        private Label LockedPanel_PathValueLabel;
        private Label LockedPanel_PathLabel;
        private Label LockedPanel_AlgorithmValueLabel;
        private Label LockedPanel_AlgorithmLabel;
        private Panel RelocationPanel;
        private Label RelocationPanel_LastSeenLabel;
        private Label RelocationPanel_CantLocateFileLabel;
        private Button RelocationPanel_RemoveButton;
        private Button RelocationPanel_RelocateButton;
        private Panel UnlockedPanel;
        private Label UnlockedPanel_ShaValueLabel;
        private Label UnlockedPanel_ShaLabel;
        private Label UnlockedPanel_SizeValueLabel;
        private Label UnlockedPanel_SizeLabel;
        private Label UnlockedPanel_PathValueLabel;
        private Label UnlockedPanel_PathLabel;
        private Label UnlockedPanel_StatusValueLabel;
        private Label UnlockedPanel_StatusLabel;
        private Label UnlockedPanel_FileNameLabel;
        private GroupBox UnlockedPanel_ShredGroupBox;
        private Button ClearButton;
        private Label PasswordWarningLabel;
        private ComboBox EncryptionAlgorithmComboBox;
        private Label ChooseAlgorithmLabel;
        private Button UnlockedPanel_EncryptButton;
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
        private Label UnlockedPanel_EncryptDescriptionLabel;
        private Label UnlockedPanel_ShredDescriptionLabel;
        private GroupBox UnlockedPanel_EncryptGroupBox;
        private ContextMenuStrip FileListBoxContextMenuStrip;
        private ToolStripMenuItem RemoveFromListItem;
        private GroupBox LockedPanel_ShredGroupBox;
        private Label LockedPanel_ShredDescriptionLabel;
        private Button LockedPanel_ShredButton;
        private GroupBox LockedPanel_DecryptGroupBox;
        private Label LockedPanel_DecryptDescriptionLabel;
        private GroupBox LockedPanel_ExportGroupBox;
        private Label LockedPanel_ExportDescriptionLabel;
        private Button LockedPanel_ExportButton;
        private Label UnlockedPanel_PathClipboardLabel;
        private Label UnlockedPanel_ShaClipboardLabel;
        private Label LockedPanel_ShaClipboardLabel;
        private Label LockedPanel_PathClipboardLabel;
        private GroupBox UnlockedPanel_ExplorerGroupBox;
        private Label UnlockedPanel_ExplorerDescriptionLabel;
        private Button UnlockedPanel_ExplorerButton;
        private GroupBox LockedPanel_ExplorerGroupBox;
        private Label LockedPanel_ExplorerDescriptionLabel;
        private Button LockedPanel_ExplorerButton;
    }
}
