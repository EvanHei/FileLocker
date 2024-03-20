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

        // no files selected
        if (selectedFiles.Count == 0)
        {
            DisableEncryptButton();
            DisableDecryptButton();
            DisableTrashButton();
            DisableExportButton();
        }
        // some files selected
        else
        {
            EnableTrashButton();
            EnableExportButton();

            // one file selected
            if (selectedFiles.Count == 1)
            {
                EnableExportButton();

                // locked
                if (selectedFiles.First().EncryptionStatus == true)
                {
                    DisableEncryptButton();
                    EnableDecryptButton();
                }
                // unlocked
                else
                {
                    EnableEncryptButton();
                    DisableDecryptButton();
                }
            }
            // all unlocked
            else if (selectedFiles.All(model => model.EncryptionStatus == false))
            {
                EnableEncryptButton();
                DisableDecryptButton();
                DisableExportButton();
            }
            // all locked or mixed
            else
            {
                DisableEncryptButton();
                DisableDecryptButton();
                DisableExportButton();
            }
        }
    }

    private void EnableEncryptButton()
    {
        EncryptButton.Enabled = true;
        EncryptButton.BackColor = SystemColors.Highlight;
    }

    private void DisableEncryptButton()
    {
        EncryptButton.Enabled = false;
        EncryptButton.BackColor = Color.Silver;
    }

    private void EnableDecryptButton()
    {
        DecryptButton.Enabled = true;
        DecryptButton.BackColor = SystemColors.Highlight;
    }

    private void DisableDecryptButton()
    {
        DecryptButton.Enabled = false;
        DecryptButton.BackColor = Color.Silver;
    }

    private void EnableTrashButton()
    {
        TrashButton.Enabled = true;
        TrashButton.BackColor = Color.DarkRed;
    }

    private void DisableTrashButton()
    {
        TrashButton.Enabled = false;
        TrashButton.BackColor = Color.Silver;
    }

    private void EnableExportButton()
    {
        ExportButton.Enabled = true;
        ExportButton.BackColor = Color.FromArgb(32, 32, 32);
    }

    private void DisableExportButton()
    {
        ExportButton.Enabled = false;
        ExportButton.BackColor = Color.Silver;
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
        if (selectedFiles.Count != 1)
            return;
        if (selectedFiles.First().EncryptionStatus == false)
            return;

        DecryptForm decryptForm = new(this, selectedFiles.First());
        decryptForm.ShowDialog();
    }

    private void TrashButton_Click(object sender, EventArgs e)
    {
        if (selectedFiles.Count == 0)
            return;

        ShredSelectedFiles();
    }

    private void AddFilesButton_Click(object sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new();
        openFileDialog.Title = "Select File(s)";
        openFileDialog.Multiselect = true;
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        if (openFileDialog.ShowDialog() != DialogResult.OK)
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
            FileName = Constants.ReadmeUrl,
            UseShellExecute = true
        };

        Process.Start(processStartInfo);
    }

    private void AddFiles(string[] paths)
    {
        bool fileTooLarge = false;

        foreach (string path in paths)
        {
            if (!File.Exists(path))
                continue;

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

    private void RemoveSelectedFiles()
    {
        if (selectedFiles.Any(model => model.EncryptionStatus == true))
        {
            if (MessageBox.Show("Removing a locked file means it can never be unlocked. Are you sure you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
        }

        try
        {
            foreach (FileModel model in selectedFiles)
                GlobalConfig.DataAccessor.DeleteFileModel(model);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        PopulateForm();
    }

    private void ShredSelectedFiles()
    {
        if (MessageBox.Show("This will delete the file(s) permanently. Are you sure you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            return;

        try
        {
            foreach (FileModel model in selectedFiles)
            {
                model.ShredFile();
                GlobalConfig.DataAccessor.DeleteFileModel(model);
            }
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

    private void RemoveFile_Click(object sender, EventArgs e)
    {
        if (selectedFiles.Count == 0)
            return;

        RemoveSelectedFiles();
    }

    private void ExportButton_Click(object sender, EventArgs e)
    {
        if (selectedFiles.Count != 1)
            return;

        FileModel model = selectedFiles.First();

        using SaveFileDialog saveFileDialog = new();
        saveFileDialog.Title = "Save Archive";
        saveFileDialog.Filter = "Zip files (*.zip)|*.zip";
        saveFileDialog.FileName = model.FileName + ".zip";
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        saveFileDialog.OverwritePrompt = true;
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
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

    private void ImportButton_Click(object sender, EventArgs e)
    {
        ImportForm importForm = new(this);
        importForm.ShowDialog();
    }

    public void RemovalComplete()
    {
        PopulateForm();
    }
}
