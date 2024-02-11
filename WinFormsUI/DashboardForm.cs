using FileLockerLibrary;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection;
using System.Security.Principal;

namespace WinFormsUI;

public partial class DashboardForm : Form
{
    public DashboardForm()
    {
        InitializeComponent();

        PopulateForm();
    }

    /// <summary>
    /// Populates the form with data.
    /// </summary>
    private void PopulateForm()
    {
        FileListBox.DataSource = GlobalConfig.DataAccessor.LoadAllFileModels();
        FileListBox.DisplayMember = "FileName";

        // FileListBox selected item
        if (FileListBox.SelectedItem == null)
        {
            TrashButton.BackColor = Color.FromArgb(40, 40, 40);
            EncryptButton.BackColor = Color.FromArgb(40, 40, 40);
            DecryptButton.BackColor = Color.FromArgb(40, 40, 40);
            return;
        }

        FileModel model = (FileModel)FileListBox.SelectedItem;

        if (model.EncryptionStatus == true)
        {
            TrashButton.BackColor = Color.FromArgb(40, 40, 40);
            EncryptButton.BackColor = Color.FromArgb(40, 40, 40);
            DecryptButton.BackColor = Color.FromArgb(0, 84, 168);
        }
        else
        {
            TrashButton.BackColor = Color.DarkRed;
            EncryptButton.BackColor = Color.FromArgb(0, 84, 168);
            DecryptButton.BackColor = Color.FromArgb(40, 40, 40);
        }
    }

    private void EncryptButton_Click(object sender, EventArgs e)
    {
        // must set the FileModel.EncryptionKeySalt property with a newly generated salt
    }

    private void DecryptButton_Click(object sender, EventArgs e)
    {

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

        // call EncryptForm

        PopulateForm();
    }
}
