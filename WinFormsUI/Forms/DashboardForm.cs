using FileLockerLibrary;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using WinFormsUI.Interfaces;
using FileLockerLibrary.Models;

namespace WinFormsUI.Forms;

public partial class DashboardForm : Form, IEncryptFormCaller, IDecryptFormCaller, IImportFormCaller, ISignFormCaller, ICreateKeyPairFormCaller
{
    FileModel selectedModel;

    public DashboardForm()
    {
        InitializeComponent();

        LockedPanel.Visible = true;
        NoFilesPanel.Visible = false;
        RelocationPanel.Visible = false;

        PopulateForm();
    }

    private void PopulateForm()
    {
        FileListBox.DataSource = GlobalConfig.DataAccessor.LoadAllFileModels();
        FileListBox.DisplayMember = "DisplayName";

        Array logLevelValues = Enum.GetValues(typeof(LogLevel));
        List<object> items = [ "Any", .. logLevelValues,];
        LogsPanel_LevelComboBox.DataSource = items;

        UpdateControls();
    }

    private void UpdateControls()
    {
        FileListBox.Refresh();

        if (FileListBox.Items.Count < 1)
            ShowNoFilesPanel();

        // a non-file panel is shown
        if (FileListBox.SelectedIndex == -1)
            return;

        if (FileListBox.Items.Count < 1)
        {
            ShowNoFilesPanel();
            return;
        }

        selectedModel = (FileModel)FileListBox.SelectedItem;

        if (!File.Exists(selectedModel.Path))
        {
            ShowRelocationPanel();
            return;
        }

        if (selectedModel.EncryptionStatus == true)
            ShowLockedPanel();
        else
            ShowUnlockedPanel();
    }

    private void ShowNoFilesPanel()
    {
        NoFilesPanel.Visible = true;
        LockedPanel.Visible = false;
        UnlockedPanel.Visible = false;
        RelocationPanel.Visible = false;
        KeysPanel.Visible = false;
        LogsPanel.Visible = false;
    }

    private void ShowUnlockedPanel()
    {
        NoFilesPanel.Visible = false;
        LockedPanel.Visible = false;
        UnlockedPanel.Visible = true;
        RelocationPanel.Visible = false;
        KeysPanel.Visible = false;
        LogsPanel.Visible = false;

        if (GlobalConfig.DataAccessor.LoadAllPrivateKeyPairModels().Count < 1)
        {
            UnlockedPanel_SignButton.Enabled = false;
            UnlockedPanel_SignButton.BackColor = Color.Silver;
        }
        else
        {
            UnlockedPanel_SignButton.Enabled = true;
            UnlockedPanel_SignButton.BackColor = SystemColors.Highlight;
        }

        UnlockedPanel_FileNameLabel.Text = selectedModel.FileName.Length > 50 ? selectedModel.FileName.Substring(0, 47) + "..." : selectedModel.FileName;
        UnlockedPanel_PathValueLabel.Text = selectedModel.Path.Length > 64 ? selectedModel.Path.Substring(0, 61) + "..." : selectedModel.Path;
        UnlockedPanel_SizeValueLabel.Text = FormatBytes(selectedModel.SizeInBytes);
        UnlockedPanel_ShaValueLabel.Text = BitConverter.ToString(selectedModel.Sha).Replace("-", "");
        UnlockedPanel_DateAddedValueLabel.Text = selectedModel.DateAdded.ToShortDateString();
        UnlockedPanel_SignatureValueLabel.Text = selectedModel.DigSigDisplay;
    }

