namespace WinFormsUI_2
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
            NoFilesDescriptionLabel = new Label();
            NoFilesLabel = new Label();
            LockedFilePanel = new Panel();
            LockedShredGroupBox = new GroupBox();
            LockedShredDescriptionLabel = new Label();
            LockedShredButton = new Button();
            DecryptGroupBox = new GroupBox();
            DecryptDescriptionLabel = new Label();
            DecryptButton = new Button();
            LockedShaValueLabel = new Label();
            LockedShaLabel = new Label();
            LockedSizeValueLabel = new Label();
            LockedSizeLabel = new Label();
            LockedPathValueLabel = new Label();
            LockedPathLabel = new Label();
            LockDateValueLabel = new Label();
            LockDateLabel = new Label();
            AlgorithmValueLabel = new Label();
            AlgorithmLabel = new Label();
            LockedStatusValueLabel = new Label();
            LockedStatusLabel = new Label();
            LockedFileNameLabel = new Label();
            RelocationPanel = new Panel();
            RemoveButton = new Button();
            RelocateButton = new Button();
            LastSeenLabel = new Label();
            CantLocateFileLabel = new Label();
            UnlockedFilePanel = new Panel();
            UnlockedShredGroupBox = new GroupBox();
            UnlockedShredDescriptionLabel = new Label();
            UnlockedShredButton = new Button();
            EncryptGroupBox = new GroupBox();
            EncryptDescriptionLabel = new Label();
            EncryptButton = new Button();
            UnlockedShaValueLabel = new Label();
            UnlockedShaLabel = new Label();
            UnlockedSizeValueLabel = new Label();
            UnlockedSizeLabel = new Label();
            UnlockedPathValueLabel = new Label();
            UnlockedPathLabel = new Label();
            UnlockedStatusValueLabel = new Label();
            UnlockedStatusLabel = new Label();
            UnlockedFileNameLabel = new Label();
            FileListBoxContextMenuStrip.SuspendLayout();
            MenuStrip.SuspendLayout();
            AddButtonContextMenuStrip.SuspendLayout();
            NoFilesPanel.SuspendLayout();
            LockedFilePanel.SuspendLayout();
            LockedShredGroupBox.SuspendLayout();
            DecryptGroupBox.SuspendLayout();
            RelocationPanel.SuspendLayout();
            UnlockedFilePanel.SuspendLayout();
            UnlockedShredGroupBox.SuspendLayout();
            EncryptGroupBox.SuspendLayout();
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
            FileListBox.ItemHeight = 20;
            FileListBox.Location = new Point(0, 66);
            FileListBox.Name = "FileListBox";
            FileListBox.Size = new Size(361, 880);
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
            AddButton.Text = "Add ▼";
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
            NoFilesPanel.Controls.Add(NoFilesDescriptionLabel);
            NoFilesPanel.Controls.Add(NoFilesLabel);
            NoFilesPanel.Location = new Point(361, 31);
            NoFilesPanel.Name = "NoFilesPanel";
            NoFilesPanel.Size = new Size(864, 921);
            NoFilesPanel.TabIndex = 22;
            // 
            // NoFilesDescriptionLabel
            // 
            NoFilesDescriptionLabel.AutoSize = true;
            NoFilesDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            NoFilesDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            NoFilesDescriptionLabel.Location = new Point(316, 426);
            NoFilesDescriptionLabel.Name = "NoFilesDescriptionLabel";
            NoFilesDescriptionLabel.Size = new Size(274, 42);
            NoFilesDescriptionLabel.TabIndex = 23;
            NoFilesDescriptionLabel.Text = "Click Add to import or manually select\r\n files to add to FileLocker's scope.";
            NoFilesDescriptionLabel.Click += NoFilesDescriptionLabel_Click;
            // 
            // NoFilesLabel
            // 
            NoFilesLabel.AutoSize = true;
            NoFilesLabel.Font = new Font("Segoe UI Emoji", 20.25F);
            NoFilesLabel.ForeColor = SystemColors.ButtonFace;
            NoFilesLabel.Location = new Point(401, 378);
            NoFilesLabel.Name = "NoFilesLabel";
            NoFilesLabel.Size = new Size(105, 36);
            NoFilesLabel.TabIndex = 8;
            NoFilesLabel.Text = "No files";
            // 
            // LockedFilePanel
            // 
            LockedFilePanel.BackColor = Color.FromArgb(32, 32, 32);
            LockedFilePanel.BorderStyle = BorderStyle.FixedSingle;
            LockedFilePanel.Controls.Add(LockedShredGroupBox);
            LockedFilePanel.Controls.Add(DecryptGroupBox);
            LockedFilePanel.Controls.Add(LockedShaValueLabel);
            LockedFilePanel.Controls.Add(LockedShaLabel);
            LockedFilePanel.Controls.Add(LockedSizeValueLabel);
            LockedFilePanel.Controls.Add(LockedSizeLabel);
            LockedFilePanel.Controls.Add(LockedPathValueLabel);
            LockedFilePanel.Controls.Add(LockedPathLabel);
            LockedFilePanel.Controls.Add(LockDateValueLabel);
            LockedFilePanel.Controls.Add(LockDateLabel);
            LockedFilePanel.Controls.Add(AlgorithmValueLabel);
            LockedFilePanel.Controls.Add(AlgorithmLabel);
            LockedFilePanel.Controls.Add(LockedStatusValueLabel);
            LockedFilePanel.Controls.Add(LockedStatusLabel);
            LockedFilePanel.Controls.Add(LockedFileNameLabel);
            LockedFilePanel.Location = new Point(361, 31);
            LockedFilePanel.Name = "LockedFilePanel";
            LockedFilePanel.Size = new Size(864, 921);
            LockedFilePanel.TabIndex = 24;
            // 
            // LockedShredGroupBox
            // 
            LockedShredGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            LockedShredGroupBox.Controls.Add(LockedShredDescriptionLabel);
            LockedShredGroupBox.Controls.Add(LockedShredButton);
            LockedShredGroupBox.FlatStyle = FlatStyle.Flat;
            LockedShredGroupBox.ForeColor = SystemColors.ButtonFace;
            LockedShredGroupBox.Location = new Point(22, 338);
            LockedShredGroupBox.Name = "LockedShredGroupBox";
            LockedShredGroupBox.Size = new Size(807, 116);
            LockedShredGroupBox.TabIndex = 36;
            LockedShredGroupBox.TabStop = false;
            LockedShredGroupBox.Text = "Shred";
            // 
            // LockedShredDescriptionLabel
            // 
            LockedShredDescriptionLabel.AutoSize = true;
            LockedShredDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedShredDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            LockedShredDescriptionLabel.Location = new Point(74, 40);
            LockedShredDescriptionLabel.Name = "LockedShredDescriptionLabel";
            LockedShredDescriptionLabel.Size = new Size(233, 42);
            LockedShredDescriptionLabel.TabIndex = 34;
            LockedShredDescriptionLabel.Text = "Overwrites the file with \r\nrandom data and then deletes it.";
            // 
            // LockedShredButton
            // 
            LockedShredButton.BackColor = Color.DarkRed;
            LockedShredButton.FlatStyle = FlatStyle.Flat;
            LockedShredButton.Font = new Font("Segoe UI Emoji", 12F);
            LockedShredButton.ForeColor = SystemColors.ButtonFace;
            LockedShredButton.Location = new Point(669, 45);
            LockedShredButton.Name = "LockedShredButton";
            LockedShredButton.Size = new Size(100, 37);
            LockedShredButton.TabIndex = 6;
            LockedShredButton.Text = "Shred 🗑️";
            LockedShredButton.UseVisualStyleBackColor = false;
            // 
            // DecryptGroupBox
            // 
            DecryptGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            DecryptGroupBox.Controls.Add(DecryptDescriptionLabel);
            DecryptGroupBox.Controls.Add(DecryptButton);
            DecryptGroupBox.FlatStyle = FlatStyle.Flat;
            DecryptGroupBox.ForeColor = SystemColors.ButtonFace;
            DecryptGroupBox.Location = new Point(22, 197);
            DecryptGroupBox.Name = "DecryptGroupBox";
            DecryptGroupBox.Size = new Size(807, 116);
            DecryptGroupBox.TabIndex = 35;
            DecryptGroupBox.TabStop = false;
            DecryptGroupBox.Text = "Decrypt";
            // 
            // DecryptDescriptionLabel
            // 
            DecryptDescriptionLabel.AutoSize = true;
            DecryptDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            DecryptDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            DecryptDescriptionLabel.Location = new Point(62, 42);
            DecryptDescriptionLabel.Name = "DecryptDescriptionLabel";
            DecryptDescriptionLabel.Size = new Size(168, 42);
            DecryptDescriptionLabel.TabIndex = 33;
            DecryptDescriptionLabel.Text = "Decrypts the file using \r\nthe input password.";
            // 
            // DecryptButton
            // 
            DecryptButton.BackColor = SystemColors.Highlight;
            DecryptButton.FlatStyle = FlatStyle.Flat;
            DecryptButton.Font = new Font("Segoe UI Emoji", 12F);
            DecryptButton.ForeColor = SystemColors.ButtonFace;
            DecryptButton.Location = new Point(669, 42);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(100, 37);
            DecryptButton.TabIndex = 29;
            DecryptButton.Text = "Decrypt 🔑";
            DecryptButton.UseVisualStyleBackColor = false;
            // 
            // LockedShaValueLabel
            // 
            LockedShaValueLabel.AutoSize = true;
            LockedShaValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedShaValueLabel.ForeColor = SystemColors.ButtonFace;
            LockedShaValueLabel.Location = new Point(428, 173);
            LockedShaValueLabel.Name = "LockedShaValueLabel";
            LockedShaValueLabel.Size = new Size(56, 21);
            LockedShaValueLabel.TabIndex = 34;
            LockedShaValueLabel.Text = "<sha>";
            // 
            // LockedShaLabel
            // 
            LockedShaLabel.AutoSize = true;
            LockedShaLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedShaLabel.ForeColor = SystemColors.ButtonFace;
            LockedShaLabel.Location = new Point(379, 173);
            LockedShaLabel.Name = "LockedShaLabel";
            LockedShaLabel.Size = new Size(43, 21);
            LockedShaLabel.TabIndex = 33;
            LockedShaLabel.Text = "SHA:";
            // 
            // LockedSizeValueLabel
            // 
            LockedSizeValueLabel.AutoSize = true;
            LockedSizeValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedSizeValueLabel.ForeColor = SystemColors.ButtonFace;
            LockedSizeValueLabel.Location = new Point(428, 152);
            LockedSizeValueLabel.Name = "LockedSizeValueLabel";
            LockedSizeValueLabel.Size = new Size(58, 21);
            LockedSizeValueLabel.TabIndex = 32;
            LockedSizeValueLabel.Text = "<size>";
            // 
            // LockedSizeLabel
            // 
            LockedSizeLabel.AutoSize = true;
            LockedSizeLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedSizeLabel.ForeColor = SystemColors.ButtonFace;
            LockedSizeLabel.Location = new Point(381, 152);
            LockedSizeLabel.Name = "LockedSizeLabel";
            LockedSizeLabel.Size = new Size(41, 21);
            LockedSizeLabel.TabIndex = 31;
            LockedSizeLabel.Text = "Size:";
            // 
            // LockedPathValueLabel
            // 
            LockedPathValueLabel.AutoSize = true;
            LockedPathValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPathValueLabel.ForeColor = SystemColors.ButtonFace;
            LockedPathValueLabel.Location = new Point(428, 131);
            LockedPathValueLabel.Name = "LockedPathValueLabel";
            LockedPathValueLabel.Size = new Size(63, 21);
            LockedPathValueLabel.TabIndex = 30;
            LockedPathValueLabel.Text = "<path>";
            // 
            // LockedPathLabel
            // 
            LockedPathLabel.AutoSize = true;
            LockedPathLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPathLabel.ForeColor = SystemColors.ButtonFace;
            LockedPathLabel.Location = new Point(378, 131);
            LockedPathLabel.Name = "LockedPathLabel";
            LockedPathLabel.Size = new Size(44, 21);
            LockedPathLabel.TabIndex = 29;
            LockedPathLabel.Text = "Path:";
            // 
            // LockDateValueLabel
            // 
            LockDateValueLabel.AutoSize = true;
            LockDateValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockDateValueLabel.ForeColor = SystemColors.ButtonFace;
            LockDateValueLabel.Location = new Point(428, 110);
            LockDateValueLabel.Name = "LockDateValueLabel";
            LockDateValueLabel.Size = new Size(94, 21);
            LockDateValueLabel.TabIndex = 28;
            LockDateValueLabel.Text = "<lock date>";
            // 
            // LockDateLabel
            // 
            LockDateLabel.AutoSize = true;
            LockDateLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockDateLabel.ForeColor = SystemColors.ButtonFace;
            LockDateLabel.Location = new Point(341, 110);
            LockDateLabel.Name = "LockDateLabel";
            LockDateLabel.Size = new Size(81, 21);
            LockDateLabel.TabIndex = 27;
            LockDateLabel.Text = "Lock Date:";
            // 
            // AlgorithmValueLabel
            // 
            AlgorithmValueLabel.AutoSize = true;
            AlgorithmValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            AlgorithmValueLabel.ForeColor = SystemColors.ButtonFace;
            AlgorithmValueLabel.Location = new Point(428, 89);
            AlgorithmValueLabel.Name = "AlgorithmValueLabel";
            AlgorithmValueLabel.Size = new Size(100, 21);
            AlgorithmValueLabel.TabIndex = 26;
            AlgorithmValueLabel.Text = "<algorithm>";
            // 
            // AlgorithmLabel
            // 
            AlgorithmLabel.AutoSize = true;
            AlgorithmLabel.BackColor = Color.FromArgb(32, 32, 32);
            AlgorithmLabel.ForeColor = SystemColors.ButtonFace;
            AlgorithmLabel.Location = new Point(339, 89);
            AlgorithmLabel.Name = "AlgorithmLabel";
            AlgorithmLabel.Size = new Size(83, 21);
            AlgorithmLabel.TabIndex = 25;
            AlgorithmLabel.Text = "Algorithm:";
            // 
            // LockedStatusValueLabel
            // 
            LockedStatusValueLabel.AutoSize = true;
            LockedStatusValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedStatusValueLabel.ForeColor = SystemColors.ButtonFace;
            LockedStatusValueLabel.Location = new Point(428, 68);
            LockedStatusValueLabel.Name = "LockedStatusValueLabel";
            LockedStatusValueLabel.Size = new Size(59, 21);
            LockedStatusValueLabel.TabIndex = 24;
            LockedStatusValueLabel.Text = "Locked";
            // 
            // LockedStatusLabel
            // 
            LockedStatusLabel.AutoSize = true;
            LockedStatusLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedStatusLabel.ForeColor = SystemColors.ButtonFace;
            LockedStatusLabel.Location = new Point(366, 68);
            LockedStatusLabel.Name = "LockedStatusLabel";
            LockedStatusLabel.Size = new Size(56, 21);
            LockedStatusLabel.TabIndex = 23;
            LockedStatusLabel.Text = "Status:";
            // 
            // LockedFileNameLabel
            // 
            LockedFileNameLabel.AutoSize = true;
            LockedFileNameLabel.Font = new Font("Segoe UI Emoji", 20.25F);
            LockedFileNameLabel.ForeColor = SystemColors.ButtonFace;
            LockedFileNameLabel.Location = new Point(353, 26);
            LockedFileNameLabel.Name = "LockedFileNameLabel";
            LockedFileNameLabel.Size = new Size(153, 36);
            LockedFileNameLabel.TabIndex = 8;
            LockedFileNameLabel.Text = "<filename>";
            // 
            // RelocationPanel
            // 
            RelocationPanel.BackColor = Color.FromArgb(32, 32, 32);
            RelocationPanel.BorderStyle = BorderStyle.FixedSingle;
            RelocationPanel.Controls.Add(RemoveButton);
            RelocationPanel.Controls.Add(RelocateButton);
            RelocationPanel.Controls.Add(LastSeenLabel);
            RelocationPanel.Controls.Add(CantLocateFileLabel);
            RelocationPanel.Location = new Point(361, 31);
            RelocationPanel.Name = "RelocationPanel";
            RelocationPanel.Size = new Size(864, 921);
            RelocationPanel.TabIndex = 35;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = SystemColors.Highlight;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Font = new Font("Segoe UI Emoji", 12F);
            RemoveButton.ForeColor = SystemColors.ButtonFace;
            RemoveButton.Location = new Point(449, 457);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(83, 37);
            RemoveButton.TabIndex = 20;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // RelocateButton
            // 
            RelocateButton.BackColor = SystemColors.Highlight;
            RelocateButton.FlatStyle = FlatStyle.Flat;
            RelocateButton.Font = new Font("Segoe UI Emoji", 12F);
            RelocateButton.ForeColor = SystemColors.ButtonFace;
            RelocateButton.Location = new Point(360, 457);
            RelocateButton.Name = "RelocateButton";
            RelocateButton.Size = new Size(83, 37);
            RelocateButton.TabIndex = 19;
            RelocateButton.Text = "Relocate";
            RelocateButton.UseVisualStyleBackColor = false;
            RelocateButton.Click += RelocateButton_Click;
            // 
            // LastSeenLabel
            // 
            LastSeenLabel.AutoSize = true;
            LastSeenLabel.Font = new Font("Segoe UI Emoji", 12F);
            LastSeenLabel.ForeColor = SystemColors.AppWorkspace;
            LastSeenLabel.Location = new Point(359, 414);
            LastSeenLabel.Name = "LastSeenLabel";
            LastSeenLabel.Size = new Size(191, 21);
            LastSeenLabel.TabIndex = 18;
            LastSeenLabel.Text = "It was last seen at <path>.";
            // 
            // CantLocateFileLabel
            // 
            CantLocateFileLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CantLocateFileLabel.AutoSize = true;
            CantLocateFileLabel.Font = new Font("Segoe UI Emoji", 20.25F);
            CantLocateFileLabel.ForeColor = SystemColors.ButtonFace;
            CantLocateFileLabel.Location = new Point(335, 378);
            CantLocateFileLabel.Name = "CantLocateFileLabel";
            CantLocateFileLabel.Size = new Size(238, 36);
            CantLocateFileLabel.TabIndex = 17;
            CantLocateFileLabel.Text = "Can't locate \"path\"";
            // 
            // UnlockedFilePanel
            // 
            UnlockedFilePanel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedFilePanel.BorderStyle = BorderStyle.FixedSingle;
            UnlockedFilePanel.Controls.Add(UnlockedShredGroupBox);
            UnlockedFilePanel.Controls.Add(EncryptGroupBox);
            UnlockedFilePanel.Controls.Add(UnlockedShaValueLabel);
            UnlockedFilePanel.Controls.Add(UnlockedShaLabel);
            UnlockedFilePanel.Controls.Add(UnlockedSizeValueLabel);
            UnlockedFilePanel.Controls.Add(UnlockedSizeLabel);
            UnlockedFilePanel.Controls.Add(UnlockedPathValueLabel);
            UnlockedFilePanel.Controls.Add(UnlockedPathLabel);
            UnlockedFilePanel.Controls.Add(UnlockedStatusValueLabel);
            UnlockedFilePanel.Controls.Add(UnlockedStatusLabel);
            UnlockedFilePanel.Controls.Add(UnlockedFileNameLabel);
            UnlockedFilePanel.Location = new Point(361, 31);
            UnlockedFilePanel.Name = "UnlockedFilePanel";
            UnlockedFilePanel.Size = new Size(864, 921);
            UnlockedFilePanel.TabIndex = 35;
            // 
            // UnlockedShredGroupBox
            // 
            UnlockedShredGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedShredGroupBox.Controls.Add(UnlockedShredDescriptionLabel);
            UnlockedShredGroupBox.Controls.Add(UnlockedShredButton);
            UnlockedShredGroupBox.FlatStyle = FlatStyle.Flat;
            UnlockedShredGroupBox.ForeColor = SystemColors.ButtonFace;
            UnlockedShredGroupBox.Location = new Point(22, 338);
            UnlockedShredGroupBox.Name = "UnlockedShredGroupBox";
            UnlockedShredGroupBox.Size = new Size(807, 116);
            UnlockedShredGroupBox.TabIndex = 32;
            UnlockedShredGroupBox.TabStop = false;
            UnlockedShredGroupBox.Text = "Shred";
            // 
            // UnlockedShredDescriptionLabel
            // 
            UnlockedShredDescriptionLabel.AutoSize = true;
            UnlockedShredDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedShredDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedShredDescriptionLabel.Location = new Point(74, 40);
            UnlockedShredDescriptionLabel.Name = "UnlockedShredDescriptionLabel";
            UnlockedShredDescriptionLabel.Size = new Size(233, 42);
            UnlockedShredDescriptionLabel.TabIndex = 34;
            UnlockedShredDescriptionLabel.Text = "Overwrites the file with \r\nrandom data and then deletes it.";
            // 
            // UnlockedShredButton
            // 
            UnlockedShredButton.BackColor = Color.DarkRed;
            UnlockedShredButton.FlatStyle = FlatStyle.Flat;
            UnlockedShredButton.Font = new Font("Segoe UI Emoji", 12F);
            UnlockedShredButton.ForeColor = SystemColors.ButtonFace;
            UnlockedShredButton.Location = new Point(669, 45);
            UnlockedShredButton.Name = "UnlockedShredButton";
            UnlockedShredButton.Size = new Size(100, 37);
            UnlockedShredButton.TabIndex = 6;
            UnlockedShredButton.Text = "Shred 🗑️";
            UnlockedShredButton.UseVisualStyleBackColor = false;
            UnlockedShredButton.Click += UnlockedShredButton_Click;
            // 
            // EncryptGroupBox
            // 
            EncryptGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            EncryptGroupBox.Controls.Add(EncryptDescriptionLabel);
            EncryptGroupBox.Controls.Add(EncryptButton);
            EncryptGroupBox.FlatStyle = FlatStyle.Flat;
            EncryptGroupBox.ForeColor = SystemColors.ButtonFace;
            EncryptGroupBox.Location = new Point(22, 197);
            EncryptGroupBox.Name = "EncryptGroupBox";
            EncryptGroupBox.Size = new Size(807, 116);
            EncryptGroupBox.TabIndex = 31;
            EncryptGroupBox.TabStop = false;
            EncryptGroupBox.Text = "Encrypt";
            // 
            // EncryptDescriptionLabel
            // 
            EncryptDescriptionLabel.AutoSize = true;
            EncryptDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            EncryptDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            EncryptDescriptionLabel.Location = new Point(74, 27);
            EncryptDescriptionLabel.Name = "EncryptDescriptionLabel";
            EncryptDescriptionLabel.Size = new Size(184, 63);
            EncryptDescriptionLabel.TabIndex = 33;
            EncryptDescriptionLabel.Text = "Encrypts the file with the \r\nselected algorithm using \r\nthe input password.";
            // 
            // EncryptButton
            // 
            EncryptButton.BackColor = SystemColors.Highlight;
            EncryptButton.FlatStyle = FlatStyle.Flat;
            EncryptButton.Font = new Font("Segoe UI Emoji", 12F);
            EncryptButton.ForeColor = SystemColors.ButtonFace;
            EncryptButton.Location = new Point(669, 42);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(100, 37);
            EncryptButton.TabIndex = 29;
            EncryptButton.Text = "Encrypt 🔐";
            EncryptButton.UseVisualStyleBackColor = false;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // UnlockedShaValueLabel
            // 
            UnlockedShaValueLabel.AutoSize = true;
            UnlockedShaValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedShaValueLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedShaValueLabel.Location = new Point(431, 131);
            UnlockedShaValueLabel.Name = "UnlockedShaValueLabel";
            UnlockedShaValueLabel.Size = new Size(56, 21);
            UnlockedShaValueLabel.TabIndex = 30;
            UnlockedShaValueLabel.Text = "<sha>";
            // 
            // UnlockedShaLabel
            // 
            UnlockedShaLabel.AutoSize = true;
            UnlockedShaLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedShaLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedShaLabel.Location = new Point(381, 131);
            UnlockedShaLabel.Name = "UnlockedShaLabel";
            UnlockedShaLabel.Size = new Size(43, 21);
            UnlockedShaLabel.TabIndex = 29;
            UnlockedShaLabel.Text = "SHA:";
            // 
            // UnlockedSizeValueLabel
            // 
            UnlockedSizeValueLabel.AutoSize = true;
            UnlockedSizeValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedSizeValueLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedSizeValueLabel.Location = new Point(431, 110);
            UnlockedSizeValueLabel.Name = "UnlockedSizeValueLabel";
            UnlockedSizeValueLabel.Size = new Size(58, 21);
            UnlockedSizeValueLabel.TabIndex = 28;
            UnlockedSizeValueLabel.Text = "<size>";
            // 
            // UnlockedSizeLabel
            // 
            UnlockedSizeLabel.AutoSize = true;
            UnlockedSizeLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedSizeLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedSizeLabel.Location = new Point(383, 110);
            UnlockedSizeLabel.Name = "UnlockedSizeLabel";
            UnlockedSizeLabel.Size = new Size(41, 21);
            UnlockedSizeLabel.TabIndex = 27;
            UnlockedSizeLabel.Text = "Size:";
            // 
            // UnlockedPathValueLabel
            // 
            UnlockedPathValueLabel.AutoSize = true;
            UnlockedPathValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPathValueLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPathValueLabel.Location = new Point(431, 89);
            UnlockedPathValueLabel.Name = "UnlockedPathValueLabel";
            UnlockedPathValueLabel.Size = new Size(63, 21);
            UnlockedPathValueLabel.TabIndex = 26;
            UnlockedPathValueLabel.Text = "<path>";
            // 
            // UnlockedPathLabel
            // 
            UnlockedPathLabel.AutoSize = true;
            UnlockedPathLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPathLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPathLabel.Location = new Point(380, 89);
            UnlockedPathLabel.Name = "UnlockedPathLabel";
            UnlockedPathLabel.Size = new Size(44, 21);
            UnlockedPathLabel.TabIndex = 25;
            UnlockedPathLabel.Text = "Path:";
            // 
            // UnlockedStatusValueLabel
            // 
            UnlockedStatusValueLabel.AutoSize = true;
            UnlockedStatusValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedStatusValueLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedStatusValueLabel.Location = new Point(431, 68);
            UnlockedStatusValueLabel.Name = "UnlockedStatusValueLabel";
            UnlockedStatusValueLabel.Size = new Size(75, 21);
            UnlockedStatusValueLabel.TabIndex = 24;
            UnlockedStatusValueLabel.Text = "Unlocked";
            // 
            // UnlockedStatusLabel
            // 
            UnlockedStatusLabel.AutoSize = true;
            UnlockedStatusLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedStatusLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedStatusLabel.Location = new Point(368, 68);
            UnlockedStatusLabel.Name = "UnlockedStatusLabel";
            UnlockedStatusLabel.Size = new Size(56, 21);
            UnlockedStatusLabel.TabIndex = 23;
            UnlockedStatusLabel.Text = "Status:";
            // 
            // UnlockedFileNameLabel
            // 
            UnlockedFileNameLabel.AutoSize = true;
            UnlockedFileNameLabel.Font = new Font("Segoe UI Emoji", 20.25F);
            UnlockedFileNameLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedFileNameLabel.Location = new Point(356, 26);
            UnlockedFileNameLabel.Name = "UnlockedFileNameLabel";
            UnlockedFileNameLabel.Size = new Size(153, 36);
            UnlockedFileNameLabel.TabIndex = 8;
            UnlockedFileNameLabel.Text = "<filename>";
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
            Controls.Add(NoFilesPanel);
            Controls.Add(RelocationPanel);
            Controls.Add(LockedFilePanel);
            Controls.Add(UnlockedFilePanel);
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
            LockedFilePanel.ResumeLayout(false);
            LockedFilePanel.PerformLayout();
            LockedShredGroupBox.ResumeLayout(false);
            LockedShredGroupBox.PerformLayout();
            DecryptGroupBox.ResumeLayout(false);
            DecryptGroupBox.PerformLayout();
            RelocationPanel.ResumeLayout(false);
            RelocationPanel.PerformLayout();
            UnlockedFilePanel.ResumeLayout(false);
            UnlockedFilePanel.PerformLayout();
            UnlockedShredGroupBox.ResumeLayout(false);
            UnlockedShredGroupBox.PerformLayout();
            EncryptGroupBox.ResumeLayout(false);
            EncryptGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label NoFilesLabel;
        private Button UnlockedShredButton;
        private Button DecryptButton;
        private ListBox FileListBox;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem GuideMenuItem;
        private TextBox SearchTextBox;
        private Label MagnifyingGlassLabel;
        private Button AddButton;
        private Panel NoFilesPanel;
        private Label NoFilesDescriptionLabel;
        private ToolStripMenuItem SettingsMenuItem;
        private ToolStripMenuItem DiagnosticsMenuItem;
        private ContextMenuStrip AddButtonContextMenuStrip;
        private ToolStripMenuItem AddExistingFilesToolStripMenuItem;
        private ToolStripMenuItem ImportArchiveToolStripMenuItem;
        private Panel LockedFilePanel;
        private Label LockedStatusLabel;
        private Label LockedFileNameLabel;
        private Label LockedStatusValueLabel;
        private Label LockedShaValueLabel;
        private Label LockedShaLabel;
        private Label LockedSizeValueLabel;
        private Label LockedSizeLabel;
        private Label LockedPathValueLabel;
        private Label LockedPathLabel;
        private Label LockDateValueLabel;
        private Label LockDateLabel;
        private Label AlgorithmValueLabel;
        private Label AlgorithmLabel;
        private Panel RelocationPanel;
        private Label LastSeenLabel;
        private Label CantLocateFileLabel;
        private Button RemoveButton;
        private Button RelocateButton;
        private Panel UnlockedFilePanel;
        private Label UnlockedShaValueLabel;
        private Label UnlockedShaLabel;
        private Label UnlockedSizeValueLabel;
        private Label UnlockedSizeLabel;
        private Label UnlockedPathValueLabel;
        private Label UnlockedPathLabel;
        private Label UnlockedStatusValueLabel;
        private Label UnlockedStatusLabel;
        private Label UnlockedFileNameLabel;
        private GroupBox UnlockedShredGroupBox;
        private Button ClearButton;
        private Label PasswordWarningLabel;
        private ComboBox EncryptionAlgorithmComboBox;
        private Label ChooseAlgorithmLabel;
        private Button EncryptButton;
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
        private Label EncryptDescriptionLabel;
        private Label UnlockedShredDescriptionLabel;
        private GroupBox EncryptGroupBox;
        private ContextMenuStrip FileListBoxContextMenuStrip;
        private ToolStripMenuItem RemoveFromListItem;
        private GroupBox LockedShredGroupBox;
        private Label LockedShredDescriptionLabel;
        private Button LockedShredButton;
        private GroupBox DecryptGroupBox;
        private Label DecryptDescriptionLabel;
    }
}
