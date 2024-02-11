using FileLockerLibrary;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection;
using System.Security.Principal;

namespace WinFormsUI;

public partial class DashboardForm : Form, IEncryptFormCaller, IDecryptFormCaller
{
    public DashboardForm()
    {
        InitializeComponent();

        FileListBox.SelectedIndexChanged += FileListBox_SelectedIndexChanged;

        PopulateForm();
    }

    private void FileListBox_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (FileListBox.SelectedItem == null)
        {
            TrashButton.BackColor = Color.Silver;
            EncryptButton.BackColor = Color.Silver;
            DecryptButton.BackColor = Color.Silver;
        }
        else
        {
            FileModel model = (FileModel)FileListBox.SelectedItem;

            if (model.EncryptionStatus == true)
            {
                TrashButton.Enabled = false;
                EncryptButton.Enabled = false;
                DecryptButton.Enabled = true;

                TrashButton.BackColor = Color.Silver;
                EncryptButton.BackColor = Color.Silver;
                DecryptButton.BackColor = Color.FromArgb(0, 84, 168);
            }
            else
            {
                TrashButton.Enabled = true;
                EncryptButton.Enabled = true;
                DecryptButton.Enabled = false;

                TrashButton.BackColor = Color.DarkRed;
                EncryptButton.BackColor = Color.FromArgb(0, 84, 168);
                DecryptButton.BackColor = Color.Silver;
            }
        }
    }

    /// <summary>
    /// Populates the form with data.
    /// </summary>
    private void PopulateForm()
    {
        FileListBox.DataSource = GlobalConfig.DataAccessor.LoadAllFileModels();
        FileListBox.DisplayMember = "FileName";
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
            catch (InvalidOperationException)
            {
                MessageBox.Show("File already selected.", "Error", MessageBoxButtons.OK);
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
        PopulateForm();
    }
}