    private void ShowLockedPanel()
    {
        NoFilesPanel.Visible = false;
        LockedPanel.Visible = true;
        UnlockedPanel.Visible = false;
        RelocationPanel.Visible = false;
        KeysPanel.Visible = false;
        LogsPanel.Visible = false;

        if (GlobalConfig.DataAccessor.LoadAllPrivateKeyPairModels().Count < 1)
        {
            LockedPanel_SignButton.Enabled = false;
            LockedPanel_SignButton.BackColor = Color.Silver;
        }
        else
        {
            LockedPanel_SignButton.Enabled = true;
            LockedPanel_SignButton.BackColor = SystemColors.Highlight;
        }

        LockedPanel_FileNameLabel.Text = selectedModel.FileName.Length > 50 ? selectedModel.FileName.Substring(0, 47) + "..." : selectedModel.FileName;
        LockedPanel_PathValueLabel.Text = selectedModel.Path.Length > 64 ? selectedModel.Path.Substring(0, 61) + "..." : selectedModel.Path;
        LockedPanel_SizeValueLabel.Text = FormatBytes(selectedModel.SizeInBytes);
        LockedPanel_ShaValueLabel.Text = BitConverter.ToString(selectedModel.Sha).Replace("-", "");
        LockedPanel_DateAddedValueLabel.Text = selectedModel.DateAdded.ToShortDateString();
        LockedPanel_SignatureValueLabel.Text = selectedModel.DigSigDisplay;
        LockedPanel_AlgorithmValueLabel.Text = selectedModel.EncryptionAlgorithm.ToString();
    }

    private void ShowRelocationPanel()
    {
        NoFilesPanel.Visible = false;
        LockedPanel.Visible = false;
        UnlockedPanel.Visible = false;
        RelocationPanel.Visible = true;
        KeysPanel.Visible = false;
        LogsPanel.Visible = false;

        string displayPath = selectedModel.Path.Length > 64 ? selectedModel.Path.Substring(0, 61) + "..." : selectedModel.Path;
        string fileDisplayName = selectedModel.FileName.Length > 50 ? selectedModel.FileName.Substring(0, 47) + "..." : selectedModel.FileName;
        RelocationPanel_CantLocateFileLabel.Text = $"Can't locate {fileDisplayName}";
        RelocationPanel_LastSeenLabel.Text = $"It was last seen at {displayPath}";
    }

    private void ShowKeysPanel()
    {
        NoFilesPanel.Visible = false;
        LockedPanel.Visible = false;
        UnlockedPanel.Visible = false;
        RelocationPanel.Visible = false;
        KeysPanel.Visible = true;
        LogsPanel.Visible = false;
        KeysPanel_SearchTextBox.Text = "";
        FileListBox.SelectedIndex = -1;

        KeysRadioButton_CheckedChanged(null, null);
    }

    private void ShowLogsPanel()
    {
        NoFilesPanel.Visible = false;
        LockedPanel.Visible = false;
        UnlockedPanel.Visible = false;
        RelocationPanel.Visible = false;
        KeysPanel.Visible = false;
        LogsPanel.Visible = true;
        LogsPanel_SearchTextBox.Text = "";
        FileListBox.SelectedIndex = -1;

        LogsRadioButton_CheckedChanged(null, null);
    }

    private void FileListBox_DrawItem(object sender, DrawItemEventArgs row)
    {
        if (row.Index < 0 || row.Index >= FileListBox.Items.Count)
            return;

        FileModel model = (FileModel)FileListBox.Items[row.Index];
        Color backgroundColor;

        if (row.State.HasFlag(DrawItemState.Selected))
            backgroundColor = SystemColors.Highlight;
        else
            if (row.Index % 2 == 0)
            backgroundColor = Color.FromArgb(50, 50, 50);
        else
            backgroundColor = Color.FromArgb(40, 40, 40);

        row.DrawBackground();

        using SolidBrush backgroundBrush = new(backgroundColor);
        row.Graphics.FillRectangle(backgroundBrush, row.Bounds);

        using SolidBrush foregroundBrush = new(row.ForeColor);
        row.Graphics.DrawString(model.DisplayName, row.Font, foregroundBrush, row.Bounds);
    }

