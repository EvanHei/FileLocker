using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Tar;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public class TextAccessor : IDataAccessor
{
    // File structure:
    /// +-- FileModels/
    //      +-- <file>/
    //      |   +-- Path.txt
    //      |   +-- EncryptionKey.salt
    //      |   +-- MacKey.salt
    //      |   +-- Content.mac
    //      +-- ...

    private string TempExportDirectoryPath { get; set; }
    private string FileModelsDirectoryPath { get; set; }
    private string FileDirectoryPath { get; set; }
    private string FilePathPath { get; set; }
    private string EncryptionKeySaltPath { get; set; }
    private string MacPath { get; set; }
    private string MacKeySaltPath { get; set; }

    public void CreateFileModel(FileModel model)
    {
        if (model == null)
            throw new ArgumentNullException("Model cannot be null.", nameof(model));
        if (string.IsNullOrEmpty(model.Path))
            throw new ArgumentException("Path cannot be null or empty.", nameof(model.Path));
        if (model.EncryptionStatus == true && model.EncryptionKeySalt == null)
            throw new InvalidOperationException("File is missing data to be unlocked.");

        InitializePaths(model.FileName);

        // TODO - change to use GetAllFilenames()?
        // if the file name already exists
        if (Directory.Exists(FileDirectoryPath))
            throw new InvalidOperationException($"{model.FileName} already added.");

        // write to the files
        Directory.CreateDirectory(FileDirectoryPath);
        File.WriteAllText(FilePathPath, model.Path);
    }

    public void SaveFileModel(FileModel model)
    {
        if (model == null)
            throw new ArgumentNullException("Model cannot be null.", nameof(model));
        if (string.IsNullOrEmpty(model.Path))
            throw new ArgumentException("Path cannot be null or empty.", nameof(model.Path));

        if (model.EncryptionStatus == true)
            InitializePaths(Path.GetFileNameWithoutExtension(model.Path));
        else
            InitializePaths(model.FileName);

        // if the directory doesn't exist
        if (!Directory.Exists(FileDirectoryPath))
            throw new DirectoryNotFoundException($"Directory '{FileDirectoryPath}' does not exist.");

        // write to the files
        File.WriteAllText(FilePathPath, model.Path);

        if (model.EncryptionKeySalt != null)
            File.WriteAllBytes(EncryptionKeySaltPath, model.EncryptionKeySalt);
        else
            File.Delete(EncryptionKeySaltPath);

        if (model.MacKeySalt != null)
            File.WriteAllBytes(MacKeySaltPath, model.MacKeySalt);
        else
            File.Delete(MacKeySaltPath);

        if (model.Mac != null)
            File.WriteAllBytes(MacPath, model.Mac);
        else
            File.Delete(MacPath);
    }

    public List<FileModel> LoadAllFileModels()
    {
        List<FileModel> output = new();

        foreach (string fileName in GetAllFileNames())
        {
            InitializePaths(fileName);

            // TODO - add error checking
            string path = File.ReadAllText(FilePathPath);
            FileModel temp = new(path);

            if (File.Exists(EncryptionKeySaltPath))
                temp.EncryptionKeySalt = File.ReadAllBytes(EncryptionKeySaltPath);
            if (File.Exists(MacKeySaltPath))
                temp.MacKeySalt = File.ReadAllBytes(MacKeySaltPath);
            if (File.Exists(MacPath))
                temp.Mac = File.ReadAllBytes(MacPath);

            output.Add(temp);
        }

        return output;
    }

    public void ExportZipFileModel(FileModel model, string zipPath)
    {
        if (model == null)
            throw new ArgumentNullException("Model cannot be null.", nameof(model));
        if (string.IsNullOrEmpty(model.Path))
            throw new ArgumentException("Path cannot be null or empty.", nameof(model.Path));
        if (string.IsNullOrEmpty(zipPath))
            throw new ArgumentException("Zip path cannot be null or empty.", nameof(zipPath));

        if (model.EncryptionStatus == true)
            InitializePaths(Path.GetFileNameWithoutExtension(model.Path));
        else
            InitializePaths(model.FileName);

        if (!Directory.Exists(FileDirectoryPath))
            throw new DirectoryNotFoundException($"Directory '{FileDirectoryPath}' does not exist.");

        // write necessary files to a temporary hidden export file
        Directory.CreateDirectory(TempExportDirectoryPath);
        FileAttributes attributes = File.GetAttributes(TempExportDirectoryPath);
        attributes |= FileAttributes.Hidden;
        File.SetAttributes(TempExportDirectoryPath, attributes);

        byte[] content = File.ReadAllBytes(model.Path);
        string tempContentPath = Path.Combine(TempExportDirectoryPath, model.FileName);
        File.WriteAllBytes(tempContentPath, content);

        // copy all files in the model's directory to the export directory, except the path file
        foreach (string path in Directory.GetFiles(FileDirectoryPath))
        {
            if (Path.GetFileName(path) == Constants.FilePathFileName)
                continue;

            string fileName = Path.GetFileName(path);
            string destinationPath = Path.Combine(TempExportDirectoryPath, fileName);
            File.Copy(path, destinationPath, overwrite: true);
        }

        if (File.Exists(zipPath))
            File.Delete(zipPath);

        ZipFile.CreateFromDirectory(TempExportDirectoryPath, zipPath);
        Directory.Delete(TempExportDirectoryPath, recursive: true);

        // change extension
        string newFilePath = Path.ChangeExtension(zipPath, Constants.ExportExtension);
        File.Move(zipPath, newFilePath);
    }

    public void ImportZipFileModel(string zipPath, string savePath)
    {
        if (string.IsNullOrEmpty(zipPath))
            throw new ArgumentException("Zip path cannot be null or empty.", nameof(zipPath));

        using ZipArchive archive = ZipFile.OpenRead(zipPath);

        // get all entries in the zip file
        List<string> zipEntriesToProcess = new();
        foreach (ZipArchiveEntry entry in archive.Entries)
            zipEntriesToProcess.Add(entry.FullName);

        // error checking
        if (zipEntriesToProcess.Count < 1 || zipEntriesToProcess.Count > 5)
            throw new FileNotFoundException($"Archive has invalid number of files.");

        FileModel model = new(savePath);

        // if the file is locked, populate the model
        string[] filesToCheck = { Constants.EncryptionKeySaltFileName, Constants.MacFileName, Constants.MacKeySaltFileName };
        if (zipEntriesToProcess.Any(entry => entry.EndsWith(Constants.EncryptedExtension, StringComparison.OrdinalIgnoreCase)) &&
            filesToCheck.All(zipEntriesToProcess.Contains))
        {
            ZipArchiveEntry encryptionKeySaltEntry = archive.GetEntry(Constants.EncryptionKeySaltFileName);
            ZipArchiveEntry macKeySaltEntry = archive.GetEntry(Constants.MacKeySaltFileName);
            ZipArchiveEntry macEntry = archive.GetEntry(Constants.MacFileName);

            // read the encryption key salt
            using (MemoryStream ms = new())
            using (Stream stream = encryptionKeySaltEntry.Open())
            {
                stream.CopyTo(ms);
                model.EncryptionKeySalt = ms.ToArray();
                zipEntriesToProcess.Remove(Constants.EncryptionKeySaltFileName);
            }

            // read the MAC key salt
            using (MemoryStream ms = new())
            using (Stream stream = macKeySaltEntry.Open())
            {
                stream.CopyTo(ms);
                model.MacKeySalt = ms.ToArray();
                zipEntriesToProcess.Remove(Constants.MacKeySaltFileName);
            }

            // read the MAC
            using (MemoryStream ms = new())
            using (Stream stream = macEntry.Open())
            {
                stream.CopyTo(ms);
                model.Mac = ms.ToArray();
                zipEntriesToProcess.Remove(Constants.MacFileName);
            }
        }

        byte[] content;
        ZipArchiveEntry contentEntry = archive.GetEntry(zipEntriesToProcess.First());

        // read the content and save to the choosen path
        using (MemoryStream ms = new())
        using (Stream stream = contentEntry.Open())
        {
            stream.CopyTo(ms);
            content = ms.ToArray();
            zipEntriesToProcess.Clear();
        }
        File.WriteAllBytes(model.Path, content);

        // create file model and save
        CreateFileModel(model);
        SaveFileModel(model);
    }

    public void DeleteFileModel(FileModel model)
    {
        string fileName = (model.EncryptionStatus == true) ? Path.GetFileNameWithoutExtension(model.FileName) : model.FileName;
        if (!GetAllFileNames().Contains(fileName))
            throw new DirectoryNotFoundException($"{model.FileName} is not added.");

        InitializePaths(model.FileName);

        Directory.Delete(FileDirectoryPath, true);
    }

    private List<string> GetAllFileNames()
    {
        if (!Directory.Exists(FileModelsDirectoryPath))
            throw new DirectoryNotFoundException($"Directory not found: {FileModelsDirectoryPath}");

        List<string> output = Directory
            .GetDirectories(FileModelsDirectoryPath)
            .Select(Path.GetFileName)
            .ToList();

        return output;
    }

    private void InitializePaths(string fileName)
    {
        fileName = (Path.GetExtension(fileName) == Constants.EncryptedExtension) ? Path.GetFileNameWithoutExtension(fileName) : fileName;

        FileDirectoryPath = Path.Combine(FileModelsDirectoryPath, fileName);
        FilePathPath = Path.Combine(FileDirectoryPath, Constants.FilePathFileName);
        EncryptionKeySaltPath = Path.Combine(FileDirectoryPath, Constants.EncryptionKeySaltFileName);
        MacPath = Path.Combine(FileDirectoryPath, Constants.MacFileName);
        MacKeySaltPath = Path.Combine(FileDirectoryPath, Constants.MacKeySaltFileName);
    }

    public TextAccessor()
    {
        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string appDirectoryPath = Path.Combine(appDataPath, Constants.AppDirectoryName);
        FileModelsDirectoryPath = Path.Combine(appDirectoryPath, Constants.FileModelsDirectoryName);
        TempExportDirectoryPath = Path.Combine(appDirectoryPath, Constants.TempExportDirectoryName);

        // create data directory and hide it
        Directory.CreateDirectory(FileModelsDirectoryPath);
        FileAttributes attributes = File.GetAttributes(FileModelsDirectoryPath);
        attributes |= FileAttributes.Hidden;
        File.SetAttributes(FileModelsDirectoryPath, attributes);
    }
}
