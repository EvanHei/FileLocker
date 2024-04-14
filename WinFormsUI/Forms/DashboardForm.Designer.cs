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
            FileListBoxContextMenuStrip = new ContextMenuStrip(components);
            FileListBox_RemoveFromListItem = new ToolStripMenuItem();
            MenuStrip = new MenuStrip();
            LogsMenuItem = new ToolStripMenuItem();
            KeysMenuItem = new ToolStripMenuItem();
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
            LockedPanel_TrashCanLabel = new Label();
            LockedPanel_SignatureValueLabel = new Label();
            LockedPanel_SignatureLabel = new Label();
            LockedPanel_SignGroupBox = new GroupBox();
            LockedPanel_SignDescriptionLabel = new Label();
            LockedPanel_SignButton = new Button();
            LockedPanel_DateAddedValueLabel = new Label();
            LockedPanel_DateAddedLabel = new Label();
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
            LockedPanel_ExplorerGroupBox = new GroupBox();
            LockedPanel_ExplorerDescriptionLabel = new Label();
            LockedPanel_ExplorerButton = new Button();
            RelocationPanel = new Panel();
            RelocationPanel_RemoveButton = new Button();
            RelocationPanel_RelocateButton = new Button();
            RelocationPanel_LastSeenLabel = new Label();
            RelocationPanel_CantLocateFileLabel = new Label();
            UnlockedPanel = new Panel();
            UnlockedPanel_TrashCanLabel = new Label();
            UnlockedPanel_SignatureValueLabel = new Label();
            UnlockedPanel_SignatureLabel = new Label();
            UnlockedPanel_SignGroupBox = new GroupBox();
            UnlockedPanel_SignDescriptionLabel = new Label();
            UnlockedPanel_SignButton = new Button();
            UnlockedPanel_DateAddedValueLabel = new Label();
            UnlockedPanel_DateAddedLabel = new Label();
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
            KeysPanel = new Panel();
            KeysPanel_MagnifyingGlassLabel = new Label();
            KeysPanel_SearchTextBox = new TextBox();
            KeysPanel_OtherKeysRadioButton = new RadioButton();
            KeysPanel_MyKeysRadioButton = new RadioButton();
            KeysPanel_ImportGroupBox = new GroupBox();
            KeysPanel_ImportDescriptionLabel = new Label();
            KeysPanel_ImportButton = new Button();
            KeysPanel_ListBox = new ListBox();
            KeysListBoxContextMenuStrip = new ContextMenuStrip(components);
            MyKeysListBox_DeleteItem = new ToolStripMenuItem();
            MyKeysListBox_ExportItem = new ToolStripMenuItem();
            KeysPanel_CreateGroupBox = new GroupBox();
            KeysPanel_CreateDescriptionLabel = new Label();
            KeysPanel_CreateButton = new Button();
            KeysPanel_KeysLabel = new Label();
            LogsPanel = new Panel();
            LogsPanel_FilterGroupBox = new GroupBox();
            LogsPanel_LevelLabel = new Label();
            LogsPanel_LevelComboBox = new ComboBox();
            LogsPanel_LastDayRadioButton = new RadioButton();
            LogsPanel_LastWeekRadioButton = new RadioButton();
            LogsPanel_LastMonthRadioButton = new RadioButton();
            LogsPanel_AllTimeRadioButton = new RadioButton();
            LogsPanel_FilterDescriptionLabel = new Label();
            LogsPanel_MagnifyingGlassLabel = new Label();
            LogsPanel_SearchTextBox = new TextBox();
            LogsPanel_ListBox = new ListBox();
            LogsPanel_LogsLabel = new Label();
            FileListBoxContextMenuStrip.SuspendLayout();
            MenuStrip.SuspendLayout();
            AddButtonContextMenuStrip.SuspendLayout();
            NoFilesPanel.SuspendLayout();
            LockedPanel.SuspendLayout();
            LockedPanel_SignGroupBox.SuspendLayout();
            LockedPanel_ExportGroupBox.SuspendLayout();
            LockedPanel_ShredGroupBox.SuspendLayout();
            LockedPanel_DecryptGroupBox.SuspendLayout();
            LockedPanel_ExplorerGroupBox.SuspendLayout();
            RelocationPanel.SuspendLayout();
            UnlockedPanel.SuspendLayout();
            UnlockedPanel_SignGroupBox.SuspendLayout();
            UnlockedPanel_ExplorerGroupBox.SuspendLayout();
            UnlockedPanel_ShredGroupBox.SuspendLayout();
            UnlockedPanel_EncryptGroupBox.SuspendLayout();
            KeysPanel.SuspendLayout();
            KeysPanel_ImportGroupBox.SuspendLayout();
            KeysListBoxContextMenuStrip.SuspendLayout();
            KeysPanel_CreateGroupBox.SuspendLayout();
            LogsPanel.SuspendLayout();
            LogsPanel_FilterGroupBox.SuspendLayout();
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
            FileListBoxContextMenuStrip.Items.AddRange(new ToolStripItem[] { FileListBox_RemoveFromListItem });
            FileListBoxContextMenuStrip.Name = "FileListBoxItemContextMenuStrip";
            FileListBoxContextMenuStrip.Size = new Size(165, 26);
            FileListBoxContextMenuStrip.Tag = "FileListBox";
            FileListBoxContextMenuStrip.Text = "Remove File";
            // 
            // FileListBox_RemoveFromListItem
            // 
            FileListBox_RemoveFromListItem.BackColor = Color.FromArgb(40, 40, 40);
            FileListBox_RemoveFromListItem.ForeColor = SystemColors.ButtonFace;
            FileListBox_RemoveFromListItem.Name = "FileListBox_RemoveFromListItem";
            FileListBox_RemoveFromListItem.Size = new Size(164, 22);
            FileListBox_RemoveFromListItem.Text = "Remove from list";
            FileListBox_RemoveFromListItem.Click += RemoveFromListItem_Click;
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.FromArgb(40, 40, 40);
            MenuStrip.Font = new Font("Segoe UI Emoji", 10F);
            MenuStrip.Items.AddRange(new ToolStripItem[] { LogsMenuItem, KeysMenuItem, GuideMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(1217, 29);
            MenuStrip.TabIndex = 17;
            MenuStrip.Text = "menuStrip1";
            // 
            // LogsMenuItem
            // 
            LogsMenuItem.Alignment = ToolStripItemAlignment.Right;
            LogsMenuItem.ForeColor = SystemColors.AppWorkspace;
            LogsMenuItem.Name = "LogsMenuItem";
            LogsMenuItem.Size = new Size(73, 25);
            LogsMenuItem.Text = "&Logs 📜";
            LogsMenuItem.Click += LogsMenuItem_Click;
            // 
            // KeysMenuItem
            // 
            KeysMenuItem.Alignment = ToolStripItemAlignment.Right;
            KeysMenuItem.Font = new Font("Segoe UI Emoji", 10F);
            KeysMenuItem.ForeColor = SystemColors.AppWorkspace;
            KeysMenuItem.Margin = new Padding(0, 2, 0, 0);
            KeysMenuItem.Name = "KeysMenuItem";
            KeysMenuItem.Size = new Size(72, 23);
            KeysMenuItem.Text = "&Keys 🔑";
            KeysMenuItem.Click += KeysMenuItem_Click;
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
            SearchTextBox.TabIndex = 81;
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
            AddButton.TabIndex = 80;
            AddButton.Text = "&Add ▼";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.MouseDown += AddButton_MouseDown;
            // 
            // AddButtonContextMenuStrip
            // 
            AddButtonContextMenuStrip.Items.AddRange(new ToolStripItem[] { AddExistingFilesToolStripMenuItem, ImportArchiveToolStripMenuItem });
            AddButtonContextMenuStrip.Name = "AddButtonContextMenuStrip";
            AddButtonContextMenuStrip.Size = new Size(173, 48);
            AddButtonContextMenuStrip.TabStop = true;
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
            NoFilesPanel.Size = new Size(864, 944);
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
            LockedPanel.Controls.Add(LockedPanel_TrashCanLabel);
            LockedPanel.Controls.Add(LockedPanel_SignatureValueLabel);
            LockedPanel.Controls.Add(LockedPanel_SignatureLabel);
            LockedPanel.Controls.Add(LockedPanel_SignGroupBox);
            LockedPanel.Controls.Add(LockedPanel_DateAddedValueLabel);
            LockedPanel.Controls.Add(LockedPanel_DateAddedLabel);
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
            LockedPanel.Controls.Add(LockedPanel_ExplorerGroupBox);
            LockedPanel.Location = new Point(361, 31);
            LockedPanel.Name = "LockedPanel";
            LockedPanel.Size = new Size(864, 944);
            LockedPanel.TabIndex = 24;
            // 
            // LockedPanel_TrashCanLabel
            // 
            LockedPanel_TrashCanLabel.AutoSize = true;
            LockedPanel_TrashCanLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_TrashCanLabel.Font = new Font("Segoe UI Emoji", 10F);
            LockedPanel_TrashCanLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_TrashCanLabel.Location = new Point(19, 166);
            LockedPanel_TrashCanLabel.Name = "LockedPanel_TrashCanLabel";
            LockedPanel_TrashCanLabel.Size = new Size(32, 19);
            LockedPanel_TrashCanLabel.TabIndex = 51;
            LockedPanel_TrashCanLabel.Text = "🗑️ ";
            LockedPanel_TrashCanLabel.Click += TrashCanLabel_Click;
            LockedPanel_TrashCanLabel.MouseEnter += Label_MouseEnter;
            LockedPanel_TrashCanLabel.MouseLeave += Label_MouseLeave;
            // 
            // LockedPanel_SignatureValueLabel
            // 
            LockedPanel_SignatureValueLabel.AutoSize = true;
            LockedPanel_SignatureValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_SignatureValueLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_SignatureValueLabel.Location = new Point(142, 164);
            LockedPanel_SignatureValueLabel.Name = "LockedPanel_SignatureValueLabel";
            LockedPanel_SignatureValueLabel.Size = new Size(128, 21);
            LockedPanel_SignatureValueLabel.TabIndex = 50;
            LockedPanel_SignatureValueLabel.Text = "<signature info>";
            // 
            // LockedPanel_SignatureLabel
            // 
            LockedPanel_SignatureLabel.AutoSize = true;
            LockedPanel_SignatureLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_SignatureLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_SignatureLabel.Location = new Point(46, 164);
            LockedPanel_SignatureLabel.Name = "LockedPanel_SignatureLabel";
            LockedPanel_SignatureLabel.Size = new Size(80, 21);
            LockedPanel_SignatureLabel.TabIndex = 49;
            LockedPanel_SignatureLabel.Text = "Signature:";
            // 
            // LockedPanel_SignGroupBox
            // 
            LockedPanel_SignGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_SignGroupBox.Controls.Add(LockedPanel_SignDescriptionLabel);
            LockedPanel_SignGroupBox.Controls.Add(LockedPanel_SignButton);
            LockedPanel_SignGroupBox.FlatStyle = FlatStyle.Flat;
            LockedPanel_SignGroupBox.ForeColor = SystemColors.ButtonFace;
            LockedPanel_SignGroupBox.Location = new Point(22, 516);
            LockedPanel_SignGroupBox.Name = "LockedPanel_SignGroupBox";
            LockedPanel_SignGroupBox.Size = new Size(807, 116);
            LockedPanel_SignGroupBox.TabIndex = 48;
            LockedPanel_SignGroupBox.TabStop = false;
            LockedPanel_SignGroupBox.Text = "Sign";
            // 
            // LockedPanel_SignDescriptionLabel
            // 
            LockedPanel_SignDescriptionLabel.AutoSize = true;
            LockedPanel_SignDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_SignDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_SignDescriptionLabel.Location = new Point(74, 53);
            LockedPanel_SignDescriptionLabel.Name = "LockedPanel_SignDescriptionLabel";
            LockedPanel_SignDescriptionLabel.Size = new Size(230, 21);
            LockedPanel_SignDescriptionLabel.TabIndex = 34;
            LockedPanel_SignDescriptionLabel.Text = "Sign the data with a private key.";
            // 
            // LockedPanel_SignButton
            // 
            LockedPanel_SignButton.BackColor = SystemColors.Highlight;
            LockedPanel_SignButton.FlatStyle = FlatStyle.Flat;
            LockedPanel_SignButton.Font = new Font("Segoe UI Emoji", 12F);
            LockedPanel_SignButton.ForeColor = SystemColors.ButtonFace;
            LockedPanel_SignButton.Location = new Point(669, 45);
            LockedPanel_SignButton.Name = "LockedPanel_SignButton";
            LockedPanel_SignButton.Size = new Size(105, 37);
            LockedPanel_SignButton.TabIndex = 6;
            LockedPanel_SignButton.Text = "    Sign 🖋️ ";
            LockedPanel_SignButton.UseVisualStyleBackColor = false;
            LockedPanel_SignButton.Click += SignButton_Click;
            // 
            // LockedPanel_DateAddedValueLabel
            // 
            LockedPanel_DateAddedValueLabel.AutoSize = true;
            LockedPanel_DateAddedValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_DateAddedValueLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_DateAddedValueLabel.Location = new Point(142, 143);
            LockedPanel_DateAddedValueLabel.Name = "LockedPanel_DateAddedValueLabel";
            LockedPanel_DateAddedValueLabel.Size = new Size(109, 21);
            LockedPanel_DateAddedValueLabel.TabIndex = 47;
            LockedPanel_DateAddedValueLabel.Text = "<date added>";
            // 
            // LockedPanel_DateAddedLabel
            // 
            LockedPanel_DateAddedLabel.AutoSize = true;
            LockedPanel_DateAddedLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_DateAddedLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_DateAddedLabel.Location = new Point(46, 143);
            LockedPanel_DateAddedLabel.Name = "LockedPanel_DateAddedLabel";
            LockedPanel_DateAddedLabel.Size = new Size(94, 21);
            LockedPanel_DateAddedLabel.TabIndex = 46;
            LockedPanel_DateAddedLabel.Text = "Date Added:";
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
            LockedPanel_ExportGroupBox.Location = new Point(22, 793);
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
            LockedPanel_ExportDescriptionLabel.Text = "Export the file and its cryptographic \r\ndata to a .zip archive.";
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
            LockedPanel_ShredGroupBox.Location = new Point(22, 374);
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
            LockedPanel_ShredButton.TabIndex = 9;
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
            LockedPanel_DecryptGroupBox.Location = new Point(22, 239);
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
            LockedPanel_DecryptButton.TabIndex = 8;
            LockedPanel_DecryptButton.Text = "Decrypt 🔑";
            LockedPanel_DecryptButton.UseVisualStyleBackColor = false;
            LockedPanel_DecryptButton.Click += DecryptButton_Click;
            // 
            // LockedPanel_ShaValueLabel
            // 
            LockedPanel_ShaValueLabel.AutoSize = true;
            LockedPanel_ShaValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_ShaValueLabel.ForeColor = SystemColors.ButtonFace;
            LockedPanel_ShaValueLabel.Location = new Point(142, 122);
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
            LockedPanel_SizeValueLabel.Location = new Point(142, 80);
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
            LockedPanel_PathValueLabel.Location = new Point(142, 101);
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
            LockedPanel_AlgorithmValueLabel.Location = new Point(142, 184);
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
            LockedPanel_AlgorithmLabel.Location = new Point(46, 184);
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
            LockedPanel_StatusValueLabel.Location = new Point(142, 59);
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
            // LockedPanel_ExplorerGroupBox
            // 
            LockedPanel_ExplorerGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            LockedPanel_ExplorerGroupBox.Controls.Add(LockedPanel_ExplorerDescriptionLabel);
            LockedPanel_ExplorerGroupBox.Controls.Add(LockedPanel_ExplorerButton);
            LockedPanel_ExplorerGroupBox.FlatStyle = FlatStyle.Flat;
            LockedPanel_ExplorerGroupBox.ForeColor = SystemColors.ButtonFace;
            LockedPanel_ExplorerGroupBox.Location = new Point(22, 654);
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
            LockedPanel_ExplorerDescriptionLabel.Size = new Size(216, 21);
            LockedPanel_ExplorerDescriptionLabel.TabIndex = 34;
            LockedPanel_ExplorerDescriptionLabel.Text = "Reveal the file in File Explorer.";
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
            RelocationPanel.Size = new Size(864, 944);
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
            UnlockedPanel.Controls.Add(UnlockedPanel_TrashCanLabel);
            UnlockedPanel.Controls.Add(UnlockedPanel_SignatureValueLabel);
            UnlockedPanel.Controls.Add(UnlockedPanel_SignatureLabel);
            UnlockedPanel.Controls.Add(UnlockedPanel_SignGroupBox);
            UnlockedPanel.Controls.Add(UnlockedPanel_DateAddedValueLabel);
            UnlockedPanel.Controls.Add(UnlockedPanel_DateAddedLabel);
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
            UnlockedPanel.Size = new Size(864, 944);
            UnlockedPanel.TabIndex = 35;
            // 
            // UnlockedPanel_TrashCanLabel
            // 
            UnlockedPanel_TrashCanLabel.AutoSize = true;
            UnlockedPanel_TrashCanLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_TrashCanLabel.Font = new Font("Segoe UI Emoji", 10F);
            UnlockedPanel_TrashCanLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_TrashCanLabel.Location = new Point(19, 166);
            UnlockedPanel_TrashCanLabel.Name = "UnlockedPanel_TrashCanLabel";
            UnlockedPanel_TrashCanLabel.Size = new Size(32, 19);
            UnlockedPanel_TrashCanLabel.TabIndex = 7;
            UnlockedPanel_TrashCanLabel.Text = "🗑️ ";
            UnlockedPanel_TrashCanLabel.Click += TrashCanLabel_Click;
            UnlockedPanel_TrashCanLabel.MouseEnter += Label_MouseEnter;
            UnlockedPanel_TrashCanLabel.MouseLeave += Label_MouseLeave;
            // 
            // UnlockedPanel_SignatureValueLabel
            // 
            UnlockedPanel_SignatureValueLabel.AutoSize = true;
            UnlockedPanel_SignatureValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_SignatureValueLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_SignatureValueLabel.Location = new Point(142, 164);
            UnlockedPanel_SignatureValueLabel.Name = "UnlockedPanel_SignatureValueLabel";
            UnlockedPanel_SignatureValueLabel.Size = new Size(128, 21);
            UnlockedPanel_SignatureValueLabel.TabIndex = 46;
            UnlockedPanel_SignatureValueLabel.Text = "<signature info>";
            // 
            // UnlockedPanel_SignatureLabel
            // 
            UnlockedPanel_SignatureLabel.AutoSize = true;
            UnlockedPanel_SignatureLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_SignatureLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_SignatureLabel.Location = new Point(46, 164);
            UnlockedPanel_SignatureLabel.Name = "UnlockedPanel_SignatureLabel";
            UnlockedPanel_SignatureLabel.Size = new Size(80, 21);
            UnlockedPanel_SignatureLabel.TabIndex = 45;
            UnlockedPanel_SignatureLabel.Text = "Signature:";
            // 
            // UnlockedPanel_SignGroupBox
            // 
            UnlockedPanel_SignGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_SignGroupBox.Controls.Add(UnlockedPanel_SignDescriptionLabel);
            UnlockedPanel_SignGroupBox.Controls.Add(UnlockedPanel_SignButton);
            UnlockedPanel_SignGroupBox.FlatStyle = FlatStyle.Flat;
            UnlockedPanel_SignGroupBox.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_SignGroupBox.Location = new Point(22, 516);
            UnlockedPanel_SignGroupBox.Name = "UnlockedPanel_SignGroupBox";
            UnlockedPanel_SignGroupBox.Size = new Size(807, 116);
            UnlockedPanel_SignGroupBox.TabIndex = 36;
            UnlockedPanel_SignGroupBox.TabStop = false;
            UnlockedPanel_SignGroupBox.Text = "Sign";
            // 
            // UnlockedPanel_SignDescriptionLabel
            // 
            UnlockedPanel_SignDescriptionLabel.AutoSize = true;
            UnlockedPanel_SignDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_SignDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_SignDescriptionLabel.Location = new Point(74, 53);
            UnlockedPanel_SignDescriptionLabel.Name = "UnlockedPanel_SignDescriptionLabel";
            UnlockedPanel_SignDescriptionLabel.Size = new Size(230, 21);
            UnlockedPanel_SignDescriptionLabel.TabIndex = 34;
            UnlockedPanel_SignDescriptionLabel.Text = "Sign the data with a private key.";
            // 
            // UnlockedPanel_SignButton
            // 
            UnlockedPanel_SignButton.BackColor = SystemColors.Highlight;
            UnlockedPanel_SignButton.FlatStyle = FlatStyle.Flat;
            UnlockedPanel_SignButton.Font = new Font("Segoe UI Emoji", 12F);
            UnlockedPanel_SignButton.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_SignButton.Location = new Point(669, 45);
            UnlockedPanel_SignButton.Name = "UnlockedPanel_SignButton";
            UnlockedPanel_SignButton.Size = new Size(105, 37);
            UnlockedPanel_SignButton.TabIndex = 3;
            UnlockedPanel_SignButton.Text = "    Sign 🖋️ ";
            UnlockedPanel_SignButton.UseVisualStyleBackColor = false;
            UnlockedPanel_SignButton.Click += SignButton_Click;
            // 
            // UnlockedPanel_DateAddedValueLabel
            // 
            UnlockedPanel_DateAddedValueLabel.AutoSize = true;
            UnlockedPanel_DateAddedValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_DateAddedValueLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_DateAddedValueLabel.Location = new Point(142, 143);
            UnlockedPanel_DateAddedValueLabel.Name = "UnlockedPanel_DateAddedValueLabel";
            UnlockedPanel_DateAddedValueLabel.Size = new Size(109, 21);
            UnlockedPanel_DateAddedValueLabel.TabIndex = 44;
            UnlockedPanel_DateAddedValueLabel.Text = "<date added>";
            // 
            // UnlockedPanel_DateAddedLabel
            // 
            UnlockedPanel_DateAddedLabel.AutoSize = true;
            UnlockedPanel_DateAddedLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_DateAddedLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_DateAddedLabel.Location = new Point(46, 143);
            UnlockedPanel_DateAddedLabel.Name = "UnlockedPanel_DateAddedLabel";
            UnlockedPanel_DateAddedLabel.Size = new Size(94, 21);
            UnlockedPanel_DateAddedLabel.TabIndex = 43;
            UnlockedPanel_DateAddedLabel.Text = "Date Added:";
            // 
            // UnlockedPanel_ExplorerGroupBox
            // 
            UnlockedPanel_ExplorerGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_ExplorerGroupBox.Controls.Add(UnlockedPanel_ExplorerDescriptionLabel);
            UnlockedPanel_ExplorerGroupBox.Controls.Add(UnlockedPanel_ExplorerButton);
            UnlockedPanel_ExplorerGroupBox.FlatStyle = FlatStyle.Flat;
            UnlockedPanel_ExplorerGroupBox.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_ExplorerGroupBox.Location = new Point(22, 654);
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
            UnlockedPanel_ExplorerDescriptionLabel.Size = new Size(216, 21);
            UnlockedPanel_ExplorerDescriptionLabel.TabIndex = 34;
            UnlockedPanel_ExplorerDescriptionLabel.Text = "Reveal the file in File Explorer.";
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
            UnlockedPanel_ExplorerButton.TabIndex = 4;
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
            UnlockedPanel_ShaClipboardLabel.TabIndex = 6;
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
            UnlockedPanel_PathClipboardLabel.TabIndex = 5;
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
            UnlockedPanel_ShredGroupBox.Location = new Point(22, 374);
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
            UnlockedPanel_ShredButton.TabIndex = 2;
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
            UnlockedPanel_EncryptGroupBox.Location = new Point(22, 239);
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
            UnlockedPanel_EncryptButton.TabIndex = 1;
            UnlockedPanel_EncryptButton.Text = "Encrypt 🔐";
            UnlockedPanel_EncryptButton.UseVisualStyleBackColor = false;
            UnlockedPanel_EncryptButton.Click += EncryptButton_Click;
            // 
            // UnlockedPanel_ShaValueLabel
            // 
            UnlockedPanel_ShaValueLabel.AutoSize = true;
            UnlockedPanel_ShaValueLabel.BackColor = Color.FromArgb(32, 32, 32);
            UnlockedPanel_ShaValueLabel.ForeColor = SystemColors.ButtonFace;
            UnlockedPanel_ShaValueLabel.Location = new Point(142, 122);
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
            UnlockedPanel_SizeValueLabel.Location = new Point(142, 80);
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
            UnlockedPanel_PathValueLabel.Location = new Point(142, 101);
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
            UnlockedPanel_StatusValueLabel.Location = new Point(142, 59);
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
            // KeysPanel
            // 
            KeysPanel.BackColor = Color.FromArgb(32, 32, 32);
            KeysPanel.BorderStyle = BorderStyle.FixedSingle;
            KeysPanel.Controls.Add(KeysPanel_MagnifyingGlassLabel);
            KeysPanel.Controls.Add(KeysPanel_SearchTextBox);
            KeysPanel.Controls.Add(KeysPanel_OtherKeysRadioButton);
            KeysPanel.Controls.Add(KeysPanel_MyKeysRadioButton);
            KeysPanel.Controls.Add(KeysPanel_ImportGroupBox);
            KeysPanel.Controls.Add(KeysPanel_ListBox);
            KeysPanel.Controls.Add(KeysPanel_CreateGroupBox);
            KeysPanel.Controls.Add(KeysPanel_KeysLabel);
            KeysPanel.Location = new Point(361, 31);
            KeysPanel.Name = "KeysPanel";
            KeysPanel.Size = new Size(864, 944);
            KeysPanel.TabIndex = 67;
            // 
            // KeysPanel_MagnifyingGlassLabel
            // 
            KeysPanel_MagnifyingGlassLabel.AutoSize = true;
            KeysPanel_MagnifyingGlassLabel.BackColor = Color.FromArgb(32, 32, 32);
            KeysPanel_MagnifyingGlassLabel.Font = new Font("Segoe UI Emoji", 12F);
            KeysPanel_MagnifyingGlassLabel.ForeColor = SystemColors.ButtonFace;
            KeysPanel_MagnifyingGlassLabel.Location = new Point(246, 500);
            KeysPanel_MagnifyingGlassLabel.Name = "KeysPanel_MagnifyingGlassLabel";
            KeysPanel_MagnifyingGlassLabel.Size = new Size(32, 21);
            KeysPanel_MagnifyingGlassLabel.TabIndex = 68;
            KeysPanel_MagnifyingGlassLabel.Text = "🔍";
            // 
            // KeysPanel_SearchTextBox
            // 
            KeysPanel_SearchTextBox.BackColor = Color.FromArgb(32, 32, 32);
            KeysPanel_SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            KeysPanel_SearchTextBox.Font = new Font("Segoe UI Emoji", 12F);
            KeysPanel_SearchTextBox.ForeColor = SystemColors.ButtonFace;
            KeysPanel_SearchTextBox.Location = new Point(22, 498);
            KeysPanel_SearchTextBox.Name = "KeysPanel_SearchTextBox";
            KeysPanel_SearchTextBox.Size = new Size(261, 29);
            KeysPanel_SearchTextBox.TabIndex = 68;
            KeysPanel_SearchTextBox.TextChanged += KeysPanel_SearchTextBox_TextChanged;
            // 
            // KeysPanel_OtherKeysRadioButton
            // 
            KeysPanel_OtherKeysRadioButton.AutoSize = true;
            KeysPanel_OtherKeysRadioButton.ForeColor = SystemColors.ButtonFace;
            KeysPanel_OtherKeysRadioButton.Location = new Point(726, 498);
            KeysPanel_OtherKeysRadioButton.Name = "KeysPanel_OtherKeysRadioButton";
            KeysPanel_OtherKeysRadioButton.Size = new Size(103, 25);
            KeysPanel_OtherKeysRadioButton.TabIndex = 70;
            KeysPanel_OtherKeysRadioButton.Text = "Other keys";
            KeysPanel_OtherKeysRadioButton.UseVisualStyleBackColor = true;
            KeysPanel_OtherKeysRadioButton.CheckedChanged += KeysRadioButton_CheckedChanged;
            // 
            // KeysPanel_MyKeysRadioButton
            // 
            KeysPanel_MyKeysRadioButton.AutoSize = true;
            KeysPanel_MyKeysRadioButton.Checked = true;
            KeysPanel_MyKeysRadioButton.ForeColor = SystemColors.ButtonFace;
            KeysPanel_MyKeysRadioButton.Location = new Point(635, 498);
            KeysPanel_MyKeysRadioButton.Name = "KeysPanel_MyKeysRadioButton";
            KeysPanel_MyKeysRadioButton.Size = new Size(85, 25);
            KeysPanel_MyKeysRadioButton.TabIndex = 69;
            KeysPanel_MyKeysRadioButton.TabStop = true;
            KeysPanel_MyKeysRadioButton.Text = "My keys";
            KeysPanel_MyKeysRadioButton.UseVisualStyleBackColor = true;
            KeysPanel_MyKeysRadioButton.CheckedChanged += KeysRadioButton_CheckedChanged;
            // 
            // KeysPanel_ImportGroupBox
            // 
            KeysPanel_ImportGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            KeysPanel_ImportGroupBox.Controls.Add(KeysPanel_ImportDescriptionLabel);
            KeysPanel_ImportGroupBox.Controls.Add(KeysPanel_ImportButton);
            KeysPanel_ImportGroupBox.FlatStyle = FlatStyle.Flat;
            KeysPanel_ImportGroupBox.ForeColor = SystemColors.ButtonFace;
            KeysPanel_ImportGroupBox.Location = new Point(22, 346);
            KeysPanel_ImportGroupBox.Name = "KeysPanel_ImportGroupBox";
            KeysPanel_ImportGroupBox.Size = new Size(807, 116);
            KeysPanel_ImportGroupBox.TabIndex = 34;
            KeysPanel_ImportGroupBox.TabStop = false;
            KeysPanel_ImportGroupBox.Text = "Import";
            // 
            // KeysPanel_ImportDescriptionLabel
            // 
            KeysPanel_ImportDescriptionLabel.AutoSize = true;
            KeysPanel_ImportDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            KeysPanel_ImportDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            KeysPanel_ImportDescriptionLabel.Location = new Point(64, 50);
            KeysPanel_ImportDescriptionLabel.Name = "KeysPanel_ImportDescriptionLabel";
            KeysPanel_ImportDescriptionLabel.Size = new Size(212, 21);
            KeysPanel_ImportDescriptionLabel.TabIndex = 33;
            KeysPanel_ImportDescriptionLabel.Text = "Import an existing public key.";
            // 
            // KeysPanel_ImportButton
            // 
            KeysPanel_ImportButton.BackColor = SystemColors.Highlight;
            KeysPanel_ImportButton.FlatStyle = FlatStyle.Flat;
            KeysPanel_ImportButton.Font = new Font("Segoe UI Emoji", 12F);
            KeysPanel_ImportButton.ForeColor = SystemColors.ButtonFace;
            KeysPanel_ImportButton.Location = new Point(681, 42);
            KeysPanel_ImportButton.Name = "KeysPanel_ImportButton";
            KeysPanel_ImportButton.Size = new Size(93, 37);
            KeysPanel_ImportButton.TabIndex = 29;
            KeysPanel_ImportButton.Text = "Import 📥 ";
            KeysPanel_ImportButton.UseVisualStyleBackColor = false;
            KeysPanel_ImportButton.Click += KeysPanel_ImportButton_Click;
            // 
            // KeysPanel_ListBox
            // 
            KeysPanel_ListBox.AllowDrop = true;
            KeysPanel_ListBox.BackColor = Color.FromArgb(40, 40, 40);
            KeysPanel_ListBox.BorderStyle = BorderStyle.FixedSingle;
            KeysPanel_ListBox.ContextMenuStrip = KeysListBoxContextMenuStrip;
            KeysPanel_ListBox.DrawMode = DrawMode.OwnerDrawFixed;
            KeysPanel_ListBox.Font = new Font("Segoe UI Emoji", 12F);
            KeysPanel_ListBox.ForeColor = SystemColors.ButtonFace;
            KeysPanel_ListBox.FormattingEnabled = true;
            KeysPanel_ListBox.ItemHeight = 25;
            KeysPanel_ListBox.Location = new Point(22, 533);
            KeysPanel_ListBox.Name = "KeysPanel_ListBox";
            KeysPanel_ListBox.Size = new Size(807, 377);
            KeysPanel_ListBox.TabIndex = 68;
            KeysPanel_ListBox.DrawItem += KeysPanel_ListBox_DrawItem;
            // 
            // KeysListBoxContextMenuStrip
            // 
            KeysListBoxContextMenuStrip.Items.AddRange(new ToolStripItem[] { MyKeysListBox_DeleteItem, MyKeysListBox_ExportItem });
            KeysListBoxContextMenuStrip.Name = "FileListBoxItemContextMenuStrip";
            KeysListBoxContextMenuStrip.Size = new Size(109, 48);
            KeysListBoxContextMenuStrip.Tag = "FileListBox";
            KeysListBoxContextMenuStrip.Text = "Remove File";
            // 
            // MyKeysListBox_DeleteItem
            // 
            MyKeysListBox_DeleteItem.BackColor = Color.FromArgb(40, 40, 40);
            MyKeysListBox_DeleteItem.ForeColor = SystemColors.ButtonFace;
            MyKeysListBox_DeleteItem.Name = "MyKeysListBox_DeleteItem";
            MyKeysListBox_DeleteItem.Size = new Size(108, 22);
            MyKeysListBox_DeleteItem.Text = "Delete";
            MyKeysListBox_DeleteItem.Click += KeysListBox_DeleteItem_Click;
            // 
            // MyKeysListBox_ExportItem
            // 
            MyKeysListBox_ExportItem.BackColor = Color.FromArgb(40, 40, 40);
            MyKeysListBox_ExportItem.ForeColor = SystemColors.ButtonFace;
            MyKeysListBox_ExportItem.Name = "MyKeysListBox_ExportItem";
            MyKeysListBox_ExportItem.Size = new Size(108, 22);
            MyKeysListBox_ExportItem.Text = "Export";
            MyKeysListBox_ExportItem.Click += KeyListBox_ExportItem_Click;
            // 
            // KeysPanel_CreateGroupBox
            // 
            KeysPanel_CreateGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            KeysPanel_CreateGroupBox.Controls.Add(KeysPanel_CreateDescriptionLabel);
            KeysPanel_CreateGroupBox.Controls.Add(KeysPanel_CreateButton);
            KeysPanel_CreateGroupBox.FlatStyle = FlatStyle.Flat;
            KeysPanel_CreateGroupBox.ForeColor = SystemColors.ButtonFace;
            KeysPanel_CreateGroupBox.Location = new Point(22, 208);
            KeysPanel_CreateGroupBox.Name = "KeysPanel_CreateGroupBox";
            KeysPanel_CreateGroupBox.Size = new Size(807, 116);
            KeysPanel_CreateGroupBox.TabIndex = 31;
            KeysPanel_CreateGroupBox.TabStop = false;
            KeysPanel_CreateGroupBox.Text = "Create";
            // 
            // KeysPanel_CreateDescriptionLabel
            // 
            KeysPanel_CreateDescriptionLabel.AutoSize = true;
            KeysPanel_CreateDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            KeysPanel_CreateDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            KeysPanel_CreateDescriptionLabel.Location = new Point(64, 42);
            KeysPanel_CreateDescriptionLabel.Name = "KeysPanel_CreateDescriptionLabel";
            KeysPanel_CreateDescriptionLabel.Size = new Size(200, 42);
            KeysPanel_CreateDescriptionLabel.TabIndex = 33;
            KeysPanel_CreateDescriptionLabel.Text = "Create a new public/private\r\nkey pair.";
            // 
            // KeysPanel_CreateButton
            // 
            KeysPanel_CreateButton.BackColor = Color.DarkGreen;
            KeysPanel_CreateButton.FlatStyle = FlatStyle.Flat;
            KeysPanel_CreateButton.Font = new Font("Segoe UI Emoji", 12F);
            KeysPanel_CreateButton.ForeColor = SystemColors.ButtonFace;
            KeysPanel_CreateButton.Location = new Point(681, 42);
            KeysPanel_CreateButton.Name = "KeysPanel_CreateButton";
            KeysPanel_CreateButton.Size = new Size(93, 37);
            KeysPanel_CreateButton.TabIndex = 29;
            KeysPanel_CreateButton.Text = "Create +";
            KeysPanel_CreateButton.UseVisualStyleBackColor = false;
            KeysPanel_CreateButton.Click += KeysPanel_CreateButton_Click;
            // 
            // KeysPanel_KeysLabel
            // 
            KeysPanel_KeysLabel.AutoSize = true;
            KeysPanel_KeysLabel.Font = new Font("Segoe UI Emoji", 20.25F);
            KeysPanel_KeysLabel.ForeColor = SystemColors.ButtonFace;
            KeysPanel_KeysLabel.Location = new Point(391, 125);
            KeysPanel_KeysLabel.Name = "KeysPanel_KeysLabel";
            KeysPanel_KeysLabel.Size = new Size(69, 36);
            KeysPanel_KeysLabel.TabIndex = 8;
            KeysPanel_KeysLabel.Text = "Keys";
            // 
            // LogsPanel
            // 
            LogsPanel.BackColor = Color.FromArgb(32, 32, 32);
            LogsPanel.BorderStyle = BorderStyle.FixedSingle;
            LogsPanel.Controls.Add(LogsPanel_FilterGroupBox);
            LogsPanel.Controls.Add(LogsPanel_MagnifyingGlassLabel);
            LogsPanel.Controls.Add(LogsPanel_SearchTextBox);
            LogsPanel.Controls.Add(LogsPanel_ListBox);
            LogsPanel.Controls.Add(LogsPanel_LogsLabel);
            LogsPanel.Location = new Point(361, 31);
            LogsPanel.Name = "LogsPanel";
            LogsPanel.Size = new Size(864, 944);
            LogsPanel.TabIndex = 71;
            // 
            // LogsPanel_FilterGroupBox
            // 
            LogsPanel_FilterGroupBox.BackColor = Color.FromArgb(32, 32, 32);
            LogsPanel_FilterGroupBox.Controls.Add(LogsPanel_LevelLabel);
            LogsPanel_FilterGroupBox.Controls.Add(LogsPanel_LevelComboBox);
            LogsPanel_FilterGroupBox.Controls.Add(LogsPanel_LastDayRadioButton);
            LogsPanel_FilterGroupBox.Controls.Add(LogsPanel_LastWeekRadioButton);
            LogsPanel_FilterGroupBox.Controls.Add(LogsPanel_LastMonthRadioButton);
            LogsPanel_FilterGroupBox.Controls.Add(LogsPanel_AllTimeRadioButton);
            LogsPanel_FilterGroupBox.Controls.Add(LogsPanel_FilterDescriptionLabel);
            LogsPanel_FilterGroupBox.FlatStyle = FlatStyle.Flat;
            LogsPanel_FilterGroupBox.ForeColor = SystemColors.ButtonFace;
            LogsPanel_FilterGroupBox.Location = new Point(22, 208);
            LogsPanel_FilterGroupBox.Name = "LogsPanel_FilterGroupBox";
            LogsPanel_FilterGroupBox.Size = new Size(807, 248);
            LogsPanel_FilterGroupBox.TabIndex = 77;
            LogsPanel_FilterGroupBox.TabStop = false;
            LogsPanel_FilterGroupBox.Text = "Filter";
            // 
            // LogsPanel_LevelLabel
            // 
            LogsPanel_LevelLabel.AutoSize = true;
            LogsPanel_LevelLabel.BackColor = Color.FromArgb(32, 32, 32);
            LogsPanel_LevelLabel.ForeColor = SystemColors.ButtonFace;
            LogsPanel_LevelLabel.Location = new Point(54, 98);
            LogsPanel_LevelLabel.Name = "LogsPanel_LevelLabel";
            LogsPanel_LevelLabel.Size = new Size(49, 21);
            LogsPanel_LevelLabel.TabIndex = 76;
            LogsPanel_LevelLabel.Text = "Level:";
            // 
            // LogsPanel_LevelComboBox
            // 
            LogsPanel_LevelComboBox.BackColor = Color.FromArgb(52, 52, 52);
            LogsPanel_LevelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LogsPanel_LevelComboBox.ForeColor = SystemColors.ButtonFace;
            LogsPanel_LevelComboBox.FormattingEnabled = true;
            LogsPanel_LevelComboBox.Location = new Point(110, 95);
            LogsPanel_LevelComboBox.Name = "LogsPanel_LevelComboBox";
            LogsPanel_LevelComboBox.Size = new Size(197, 29);
            LogsPanel_LevelComboBox.TabIndex = 75;
            LogsPanel_LevelComboBox.SelectedIndexChanged += LogsPanel_LevelComboBox_SelectedIndexChanged;
            // 
            // LogsPanel_LastDayRadioButton
            // 
            LogsPanel_LastDayRadioButton.AutoSize = true;
            LogsPanel_LastDayRadioButton.ForeColor = SystemColors.ButtonFace;
            LogsPanel_LastDayRadioButton.Location = new Point(110, 208);
            LogsPanel_LastDayRadioButton.Name = "LogsPanel_LastDayRadioButton";
            LogsPanel_LastDayRadioButton.Size = new Size(87, 25);
            LogsPanel_LastDayRadioButton.TabIndex = 74;
            LogsPanel_LastDayRadioButton.Text = "Last Day";
            LogsPanel_LastDayRadioButton.UseVisualStyleBackColor = true;
            LogsPanel_LastDayRadioButton.CheckedChanged += LogsRadioButton_CheckedChanged;
            // 
            // LogsPanel_LastWeekRadioButton
            // 
            LogsPanel_LastWeekRadioButton.AutoSize = true;
            LogsPanel_LastWeekRadioButton.ForeColor = SystemColors.ButtonFace;
            LogsPanel_LastWeekRadioButton.Location = new Point(110, 183);
            LogsPanel_LastWeekRadioButton.Name = "LogsPanel_LastWeekRadioButton";
            LogsPanel_LastWeekRadioButton.Size = new Size(99, 25);
            LogsPanel_LastWeekRadioButton.TabIndex = 73;
            LogsPanel_LastWeekRadioButton.Text = "Last Week";
            LogsPanel_LastWeekRadioButton.UseVisualStyleBackColor = true;
            LogsPanel_LastWeekRadioButton.CheckedChanged += LogsRadioButton_CheckedChanged;
            // 
            // LogsPanel_LastMonthRadioButton
            // 
            LogsPanel_LastMonthRadioButton.AutoSize = true;
            LogsPanel_LastMonthRadioButton.ForeColor = SystemColors.ButtonFace;
            LogsPanel_LastMonthRadioButton.Location = new Point(110, 160);
            LogsPanel_LastMonthRadioButton.Name = "LogsPanel_LastMonthRadioButton";
            LogsPanel_LastMonthRadioButton.Size = new Size(106, 25);
            LogsPanel_LastMonthRadioButton.TabIndex = 72;
            LogsPanel_LastMonthRadioButton.Text = "Last Month";
            LogsPanel_LastMonthRadioButton.UseVisualStyleBackColor = true;
            LogsPanel_LastMonthRadioButton.CheckedChanged += LogsRadioButton_CheckedChanged;
            // 
            // LogsPanel_AllTimeRadioButton
            // 
            LogsPanel_AllTimeRadioButton.AutoSize = true;
            LogsPanel_AllTimeRadioButton.Checked = true;
            LogsPanel_AllTimeRadioButton.ForeColor = SystemColors.ButtonFace;
            LogsPanel_AllTimeRadioButton.Location = new Point(110, 135);
            LogsPanel_AllTimeRadioButton.Name = "LogsPanel_AllTimeRadioButton";
            LogsPanel_AllTimeRadioButton.Size = new Size(81, 25);
            LogsPanel_AllTimeRadioButton.TabIndex = 71;
            LogsPanel_AllTimeRadioButton.TabStop = true;
            LogsPanel_AllTimeRadioButton.Text = "All time";
            LogsPanel_AllTimeRadioButton.UseVisualStyleBackColor = true;
            LogsPanel_AllTimeRadioButton.CheckedChanged += LogsRadioButton_CheckedChanged;
            // 
            // LogsPanel_FilterDescriptionLabel
            // 
            LogsPanel_FilterDescriptionLabel.AutoSize = true;
            LogsPanel_FilterDescriptionLabel.BackColor = Color.FromArgb(32, 32, 32);
            LogsPanel_FilterDescriptionLabel.ForeColor = SystemColors.ButtonFace;
            LogsPanel_FilterDescriptionLabel.Location = new Point(54, 50);
            LogsPanel_FilterDescriptionLabel.Name = "LogsPanel_FilterDescriptionLabel";
            LogsPanel_FilterDescriptionLabel.Size = new Size(297, 21);
            LogsPanel_FilterDescriptionLabel.TabIndex = 33;
            LogsPanel_FilterDescriptionLabel.Text = "Filter logs using the specified parameters.\r\n";
            // 
            // LogsPanel_MagnifyingGlassLabel
            // 
            LogsPanel_MagnifyingGlassLabel.AutoSize = true;
            LogsPanel_MagnifyingGlassLabel.BackColor = Color.FromArgb(32, 32, 32);
            LogsPanel_MagnifyingGlassLabel.Font = new Font("Segoe UI Emoji", 12F);
            LogsPanel_MagnifyingGlassLabel.ForeColor = SystemColors.ButtonFace;
            LogsPanel_MagnifyingGlassLabel.Location = new Point(246, 500);
            LogsPanel_MagnifyingGlassLabel.Name = "LogsPanel_MagnifyingGlassLabel";
            LogsPanel_MagnifyingGlassLabel.Size = new Size(32, 21);
            LogsPanel_MagnifyingGlassLabel.TabIndex = 74;
            LogsPanel_MagnifyingGlassLabel.Text = "🔍";
            // 
            // LogsPanel_SearchTextBox
            // 
            LogsPanel_SearchTextBox.BackColor = Color.FromArgb(32, 32, 32);
            LogsPanel_SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            LogsPanel_SearchTextBox.Font = new Font("Segoe UI Emoji", 12F);
            LogsPanel_SearchTextBox.ForeColor = SystemColors.ButtonFace;
            LogsPanel_SearchTextBox.Location = new Point(22, 498);
            LogsPanel_SearchTextBox.Name = "LogsPanel_SearchTextBox";
            LogsPanel_SearchTextBox.Size = new Size(261, 29);
            LogsPanel_SearchTextBox.TabIndex = 75;
            LogsPanel_SearchTextBox.TextChanged += LogsPanel_SearchTextBox_TextChanged;
            // 
            // LogsPanel_ListBox
            // 
            LogsPanel_ListBox.AllowDrop = true;
            LogsPanel_ListBox.BackColor = Color.FromArgb(40, 40, 40);
            LogsPanel_ListBox.BorderStyle = BorderStyle.FixedSingle;
            LogsPanel_ListBox.DrawMode = DrawMode.OwnerDrawFixed;
            LogsPanel_ListBox.Font = new Font("Segoe UI Emoji", 12F);
            LogsPanel_ListBox.ForeColor = SystemColors.ButtonFace;
            LogsPanel_ListBox.FormattingEnabled = true;
            LogsPanel_ListBox.ItemHeight = 25;
            LogsPanel_ListBox.Location = new Point(22, 533);
            LogsPanel_ListBox.Name = "LogsPanel_ListBox";
            LogsPanel_ListBox.Size = new Size(807, 377);
            LogsPanel_ListBox.TabIndex = 76;
            LogsPanel_ListBox.DrawItem += LogsPanel_ListBox_DrawItem;
            // 
            // LogsPanel_LogsLabel
            // 
            LogsPanel_LogsLabel.AutoSize = true;
            LogsPanel_LogsLabel.Font = new Font("Segoe UI Emoji", 20.25F);
            LogsPanel_LogsLabel.ForeColor = SystemColors.ButtonFace;
            LogsPanel_LogsLabel.Location = new Point(391, 125);
            LogsPanel_LogsLabel.Name = "LogsPanel_LogsLabel";
            LogsPanel_LogsLabel.Size = new Size(71, 36);
            LogsPanel_LogsLabel.TabIndex = 71;
            LogsPanel_LogsLabel.Text = "Logs";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1217, 971);
            Controls.Add(AddButton);
            Controls.Add(MagnifyingGlassLabel);
            Controls.Add(SearchTextBox);
            Controls.Add(FileListBox);
            Controls.Add(MenuStrip);
            Controls.Add(UnlockedPanel);
            Controls.Add(NoFilesPanel);
            Controls.Add(RelocationPanel);
            Controls.Add(LockedPanel);
            Controls.Add(LogsPanel);
            Controls.Add(KeysPanel);
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
            LockedPanel_SignGroupBox.ResumeLayout(false);
            LockedPanel_SignGroupBox.PerformLayout();
            LockedPanel_ExportGroupBox.ResumeLayout(false);
            LockedPanel_ExportGroupBox.PerformLayout();
            LockedPanel_ShredGroupBox.ResumeLayout(false);
            LockedPanel_ShredGroupBox.PerformLayout();
            LockedPanel_DecryptGroupBox.ResumeLayout(false);
            LockedPanel_DecryptGroupBox.PerformLayout();
            LockedPanel_ExplorerGroupBox.ResumeLayout(false);
            LockedPanel_ExplorerGroupBox.PerformLayout();
            RelocationPanel.ResumeLayout(false);
            RelocationPanel.PerformLayout();
            UnlockedPanel.ResumeLayout(false);
            UnlockedPanel.PerformLayout();
            UnlockedPanel_SignGroupBox.ResumeLayout(false);
            UnlockedPanel_SignGroupBox.PerformLayout();
            UnlockedPanel_ExplorerGroupBox.ResumeLayout(false);
            UnlockedPanel_ExplorerGroupBox.PerformLayout();
            UnlockedPanel_ShredGroupBox.ResumeLayout(false);
            UnlockedPanel_ShredGroupBox.PerformLayout();
            UnlockedPanel_EncryptGroupBox.ResumeLayout(false);
            UnlockedPanel_EncryptGroupBox.PerformLayout();
            KeysPanel.ResumeLayout(false);
            KeysPanel.PerformLayout();
            KeysPanel_ImportGroupBox.ResumeLayout(false);
            KeysPanel_ImportGroupBox.PerformLayout();
            KeysListBoxContextMenuStrip.ResumeLayout(false);
            KeysPanel_CreateGroupBox.ResumeLayout(false);
            KeysPanel_CreateGroupBox.PerformLayout();
            LogsPanel.ResumeLayout(false);
            LogsPanel.PerformLayout();
            LogsPanel_FilterGroupBox.ResumeLayout(false);
            LogsPanel_FilterGroupBox.PerformLayout();
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
        private ToolStripMenuItem KeysMenuItem;
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
        private ComboBox LogsPanel_LevelComboBox;
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
        private ToolStripMenuItem FileListBox_RemoveFromListItem;
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
        private Label UnlockedPanel_DateAddedValueLabel;
        private Label UnlockedPanel_DateAddedLabel;
        private Label LockedPanel_DateAddedValueLabel;
        private Label LockedPanel_DateAddedLabel;
        private GroupBox UnlockedPanel_SignGroupBox;
        private Label UnlockedPanel_SignDescriptionLabel;
        private Button UnlockedPanel_SignButton;
        private Panel KeysPanel;
        private GroupBox KeysPanel_CreateGroupBox;
        private Label KeysPanel_CreateDescriptionLabel;
        private Button KeysPanel_CreateButton;
        private Label KeysPanel_KeysLabel;
        private ListBox KeysPanel_ListBox;
        private ContextMenuStrip KeysListBoxContextMenuStrip;
        private ToolStripMenuItem MyKeysListBox_DeleteItem;
        private GroupBox KeysPanel_ImportGroupBox;
        private Label KeysPanel_ImportDescriptionLabel;
        private Button KeysPanel_ImportButton;
        private ToolStripMenuItem MyKeysListBox_ExportItem;
        private Label KeysPanel_MyKeysLabel;
        private GroupBox LockedPanel_SignGroupBox;
        private Label LockedPanel_SignDescriptionLabel;
        private Button LockedPanel_SignButton;
        private Label LockedPanel_SignatureValueLabel;
        private Label LockedPanel_SignatureLabel;
        private Label UnlockedPanel_SignatureValueLabel;
        private Label UnlockedPanel_SignatureLabel;
        private Label LockedPanel_TrashCanLabel;
        private Label UnlockedPanel_TrashCanLabel;
        private RadioButton KeysPanel_MyKeysRadioButton;
        private TextBox KeysPanel_SearchTextBox;
        private RadioButton KeysPanel_OtherKeysRadioButton;
        private Label KeysPanel_MagnifyingGlassLabel;
        private Panel LogsPanel;
        private Label LogsPanel_MagnifyingGlassLabel;
        private TextBox LogsPanel_SearchTextBox;
        private GroupBox groupBox1;
        private Label label2;
        private Button button1;
        private ListBox LogsPanel_ListBox;
        private GroupBox groupBox2;
        private Label label3;
        private Button button2;
        private Label LogsPanel_LogsLabel;
        private ToolStripMenuItem LogsMenuItem;
        private GroupBox LogsPanel_FilterGroupBox;
        private Label LogsPanel_FilterDescriptionLabel;
        private RadioButton LogsPanel_LastMonthRadioButton;
        private RadioButton LogsPanel_AllTimeRadioButton;
        private RadioButton LogsPanel_LastDayRadioButton;
        private RadioButton LogsPanel_LastWeekRadioButton;
        private Label LogsPanel_LevelLabel;
    }
}