    private void KeysPanel_ListBox_DrawItem(object sender, DrawItemEventArgs row)
    {
        if (row.Index < 0 || row.Index >= KeysPanel_ListBox.Items.Count)
            return;

        KeyPairModel model = (KeyPairModel)KeysPanel_ListBox.Items[row.Index];
        Color backgroundColor;

        if (row.State.HasFlag(DrawItemState.Selected))
            backgroundColor = SystemColors.Highlight;
        else
            if (row.Index % 2 == 0)
            backgroundColor = Color.FromArgb(50, 50, 50);
        else
            backgroundColor = Color.FromArgb(40, 40, 40);

        row.DrawBackground();

        using SolidBrush backgroundBrush = new(backgroundColor);
        row.Graphics.FillRectangle(backgroundBrush, row.Bounds);

        using SolidBrush foregroundBrush = new(row.ForeColor);
        row.Graphics.DrawString(model.DisplayName, row.Font, foregroundBrush, row.Bounds);
    }

    private void LogsPanel_ListBox_DrawItem(object sender, DrawItemEventArgs row)
    {
        if (row.Index < 0 || row.Index >= LogsPanel_ListBox.Items.Count)
            return;

        LogModel model = (LogModel)LogsPanel_ListBox.Items[row.Index];
        Color backgroundColor;

        if (row.State.HasFlag(DrawItemState.Selected))
            backgroundColor = SystemColors.Highlight;
        else
            if (row.Index % 2 == 0)
            backgroundColor = Color.FromArgb(50, 50, 50);
        else
            backgroundColor = Color.FromArgb(40, 40, 40);

        row.DrawBackground();

        using SolidBrush backgroundBrush = new(backgroundColor);
        row.Graphics.FillRectangle(backgroundBrush, row.Bounds);

        using SolidBrush foregroundBrush = new(row.ForeColor);
        row.Graphics.DrawString(model.DisplayName, row.Font, foregroundBrush, row.Bounds);
    }

    private void CenterLabel_TextChanged(object sender, EventArgs e)
    {
        if (sender is not Label label)
            return;

        Size textSize = TextRenderer.MeasureText(label.Text, label.Font);
        int newX = (label.Parent.ClientSize.Width - textSize.Width) / 2;
        int newY = label.Location.Y;
        label.Location = new Point(newX, newY);
    }

    private string FormatBytes(int bytes)
    {
        string[] suffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        if (bytes == 0)
            return "0 bytes";

        int i;
        double dblBytes = bytes;
        for (i = 0; Math.Round(dblBytes / 1024) >= 1; i++)
            dblBytes /= 1024;

        return $"{dblBytes:n1} {suffixes[i]}";
    }

    private void AddButton_MouseDown(object sender, MouseEventArgs e)
    {
        AddButtonContextMenuStrip.Show(AddButton, 0, AddButton.Height);
    }

    private void AddExistingFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new();
        openFileDialog.Title = "Select File(s)";
        openFileDialog.Multiselect = true;
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        if (openFileDialog.ShowDialog() != DialogResult.OK)
            return;

