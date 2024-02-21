using FileLockerLibrary;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;

namespace WinFormsUI;

public partial class DashboardForm : Form, IEncryptFormCaller, IDecryptFormCaller, IImportFormCaller
{
    public DashboardForm()
    {
        InitializeComponent();

        PopulateForm();
    }

    private void PopulateForm()
    {
        FileListBox.DataSource = GlobalConfig.DataAccessor.LoadAllFileModels();
        FileListBox.DisplayMember = "DisplayName";

        if (FileListBox.Items.Count == 0)
        {
            TrashButton.Enabled = false;
            EncryptButton.Enabled = false;
            DecryptButton.Enabled = false;

            TrashButton.BackColor = Color.Silver;
            EncryptButton.BackColor = Color.Silver;
            DecryptButton.BackColor = Color.Silver;
        }
    }

    private void EncryptButton_Click(object sender, EventArgs e)
    {
        if (FileListBox.SelectedItem == null)
            return;

        FileModel model = (FileModel)FileListBox.SelectedItem;

        EncryptForm encryptForm = new EncryptForm(this, model);
        encryptForm.ShowDialog();
    }

    private void DecryptButton_Click(object sender, EventArgs e)
    {
        if (FileListBox.SelectedItem == null)
            return;

        FileModel model = (FileModel)FileListBox.SelectedItem;

        if (model.EncryptionStatus == false)
            return;

        DecryptForm decryptForm = new DecryptForm(this, model);
        decryptForm.ShowDialog();
    }

    private void TrashButton_Click(object sender, EventArgs e)
    {
        if (FileListBox.SelectedItem == null)
            return;

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

    private void AddButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        openFileDialog1.Title = "Select File(s)";
        openFileDialog1.Multiselect = true;
        openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // select file(s)
        DialogResult result = openFileDialog1.ShowDialog();
        if (result != DialogResult.OK)
            return;

        // for each selected file
        foreach (string fileName in openFileDialog1.FileNames)
        {
            FileModel model = new FileModel(fileName);
            try
            {
                GlobalConfig.DataAccessor.CreateFileModel(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

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

        using (SolidBrush brush = new SolidBrush(backgroundColor))
            row.Graphics.FillRectangle(brush, row.Bounds);
        using (SolidBrush brush = new SolidBrush(row.ForeColor))
            row.Graphics.DrawString(model.DisplayName, row.Font, brush, row.Bounds);
    }

    private void FileListBox_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (FileListBox.SelectedItem == null)
            return;

        FileModel model = (FileModel)FileListBox.SelectedItem;

        if (model.EncryptionStatus == true)
        {
            TrashButton.Enabled = true;
            EncryptButton.Enabled = false;
            DecryptButton.Enabled = true;

            TrashButton.BackColor = Color.DarkRed;
            EncryptButton.BackColor = Color.Silver;
            DecryptButton.BackColor = SystemColors.Highlight;
        }
        else
        {
            TrashButton.Enabled = true;
            EncryptButton.Enabled = true;
            DecryptButton.Enabled = false;

            TrashButton.BackColor = SystemColors.Highlight;
            EncryptButton.BackColor = SystemColors.Highlight;
            DecryptButton.BackColor = Color.Silver;
        }
    }

    private void UserGuideMenuItem_Click(object sender, EventArgs e)
    {
        ProcessStartInfo processStartInfo = new ProcessStartInfo
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

        SaveFileDialog saveFileDialog = new SaveFileDialog();
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
            MessageBox.Show("Could not export.", "Error", MessageBoxButtons.OK);
        }
    }

    private void ImportMenuItem_Click(object sender, EventArgs e)
    {
        ImportForm importForm = new ImportForm(this);
        importForm.ShowDialog();
    }

    public void ImportComplete()
    {
        PopulateForm();
    }
}
