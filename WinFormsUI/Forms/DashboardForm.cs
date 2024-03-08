using FileLockerLibrary;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace WinFormsUI;

public partial class DashboardForm : Form, IEncryptFormCaller, IDecryptFormCaller, IImportFormCaller
{
    List<FileModel> selectedFiles = new();

    public DashboardForm()
    {
        InitializeComponent();

        FileListBox.ContextMenuStrip = FileListBoxItemContextMenuStrip;

        PopulateForm();
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

    private void PopulateForm()
    {
        FileListBox.DataSource = GlobalConfig.DataAccessor.LoadAllFileModels();
        FileListBox.DisplayMember = "DisplayName";

        UpdateControls();
    }

    private void UpdateControls()
    {
        selectedFiles = new();
        foreach (FileModel model in FileListBox.SelectedItems)
            selectedFiles.Add(model);

        if (selectedFiles.Count == 0)
        {
            TrashButton.Enabled = false;
            EncryptButton.Enabled = false;
            DecryptButton.Enabled = false;
            ExportMenuItem.Enabled = false;

            TrashButton.BackColor = Color.Silver;
            EncryptButton.BackColor = Color.Silver;
            DecryptButton.BackColor = Color.Silver;
        }
        else
        {
            TrashButton.Enabled = true;
            ExportMenuItem.Enabled = true;

            TrashButton.BackColor = Color.DarkRed;

            // one selected is locked
            if (selectedFiles.Count == 1 && selectedFiles.All(model => model.EncryptionStatus == true))
            {
                EncryptButton.Enabled = false;
                DecryptButton.Enabled = true;

                EncryptButton.BackColor = Color.Silver;
                DecryptButton.BackColor = SystemColors.Highlight;
            }
            // all unlocked
            else if (selectedFiles.All(model => model.EncryptionStatus == false))
            {
                EncryptButton.Enabled = true;
                DecryptButton.Enabled = false;

                EncryptButton.BackColor = SystemColors.Highlight;
                DecryptButton.BackColor = Color.Silver;
            }
            // all locked or mixed
            else
            {
                EncryptButton.Enabled = false;
                DecryptButton.Enabled = false;

                EncryptButton.BackColor = Color.Silver;
                DecryptButton.BackColor = Color.Silver;
            }
        }
    }

    private void EncryptButton_Click(object sender, EventArgs e)
    {
        if (selectedFiles.Count == 0)
            return;

        EncryptForm encryptForm = new(this, selectedFiles);
        encryptForm.ShowDialog();
    }

    private void DecryptButton_Click(object sender, EventArgs e)
    {
        if (selectedFiles.Count == 0 || selectedFiles.Count > 1)
            return;
        if (selectedFiles.First().EncryptionStatus == false)
            return;

        DecryptForm decryptForm = new(this, selectedFiles.First());
        decryptForm.ShowDialog();
    }

    private void TrashButton_Click(object sender, EventArgs e)
    {
        if (FileListBox.SelectedItem == null)
            return;

        ShredSelectedFile();
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new();
        openFileDialog.Title = "Select File(s)";
        openFileDialog.Multiselect = true;
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // Select file(s)
        DialogResult result = openFileDialog.ShowDialog();
        if (result != DialogResult.OK)
            return;

        AddFiles(openFileDialog.FileNames);
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

    private void FileListBox_SelectedIndexChanged(object? sender, EventArgs e)
    {
        UpdateControls();
    }

    private void UserGuideMenuItem_Click(object sender, EventArgs e)
    {
        ProcessStartInfo processStartInfo = new()
        {
            FileName = Constants.GitHubUrl,
            UseShellExecute = true
        };

        Process.Start(processStartInfo);
    }

    private void ExitMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void ExportMenuItem_Click(object sender, EventArgs e)
    {
        if (FileListBox.SelectedItem == null)
            return;

        FileModel model = (FileModel)FileListBox.SelectedItem;

        using SaveFileDialog saveFileDialog = new();
        saveFileDialog.Title = "Save Archive";
        saveFileDialog.Filter = "Zip files (*.zip)|*.zip";
        saveFileDialog.FileName = model.FileName + ".zip";
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        saveFileDialog.OverwritePrompt = true;

        DialogResult result = saveFileDialog.ShowDialog();
        if (result != DialogResult.OK)
            return;

        try
        {
            GlobalConfig.DataAccessor.ExportZipFileModel(model, saveFileDialog.FileName);
        }
        catch
        {
            MessageBox.Show("Could not export, the file may be missing.", "Error", MessageBoxButtons.OK);
        }
    }

    private void ImportMenuItem_Click(object sender, EventArgs e)
    {
        ImportForm importForm = new(this);
        importForm.ShowDialog();
    }

    private void AddFiles(string[] paths)
    {
        bool fileTooLarge = false;

        foreach (string path in paths)
        {
            FileInfo fileInfo = new FileInfo(path);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        if (fileTooLarge)
            MessageBox.Show($"Some files exceeded the max size of {Constants.MaxFileSize} bytes.", "Error", MessageBoxButtons.OK);

        PopulateForm();
    }

    private void RemoveSelectedFile()
    {
        FileModel model = (FileModel)FileListBox.SelectedItem;

        if (model.EncryptionStatus == true)
        {
            DialogResult result = MessageBox.Show("Removing a locked file means it can never be unlocked. Are you sure you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
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

    private void ShredSelectedFile()
    {
        DialogResult result = MessageBox.Show("This will delete the file permanently. Are you sure you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (result != DialogResult.Yes)
            return;

        FileModel model = (FileModel)FileListBox.SelectedItem;

        try
        {
            GlobalConfig.DataAccessor.ShredFile(model.Path);
            GlobalConfig.DataAccessor.DeleteFileModel(model);
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

    public void EncryptionComplete()
    {
        PopulateForm();
    }

    public void DecryptionComplete()
    {
        FileListBox.Refresh();
        FileListBox_SelectedIndexChanged(null, EventArgs.Empty);
    }

    private void FileListBox_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            FileListBox.SelectedIndex = FileListBox.IndexFromPoint(e.Location);
            FileListBox.ContextMenuStrip.Show(FileListBox, e.Location);
        }
    }

    private void RemoveFileItem_Click(object sender, EventArgs e)
    {
        if (FileListBox.SelectedIndex == -1)
            return;

        RemoveSelectedFile();
    }
}