        AddFiles(openFileDialog.FileNames);
    }

    private void AddFiles(string[] paths)
    {
        SearchTextBox.Text = "";

        bool filesTooLarge = false;
        bool filesAlreadyAdded = false;

        foreach (string path in paths)
        {
            if (!File.Exists(path))
                continue;

            if (GlobalConfig.DataAccessor.LoadAllFileModels().Any(file => file.Path == path))
            {
                filesAlreadyAdded = true;
                continue;
            }

            FileInfo fileInfo = new(path);
            if (fileInfo.Length > Constants.MaxFileSize)
            {
                filesTooLarge = true;
                continue;
            }

            FileModel model = new(path);

            try
            {
                GlobalConfig.DataAccessor.CreateFileModel(model);
            }
            catch { }
        }

        if (filesTooLarge || filesAlreadyAdded)
        {
            string message = "";
            if (filesTooLarge)
                message += $"Some files exceeded the max size of {Constants.MaxFileSize} bytes.";
            if (filesAlreadyAdded)
                message += "\nSome files already added.";

            MessageBox.Show(message, "Error", MessageBoxButtons.OK);
        }

        PopulateForm();
    }

    private void ImportArchiveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ImportForm importForm = new(this);
        importForm.ShowDialog();
    }

    private void RelocateButton_Click(object sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new();
        openFileDialog.Title = "Relocate File";
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        if (openFileDialog.ShowDialog() != DialogResult.OK)
            return;

        string newPath = openFileDialog.FileName;
        if (Path.GetFileName(newPath) != selectedModel.FileName)
            return;

        GlobalConfig.DataAccessor.RelocateFile(selectedModel, newPath);

        UpdateControls();
    }

    private void RemoveButton_Click(object sender, EventArgs e)
    {
        try
        {
            GlobalConfig.DataAccessor.DeleteFileModel(selectedModel);
            PopulateForm();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void SearchTextBox_TextChanged(object sender, EventArgs e)
    {
        // show/hide magnifying glass label
        if (SearchTextBox.Text.Length > 0)
            MagnifyingGlassLabel.Visible = false;
        else
            MagnifyingGlassLabel.Visible = true;

        // filter FileListBox
        string searchText = SearchTextBox.Text.Trim().ToLower();

        FileListBox.DataSource = GlobalConfig.DataAccessor.LoadAllFileModels().Where(file => file.FileName.ToLower().Contains(searchText)).ToList();

        FileListBox.Refresh();
    }

    private void EncryptButton_Click(object sender, EventArgs e)
    {
        EncryptForm encryptForm = new(this, selectedModel);
        encryptForm.ShowDialog();
    }

    private void FileListBox_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            FileListBox.SelectedIndex = FileListBox.IndexFromPoint(e.Location);
            FileListBox.ContextMenuStrip.Show(FileListBox, e.Location);
        }
    }

    private void FileListBox_DragDrop(object? sender, DragEventArgs e)
    {
        FileListBox.BackColor = Color.FromArgb(40, 40, 40);
        string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
        AddFiles(paths);
    }

    private void FileListBox_DragEnter(object? sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
            e.Effect = DragDropEffects.Copy;
        else
            e.Effect = DragDropEffects.None;
    }

    private void RemoveFromListItem_Click(object sender, EventArgs e)
    {
        if (FileListBox.Items.Count < 1)
        {
            ShowNoFilesPanel();
            return;
        }

        FileModel model = (FileModel)FileListBox.SelectedItem;

        if (model == null)
            return;

        if (model.EncryptionStatus == true)
        {
            if (MessageBox.Show("Removing a locked file means it can never be unlocked. Are you sure you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
        }

        try
        {
            GlobalConfig.DataAccessor.DeleteFileModel(model);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        PopulateForm();
    }

    private void GuideMenuItem_Click(object sender, EventArgs e)
    {
        ProcessStartInfo processStartInfo = new()
        {
            FileName = Constants.ReadmeUrl,
            UseShellExecute = true
        };

        Process.Start(processStartInfo);
    }

    private void FileListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateControls();
    }

    private void DecryptButton_Click(object sender, EventArgs e)
    {
        DecryptForm decryptForm = new(this, selectedModel);
        decryptForm.ShowDialog();
    }

    private void TrashCanLabel_Click(object sender, EventArgs e)
    {
        selectedModel.RemoveDigSig();
        UpdateControls();
    }

    public void EncryptionComplete()
    {
        UpdateControls();
    }

    public void DecryptionComplete()
    {
        UpdateControls();
    }

    private void ShredButton_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("This will delete the file(s) permanently. Are you sure you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            return;

        try
        {
            selectedModel.ShredFile();
            GlobalConfig.DataAccessor.DeleteFileModel(selectedModel);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        PopulateForm();
    }

    public void ImportComplete()
    {
        PopulateForm();
    }

    private void ExportButton_Click(object sender, EventArgs e)
    {
        using SaveFileDialog saveFileDialog = new();
        saveFileDialog.Title = "Export Archive";
        saveFileDialog.Filter = "Zip files (*.zip)|*.zip";
        saveFileDialog.FileName = selectedModel.FileName + ".zip";
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        saveFileDialog.OverwritePrompt = true;
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
            return;

        try
        {
            GlobalConfig.DataAccessor.ExportZipFileModel(selectedModel, saveFileDialog.FileName);
        }
        catch
        {
            MessageBox.Show("Could not export, the file may be missing.", "Error", MessageBoxButtons.OK);
        }
    }

    private void PathClipboardLabel_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(selectedModel.Path);
    }

    private void ShaClipboardLabel_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(BitConverter.ToString(selectedModel.Sha).Replace("-", ""));
    }

    private void Label_MouseEnter(object sender, EventArgs e)
    {
        Label label = (Label)sender;
        label.ForeColor = SystemColors.Highlight;
    }

    private void Label_MouseLeave(object sender, EventArgs e)
    {
        Label label = (Label)sender;
        label.ForeColor = SystemColors.ButtonFace;
    }

    private void ShowInExplorerButton_Click(object sender, EventArgs e)
    {
        Process.Start("explorer.exe", "/select, " + selectedModel.Path);
    }

    private void SignButton_Click(object sender, EventArgs e)
    {
        SignForm signForm = new(this, selectedModel);
        signForm.ShowDialog();
    }

    public void SigningComplete()
    {
        UpdateControls();
    }

    private void CreateKeyPairToolStripMenuItem_Click(object sender, EventArgs e)
    {
        CreateKeyPairForm createKeyPairForm = new(this);
        createKeyPairForm.ShowDialog();
    }

    public void KeyPairCreationComplete()
    {
        KeysPanel_MyKeysRadioButton.Checked = true;
        ShowKeysPanel();
    }

    private void KeysMenuItem_Click(object sender, EventArgs e)
    {
        ShowKeysPanel();
    }

    private void KeysPanel_CreateButton_Click(object sender, EventArgs e)
    {
        CreateKeyPairForm createKeyPairForm = new(this);
        createKeyPairForm.ShowDialog();
    }

    private void KeysListBox_DeleteItem_Click(object sender, EventArgs e)
    {
        KeyPairModel model = (KeyPairModel)KeysPanel_ListBox.SelectedItem;

        try
        {
            GlobalConfig.DataAccessor.DeleteKeyPairModel(model);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        ShowKeysPanel();
    }

    private void KeysPanel_ImportButton_Click(object sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new();
        openFileDialog.Title = "Import Archive";
        openFileDialog.Filter = ".zip files (*.zip)|*.zip";
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        if (openFileDialog.ShowDialog() != DialogResult.OK)
            return;

        try
        {
            GlobalConfig.DataAccessor.ImportZipKeyPairModel(openFileDialog.FileName);
            ShowKeysPanel();
        }
        catch (InvalidOperationException ex)
        {
            MessageBox.Show("Key already added.", "Error", MessageBoxButtons.OK);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void KeyListBox_ExportItem_Click(object sender, EventArgs e)
    {
        KeyPairModel model = (KeyPairModel)KeysPanel_ListBox.SelectedItem;

        using SaveFileDialog saveFileDialog = new();
        saveFileDialog.Title = "Export Archive";
        saveFileDialog.Filter = "Zip files (*.zip)|*.zip";
        saveFileDialog.FileName = model.Name + ".zip";
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        saveFileDialog.OverwritePrompt = true;
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
            return;

        try
        {
            GlobalConfig.DataAccessor.ExportZipKeyPairModel(model, saveFileDialog.FileName);
        }
        catch
        {
            MessageBox.Show("Could not export, the file may be missing.", "Error", MessageBoxButtons.OK);
        }
    }

    private void KeysRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        KeysPanel_SearchTextBox_TextChanged(null, null);
    }

    private void KeysPanel_SearchTextBox_TextChanged(object sender, EventArgs e)
    {
        // show/hide magnifying glass label
        if (KeysPanel_SearchTextBox.Text.Length > 0)
            KeysPanel_MagnifyingGlassLabel.Visible = false;
        else
            KeysPanel_MagnifyingGlassLabel.Visible = true;

        // filter KeysListBox
        string searchText = KeysPanel_SearchTextBox.Text.Trim().ToLower();
        List<KeyPairModel> privateKeyPairs = GlobalConfig.DataAccessor.LoadAllPrivateKeyPairModels();
        List<KeyPairModel> publicKeyPairs = GlobalConfig.DataAccessor.LoadAllPublicKeyPairModels();

        if (KeysPanel_MyKeysRadioButton.Checked)
            KeysPanel_ListBox.DataSource = privateKeyPairs.Where(keyPairModel => keyPairModel.DisplayName.ToLower().Contains(searchText)).ToList();
        else
            KeysPanel_ListBox.DataSource = publicKeyPairs.Where(keyPairModel => keyPairModel.DisplayName.ToLower().Contains(searchText)).ToList();

        KeysPanel_ListBox.Refresh();
    }

    private void LogsMenuItem_Click(object sender, EventArgs e)
    {
        ShowLogsPanel();
    }

    private void LogsRadioButton_CheckedChanged(object sender, EventArgs e)
    {
        PopulateLogsListBox();
    }

    private void LogsPanel_SearchTextBox_TextChanged(object sender, EventArgs e)
    {
        // show/hide magnifying glass label
        if (LogsPanel_SearchTextBox.Text.Length > 0)
            LogsPanel_MagnifyingGlassLabel.Visible = false;
        else
            LogsPanel_MagnifyingGlassLabel.Visible = true;

        PopulateLogsListBox();
    }

    private void LogsPanel_LevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        PopulateLogsListBox();
    }

    private void PopulateLogsListBox()
    {
        List<LogModel> logs = GlobalConfig.Logger.LoadAllLogs().OrderByDescending(model => model.Timestamp).ToList();

        // filter by search
        string searchText = LogsPanel_SearchTextBox.Text.Trim().ToLower();
        logs = logs.Where(model => model.DisplayName.ToLower().Contains(searchText)).ToList();

        // filter by time
        if (LogsPanel_LastMonthRadioButton.Checked)
            logs = logs.Where(model => model.Timestamp >= DateTime.Now.AddMonths(-1)).ToList();
        else if (LogsPanel_LastWeekRadioButton.Checked)
            logs = logs.Where(model => model.Timestamp >= DateTime.Now.AddDays(-7)).ToList();
        else if (LogsPanel_LastDayRadioButton.Checked)
            logs = logs.Where(model => model.Timestamp >= DateTime.Now.AddDays(-1)).ToList();

        // filter by log level
        if (LogsPanel_LevelComboBox.SelectedItem != null)
        {
            var selectedItem = LogsPanel_LevelComboBox.SelectedItem;

            switch (selectedItem)
            {
                case "Any":
                    break;
                case LogLevel.Information:
                    logs = logs.Where(model => model.Level == LogLevel.Information).ToList();
                    break;
                case LogLevel.Debug:
                    logs = logs.Where(model => model.Level == LogLevel.Debug).ToList();
                    break;
                case LogLevel.Warning:
                    logs = logs.Where(model => model.Level == LogLevel.Warning).ToList();
                    break;
                case LogLevel.Error:
                    logs = logs.Where(model => model.Level == LogLevel.Error).ToList();
                    break;
                case LogLevel.Fatal:
                    logs = logs.Where(model => model.Level == LogLevel.Fatal).ToList();
                    break;
            }
        }

        LogsPanel_ListBox.DataSource = logs;
        LogsPanel_ListBox.Refresh();
    }
}
