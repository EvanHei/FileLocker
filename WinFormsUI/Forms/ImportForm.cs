﻿using FileLockerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI.Interfaces;

namespace WinFormsUI.Forms;

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
            OpenLabel.Text = Path.GetFileName(openPath);

            SaveToButton.Enabled = true;
            SaveToButton.BackColor = SystemColors.Highlight;
        }
        if (savePath != null)
        {
            string directoryName = Path.GetDirectoryName(savePath);
            string directoryPath = directoryName.Length > 50 ? directoryName.Substring(0, 47) + "..." : directoryName;
            SaveToLabel.Text = directoryPath;
        }
    }

    private void OpenButton_Click(object sender, EventArgs e)
    {
        using OpenFileDialog openFileDialog = new();
        openFileDialog.Title = "Select Archive";
        openFileDialog.Filter = ".zip files (*.zip)|*.zip";
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        if (openFileDialog.ShowDialog() != DialogResult.OK)
            return;

        openPath = openFileDialog.FileName;

        PopulateForm();
    }

    private void SaveToButton_Click(object sender, EventArgs e)
    {
        if (openPath == "")
            return;

        SaveFileDialog saveFileDialog = new();
        saveFileDialog.Title = "Select Save Location";
        saveFileDialog.Filter = "Any file (*.*)|*.*";
        saveFileDialog.FileName = Path.GetFileNameWithoutExtension(openPath);
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        saveFileDialog.OverwritePrompt = true;
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
            return;

        savePath = saveFileDialog.FileName;
        PopulateForm();
    }

    private void SaveToLabel_Click(object sender, EventArgs e)
    {
        if (openPath == null ||
            savePath == null)
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

    private void ImportButton_Click(object sender, EventArgs e)
    {
        if (openPath == null ||
            savePath == null)
            return;

        try
        {
            GlobalConfig.DataAccessor.ImportZipFileModel(openPath, savePath);
            this.Close();
            caller.ImportComplete();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void CloseMenuItem_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
