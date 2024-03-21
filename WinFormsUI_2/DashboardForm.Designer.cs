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
            ShredDescriptionLabel = new Label();
            UnlockedShredButton = new Button();
            EncryptGroupBox = new GroupBox();
            EncryptDescriptionLabel = new Label();
            ClearButton = new Button();
            PasswordWarningLabel = new Label();
            EncryptionAlgorithmComboBox = new ComboBox();
            ChooseAlgorithmLabel = new Label();
            GenerateRandomButton = new Button();
            EyeballLabel = new Label();
            ConfirmPasswordMaskedTextBox = new MaskedTextBox();
            ConfirmLabel = new Label();
            EnterButton = new Button();
            SpecialCharacterLabel = new Label();
            LowercaseLetterLabel = new Label();
            UppercaseLetterLabel = new Label();
            DigitLabel = new Label();
            NumberOfCharactersLabel = new Label();
            PasswordMaskedTextBox = new MaskedTextBox();
            PasswordLabel = new Label();
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
            NoFilesDescriptionLabel.Location = new Point(196, 179);
            NoFilesDescriptionLabel.Name = "NoFilesDescriptionLabel";
            NoFilesDescriptionLabel.Size = new Size(274, 42);
            NoFilesDescriptionLabel.TabIndex = 23;
            NoFilesDescriptionLabel.Text = "Click Add to import or manually select\r\n files to add to FileLocker's scope.";
            // 
            // NoFilesLabel
            // 
            NoFilesLabel.AutoSize = true;
            NoFilesLabel.Font = new Font("Segoe UI Emoji", 20.25F);
            NoFilesLabel.ForeColor = SystemColors.ButtonFace;
            NoFilesLabel.Location = new Point(281, 131);
            NoFilesLabel.Name = "NoFilesLabel";
            NoFilesLabel.Size = new Size(105, 36);
            NoFilesLabel.TabIndex = 8;
            NoFilesLabel.Text = "No files";
            // 
            // LockedFilePanel
            // 
            LockedFilePanel.BackColor = Color.FromArgb(32, 32, 32);
            LockedFilePanel.BorderStyle = BorderStyle.FixedSingle;
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
            // LockedShaValueLabel
            // 
            LockedShaValueLabel.AutoSize = true;
            LockedShaValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedShaValueLabel.ForeColor = SystemColors.ButtonFace;
            LockedShaValueLabel.Location = new Point(343, 173);
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
            LockedShaLabel.Location = new Point(294, 173);
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
            LockedSizeValueLabel.Location = new Point(343, 152);
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
            LockedSizeLabel.Location = new Point(296, 152);
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
            LockedPathValueLabel.Location = new Point(343, 131);
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
            LockedPathLabel.Location = new Point(293, 131);
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
            LockDateValueLabel.Location = new Point(343, 110);
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
            LockDateLabel.Location = new Point(256, 110);
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
            AlgorithmValueLabel.Location = new Point(343, 89);
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
            AlgorithmLabel.Location = new Point(254, 89);
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
            LockedStatusValueLabel.Location = new Point(343, 68);
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
            LockedStatusLabel.Location = new Point(281, 68);
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
            LockedFileNameLabel.Location = new Point(268, 26);
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
            RemoveButton.Location = new Point(336, 216);
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
            RelocateButton.Location = new Point(247, 216);
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
            LastSeenLabel.Location = new Point(246, 173);
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
            CantLocateFileLabel.Location = new Point(222, 137);
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
            UnlockedShredGroupBox.Controls.Add(ShredDescriptionLabel);
            UnlockedShredGroupBox.Controls.Add(UnlockedShredButton);
            UnlockedShredGroupBox.FlatStyle = FlatStyle.Flat;
            UnlockedShredGroupBox.ForeColor = SystemColors.ButtonFace;
            UnlockedShredGroupBox.Location = new Point(22, 541);
            UnlockedShredGroupBox.Name = "UnlockedShredGroupBox";
            UnlockedShredGroupBox.Size = new Size(807, 116);
            UnlockedShredGroupBox.TabIndex = 32;
            UnlockedShredGroupBox.TabStop = false;
            UnlockedShredGroupBox.Text = "Shred";
            // 
            // ShredDescriptionLabel
            // 
            ShredDescriptionLabel.AutoSize = true;
            ShredDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            ShredDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            ShredDescriptionLabel.Location = new Point(74, 40);
            ShredDescriptionLabel.Name = "ShredDescriptionLabel";
            ShredDescriptionLabel.Size = new Size(233, 42);
            ShredDescriptionLabel.TabIndex = 34;
            ShredDescriptionLabel.Text = "Overwrites the file with \r\nrandom data and then deletes it.";
            // 
            // UnlockedShredButton
            // 
            UnlockedShredButton.BackColor = Color.DarkRed;
            UnlockedShredButton.FlatStyle = FlatStyle.Flat;
            UnlockedShredButton.Font = new Font("Segoe UI Emoji", 12F);
            UnlockedShredButton.ForeColor = SystemColors.ButtonFace;
            UnlockedShredButton.Location = new Point(681, 45);
            UnlockedShredButton.Name = "UnlockedShredButton";
            UnlockedShredButton.Size = new Size(88, 37);
            UnlockedShredButton.TabIndex = 6;
            UnlockedShredButton.Text = "Shred 🗑️";
            UnlockedShredButton.UseVisualStyleBackColor = false;
            UnlockedShredButton.Click += UnlockedShredButton_Click;
            // 
            // EncryptGroupBox
            // 
            EncryptGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            EncryptGroupBox.Controls.Add(EncryptDescriptionLabel);
            EncryptGroupBox.Controls.Add(ClearButton);
            EncryptGroupBox.Controls.Add(PasswordWarningLabel);
            EncryptGroupBox.Controls.Add(EncryptionAlgorithmComboBox);
            EncryptGroupBox.Controls.Add(ChooseAlgorithmLabel);
            EncryptGroupBox.Controls.Add(GenerateRandomButton);
            EncryptGroupBox.Controls.Add(EyeballLabel);
            EncryptGroupBox.Controls.Add(ConfirmPasswordMaskedTextBox);
            EncryptGroupBox.Controls.Add(ConfirmLabel);
            EncryptGroupBox.Controls.Add(EnterButton);
            EncryptGroupBox.Controls.Add(SpecialCharacterLabel);
            EncryptGroupBox.Controls.Add(LowercaseLetterLabel);
            EncryptGroupBox.Controls.Add(UppercaseLetterLabel);
            EncryptGroupBox.Controls.Add(DigitLabel);
            EncryptGroupBox.Controls.Add(NumberOfCharactersLabel);
            EncryptGroupBox.Controls.Add(PasswordMaskedTextBox);
            EncryptGroupBox.Controls.Add(PasswordLabel);
            EncryptGroupBox.FlatStyle = FlatStyle.Flat;
            EncryptGroupBox.ForeColor = SystemColors.ButtonFace;
            EncryptGroupBox.Location = new Point(22, 197);
            EncryptGroupBox.Name = "EncryptGroupBox";
            EncryptGroupBox.Size = new Size(807, 338);
            EncryptGroupBox.TabIndex = 31;
            EncryptGroupBox.TabStop = false;
            EncryptGroupBox.Text = "Encrypt";
            // 
            // EncryptDescriptionLabel
            // 
            EncryptDescriptionLabel.AutoSize = true;
            EncryptDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            EncryptDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            EncryptDescriptionLabel.Location = new Point(74, 148);
            EncryptDescriptionLabel.Name = "EncryptDescriptionLabel";
            EncryptDescriptionLabel.Size = new Size(184, 63);
            EncryptDescriptionLabel.TabIndex = 33;
            EncryptDescriptionLabel.Text = "Encrypts the file with the \r\nselected algorithm using \r\nthe input password.";
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.Silver;
            ClearButton.Enabled = false;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Font = new Font("Segoe UI Emoji", 12F);
            ClearButton.ForeColor = SystemColors.ButtonFace;
            ClearButton.Location = new Point(592, 280);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(148, 37);
            ClearButton.TabIndex = 33;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // PasswordWarningLabel
            // 
            PasswordWarningLabel.AutoSize = true;
            PasswordWarningLabel.Font = new Font("Segoe UI Emoji", 10F);
            PasswordWarningLabel.ForeColor = Color.Red;
            PasswordWarningLabel.Location = new Point(466, 131);
            PasswordWarningLabel.Name = "PasswordWarningLabel";
            PasswordWarningLabel.Size = new Size(250, 19);
            PasswordWarningLabel.TabIndex = 32;
            PasswordWarningLabel.Text = "If your password is lost, so is your data.";
            PasswordWarningLabel.Visible = false;
            // 
            // EncryptionAlgorithmComboBox
            // 
            EncryptionAlgorithmComboBox.BackColor = Color.FromArgb(52, 52, 52);
            EncryptionAlgorithmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EncryptionAlgorithmComboBox.ForeColor = SystemColors.ButtonFace;
            EncryptionAlgorithmComboBox.FormattingEnabled = true;
            EncryptionAlgorithmComboBox.Location = new Point(452, 99);
            EncryptionAlgorithmComboBox.Name = "EncryptionAlgorithmComboBox";
            EncryptionAlgorithmComboBox.Size = new Size(277, 29);
            EncryptionAlgorithmComboBox.TabIndex = 31;
            // 
            // ChooseAlgorithmLabel
            // 
            ChooseAlgorithmLabel.AutoSize = true;
            ChooseAlgorithmLabel.Font = new Font("Segoe UI Emoji", 12F);
            ChooseAlgorithmLabel.ForeColor = SystemColors.ButtonFace;
            ChooseAlgorithmLabel.Location = new Point(363, 102);
            ChooseAlgorithmLabel.Name = "ChooseAlgorithmLabel";
            ChooseAlgorithmLabel.Size = new Size(83, 21);
            ChooseAlgorithmLabel.TabIndex = 30;
            ChooseAlgorithmLabel.Text = "Algorithm:";
            // 
            // GenerateRandomButton
            // 
            GenerateRandomButton.BackColor = SystemColors.Highlight;
            GenerateRandomButton.FlatStyle = FlatStyle.Flat;
            GenerateRandomButton.Font = new Font("Segoe UI Emoji", 12F);
            GenerateRandomButton.ForeColor = SystemColors.ButtonFace;
            GenerateRandomButton.Location = new Point(438, 280);
            GenerateRandomButton.Name = "GenerateRandomButton";
            GenerateRandomButton.Size = new Size(148, 37);
            GenerateRandomButton.TabIndex = 29;
            GenerateRandomButton.Text = "Generate Random";
            GenerateRandomButton.UseVisualStyleBackColor = false;
            GenerateRandomButton.Click += GenerateRandomButton_Click;
            // 
            // EyeballLabel
            // 
            EyeballLabel.AutoSize = true;
            EyeballLabel.BackColor = Color.FromArgb(52, 52, 52);
            EyeballLabel.Font = new Font("Segoe UI Emoji", 12F);
            EyeballLabel.ForeColor = SystemColors.ButtonFace;
            EyeballLabel.Location = new Point(695, 67);
            EyeballLabel.Name = "EyeballLabel";
            EyeballLabel.Size = new Size(32, 21);
            EyeballLabel.TabIndex = 19;
            EyeballLabel.Text = "👁";
            EyeballLabel.Click += EyeballLabel_Click;
            // 
            // ConfirmPasswordMaskedTextBox
            // 
            ConfirmPasswordMaskedTextBox.BackColor = Color.FromArgb(52, 52, 52);
            ConfirmPasswordMaskedTextBox.Font = new Font("Segoe UI Emoji", 12F);
            ConfirmPasswordMaskedTextBox.ForeColor = SystemColors.ButtonFace;
            ConfirmPasswordMaskedTextBox.Location = new Point(452, 64);
            ConfirmPasswordMaskedTextBox.Name = "ConfirmPasswordMaskedTextBox";
            ConfirmPasswordMaskedTextBox.Size = new Size(277, 29);
            ConfirmPasswordMaskedTextBox.TabIndex = 27;
            ConfirmPasswordMaskedTextBox.UseSystemPasswordChar = true;
            // 
            // ConfirmLabel
            // 
            ConfirmLabel.AutoSize = true;
            ConfirmLabel.Font = new Font("Segoe UI Emoji", 12F);
            ConfirmLabel.ForeColor = SystemColors.ButtonFace;
            ConfirmLabel.Location = new Point(376, 67);
            ConfirmLabel.Name = "ConfirmLabel";
            ConfirmLabel.Size = new Size(70, 21);
            ConfirmLabel.TabIndex = 28;
            ConfirmLabel.Text = "Confirm:";
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.Silver;
            EnterButton.Enabled = false;
            EnterButton.FlatStyle = FlatStyle.Flat;
            EnterButton.Font = new Font("Segoe UI Emoji", 12F);
            EnterButton.ForeColor = SystemColors.ButtonFace;
            EnterButton.Location = new Point(735, 60);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(34, 37);
            EnterButton.TabIndex = 26;
            EnterButton.Text = "→\n";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // SpecialCharacterLabel
            // 
            SpecialCharacterLabel.AutoSize = true;
            SpecialCharacterLabel.Font = new Font("Segoe UI Emoji", 12F);
            SpecialCharacterLabel.ForeColor = SystemColors.AppWorkspace;
            SpecialCharacterLabel.Location = new Point(452, 243);
            SpecialCharacterLabel.Name = "SpecialCharacterLabel";
            SpecialCharacterLabel.Size = new Size(138, 21);
            SpecialCharacterLabel.TabIndex = 25;
            SpecialCharacterLabel.Text = "• Special character";
            // 
            // LowercaseLetterLabel
            // 
            LowercaseLetterLabel.AutoSize = true;
            LowercaseLetterLabel.Font = new Font("Segoe UI Emoji", 12F);
            LowercaseLetterLabel.ForeColor = SystemColors.AppWorkspace;
            LowercaseLetterLabel.Location = new Point(452, 201);
            LowercaseLetterLabel.Name = "LowercaseLetterLabel";
            LowercaseLetterLabel.Size = new Size(134, 21);
            LowercaseLetterLabel.TabIndex = 24;
            LowercaseLetterLabel.Text = "• Lowercase letter";
            // 
            // UppercaseLetterLabel
            // 
            UppercaseLetterLabel.AutoSize = true;
            UppercaseLetterLabel.Font = new Font("Segoe UI Emoji", 12F);
            UppercaseLetterLabel.ForeColor = SystemColors.AppWorkspace;
            UppercaseLetterLabel.Location = new Point(452, 180);
            UppercaseLetterLabel.Name = "UppercaseLetterLabel";
            UppercaseLetterLabel.Size = new Size(134, 21);
            UppercaseLetterLabel.TabIndex = 23;
            UppercaseLetterLabel.Text = "• Uppercase letter";
            // 
            // DigitLabel
            // 
            DigitLabel.AutoSize = true;
            DigitLabel.Font = new Font("Segoe UI Emoji", 12F);
            DigitLabel.ForeColor = SystemColors.AppWorkspace;
            DigitLabel.Location = new Point(452, 222);
            DigitLabel.Name = "DigitLabel";
            DigitLabel.Size = new Size(54, 21);
            DigitLabel.TabIndex = 22;
            DigitLabel.Text = "• Digit";
            // 
            // NumberOfCharactersLabel
            // 
            NumberOfCharactersLabel.AutoSize = true;
            NumberOfCharactersLabel.Font = new Font("Segoe UI Emoji", 12F);
            NumberOfCharactersLabel.ForeColor = SystemColors.AppWorkspace;
            NumberOfCharactersLabel.Location = new Point(452, 159);
            NumberOfCharactersLabel.Name = "NumberOfCharactersLabel";
            NumberOfCharactersLabel.Size = new Size(158, 21);
            NumberOfCharactersLabel.TabIndex = 21;
            NumberOfCharactersLabel.Text = "• <range> characters";
            // 
            // PasswordMaskedTextBox
            // 
            PasswordMaskedTextBox.BackColor = Color.FromArgb(52, 52, 52);
            PasswordMaskedTextBox.Font = new Font("Segoe UI Emoji", 12F);
            PasswordMaskedTextBox.ForeColor = SystemColors.ButtonFace;
            PasswordMaskedTextBox.Location = new Point(452, 31);
            PasswordMaskedTextBox.Name = "PasswordMaskedTextBox";
            PasswordMaskedTextBox.Size = new Size(277, 29);
            PasswordMaskedTextBox.TabIndex = 18;
            PasswordMaskedTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI Emoji", 12F);
            PasswordLabel.ForeColor = SystemColors.ButtonFace;
            PasswordLabel.Location = new Point(364, 34);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(80, 21);
            PasswordLabel.TabIndex = 20;
            PasswordLabel.Text = "Password:";
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
            Controls.Add(UnlockedFilePanel);
            Controls.Add(NoFilesPanel);
            Controls.Add(RelocationPanel);
            Controls.Add(LockedFilePanel);
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
        private Button GenerateRandomButton;
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
        private Label ShredDescriptionLabel;
        private GroupBox EncryptGroupBox;
        private ContextMenuStrip FileListBoxContextMenuStrip;
        private ToolStripMenuItem RemoveFromListItem;
    }
}
