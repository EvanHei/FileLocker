using FileLockerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsUI;

public partial class RelocateForm : Form
{
    private IRelocateFormCaller caller;
    private FileModel model;

    public RelocateForm(IRelocateFormCaller caller, FileModel model)
    {
        InitializeComponent();

        this.caller = caller;
        this.model = model;

        PopulateForm();
    }

    private void PopulateForm()
    {
        CantLocateFileLabel.Text = $"Can't locate \"{model.FileName}\"";
        LastSeenLabel.Text = $"It was last seen at {model.Path}";
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

    private void RelocateButton_Click(object sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new();
        openFileDialog.Title = "Relocate File";
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        if (openFileDialog.ShowDialog() != DialogResult.OK)
            return;

        string newPath = openFileDialog.FileName;
        if (Path.GetFileName(newPath) != model.FileName)
            return;

        GlobalConfig.DataAccessor.RelocateFile(model, newPath);

        this.Close();
        caller.RelocationComplete();
    }

    private void RemoveButton_Click(object sender, EventArgs e)
    {
        try
        {
            GlobalConfig.DataAccessor.DeleteFileModel(model);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        this.Close();
        caller.RemovalComplete();
    }
}
