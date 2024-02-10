using FileLockerLibrary;
using Microsoft.VisualBasic.ApplicationServices;

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
        FileListBox.DisplayMember = "DisplayName";
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

    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        openFileDialog1.Title = "Select File";
        openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        // select file
        DialogResult result = openFileDialog1.ShowDialog();
        if (result != DialogResult.OK)
            return;

        // create new FileModel
        FileModel model = new FileModel(openFileDialog1.FileName);
        try
        {
            GlobalConfig.DataAccessor.SaveFileModel(model);
        }
        catch (InvalidOperationException)
        {
            MessageBox.Show("File already selected.", "Error", MessageBoxButtons.OK);
        }

        // call EncryptForm

        PopulateForm();
    }
}
