using FileLockerLibrary;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsUI_2;

public partial class DashboardForm : Form, IEncryptFormCaller
{
    FileModel selectedModel;

    public DashboardForm()
    {
        InitializeComponent();

        LockedFilePanel.Visible = true;
        NoFilesPanel.Visible = false;
        RelocationPanel.Visible = false;

        PopulateForm();
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

    private void PopulateForm()
    {
        FileListBox.DataSource = GlobalConfig.DataAccessor.LoadAllFileModels();
        FileListBox.DisplayMember = "DisplayName";

        UpdateControls();
    }

    private void UpdateControls()
    {
        // TODO - add ShowRelocationPanel()

        if (FileListBox.SelectedItem != null)
            selectedModel = (FileModel)FileListBox.SelectedItem;

        if (FileListBox.Items.Count < 1)
            ShowNoFilesPanel();
        else
            if (selectedModel.EncryptionStatus == true)
            ShowLockedPanel();
        else
            ShowUnlockedPanel();
    }

    private void ShowNoFilesPanel()
    {
        NoFilesPanel.Visible = true;
        LockedFilePanel.Visible = false;
        UnlockedFilePanel.Visible = false;
        RelocationPanel.Visible = false;
    }

    private void ShowUnlockedPanel()
    {
        NoFilesPanel.Visible = false;
        LockedFilePanel.Visible = false;
        UnlockedFilePanel.Visible = true;
        RelocationPanel.Visible = false;
    }

    private void ShowLockedPanel()
    {
        NoFilesPanel.Visible = false;
        LockedFilePanel.Visible = true;
        UnlockedFilePanel.Visible = false;
        RelocationPanel.Visible = false;
    }

    private void ShowRelocationPanel()
    {
        NoFilesPanel.Visible = false;
        LockedFilePanel.Visible = false;
        UnlockedFilePanel.Visible = false;
        RelocationPanel.Visible = true;
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
        bool fileTooLarge = false;

        foreach (string path in paths)
        {
            if (!File.Exists(path))
                continue;

            FileInfo fileInfo = new(path);
            if (fileInfo.Length > Constants.MaxFileSize)
            {
                fileTooLarge = true;
                continue;
            }

            FileModel model = new(path);

            try
            {
                GlobalConfig.DataAccessor.CreateFileModel(model);
            }
            catch { }
        }

        if (fileTooLarge)
            MessageBox.Show($"Some files exceeded the max size of {Constants.MaxFileSize} bytes.", "Error", MessageBoxButtons.OK);

        PopulateForm();
    }

    // TODO - implement ImportArchiveToolStripMenuItem_Click
    private void ImportArchiveToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    // TODO - implement RelocateButton_Click
    private void RelocateButton_Click(object sender, EventArgs e)
    {

    }

    // TODO - implement RemoveButton_Click
    private void RemoveButton_Click(object sender, EventArgs e)
    {

    }

    // TODO - implement SearchTextBox_TextChanged
    private void SearchTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    // TODO - implement UnlockedShredButton_Click
    private void UnlockedShredButton_Click(object sender, EventArgs e)
    {

    }

    // TODO - implement GenerateRandomButton_Click
    private void GenerateRandomButton_Click(object sender, EventArgs e)
    {

    }

    // TODO - implement ClearButton_Click
    private void ClearButton_Click(object sender, EventArgs e)
    {

    }

    // TODO - implement EyeballLabel_Click
    private void EyeballLabel_Click(object sender, EventArgs e)
    {

    }

    // TODO - implement EnterButton_Click
    private void EnterButton_Click(object sender, EventArgs e)
    {

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
        FileModel model = (FileModel)FileListBox.SelectedItem;

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

    public void EncryptionComplete()
    {
        throw new NotImplementedException();
    }

    public void RemovalComplete()
    {
        throw new NotImplementedException();
    }

    private void FileListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateControls();
    }
}
