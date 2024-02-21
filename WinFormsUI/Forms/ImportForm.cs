using FileLockerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;

namespace WinFormsUI;

public partial class ImportForm : Form
{
    private IImportFormCaller caller;
    private string openPath;
    private string savePath;

    public ImportForm(IImportFormCaller caller)
    {
        InitializeComponent();

        this.caller = caller;
    }

    private void PopulateForm()
    {
        if (openPath != null && savePath != null)
        {
            ImportButton.Enabled = true;
            ImportButton.BackColor = SystemColors.Highlight;
        }
        if (openPath != null)
        {
            OpenLabel.Text = openPath.Length > 50 ? openPath.Substring(0, 47) + "..." : openPath;

            SaveToButton.Enabled = true;
            SaveToButton.BackColor = SystemColors.Highlight;
        }
        if (savePath != null)
            SaveToLabel.Text = savePath.Length > 50 ? savePath.Substring(0, 47) + "..." : savePath;
    }

    private void OpenButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Title = "Select Archive";
        openFileDialog.Filter = "Zip files (*.zip)|*.zip";
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        DialogResult openFileDialogResult = openFileDialog.ShowDialog();
        if (openFileDialogResult != DialogResult.OK)
            return;

        openPath = openFileDialog.FileName;
        PopulateForm();
    }

    private void SaveToButton_Click(object sender, EventArgs e)
    {
        if (openPath == "")
            return;

        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Title = "Select Save Location";
        saveFileDialog.Filter = "Any file (*.*)|*.*";
        saveFileDialog.FileName = Path.GetFileNameWithoutExtension(openPath);
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        saveFileDialog.OverwritePrompt = true;

        DialogResult saveFileDialogResult = saveFileDialog.ShowDialog();
        if (saveFileDialogResult != DialogResult.OK)
            return;

        savePath = saveFileDialog.FileName;
        PopulateForm();
    }

    private void ImportButton_Click(object sender, EventArgs e)
    {
        if (openPath == null || savePath == null)
            return;

        try
        {
            GlobalConfig.DataAccessor.ImportZipFileModel(openPath, savePath);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        finally
        {
            this.Close();
            caller.ImportComplete();
        }
    }
}
