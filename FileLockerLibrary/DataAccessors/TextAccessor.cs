using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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
        if (model.EncryptionStatus == true)
            throw new InvalidOperationException("File cannot already be locked.");

        InitializePaths(model.FileName);

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
            throw new DirectoryNotFoundException($"Directory '{model.FileName}' does not exist.");

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
        List<FileModel> output = new List<FileModel>();

        foreach (string fileName in GetAllFileNames())
        {
            InitializePaths(fileName);

            // TODO - add error checking
            string path = File.ReadAllText(FilePathPath);
            FileModel temp = new FileModel(path);

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
        string appDirectoryPath = Path.Combine(appDataPath, "FileLocker");
        FileModelsDirectoryPath = Path.Combine(appDirectoryPath, "FileModels");

        if (!Directory.Exists(FileModelsDirectoryPath))
            Directory.CreateDirectory(FileModelsDirectoryPath);
    }
}
