using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public class TextAccessor
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


    /// <summary>
    /// Creates a file model and populates the salt properties.
    /// </summary>
    /// <param name="model">The file model to be created.</param>
    /// <exception cref="ArgumentNullException">Thrown if the file model is null.</exception>
    /// <exception cref="ArgumentException">Thrown if the file path is null or empty.</exception>
    /// <exception cref="InvalidOperationException">Thrown if the directory already exists.</exception>
    public void CreateFileModel(FileModel model)
    {
        if (model == null)
            throw new ArgumentNullException("Model cannot be null.", nameof(model));
        if (string.IsNullOrEmpty(model.Path))
            throw new ArgumentException("Path cannot be null or empty.", nameof(model.Path));

        if (model.EncryptionStatus == true)
            InitializePaths(Path.GetFileNameWithoutExtension(model.Path));
        else
            InitializePaths(model.FileName);

        // if the file name already exists
        if (Directory.Exists(FileDirectoryPath))
            throw new InvalidOperationException($"Directory '{model.FileName}' already exists.");

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

    /// <summary>
    /// Loads all file models.
    /// </summary>
    /// <returns>A list of file models.</returns>
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

    /// <summary>
    /// Deletes a file model.
    /// </summary>
    /// <param name="model">The file model to be deleted.</param>
    /// <exception cref="InvalidOperationException">Thrown if the file is encrypted.</exception>
    /// <exception cref="DirectoryNotFoundException">Thrown if the directory does not exist.</exception>
    public void DeleteFileModel(FileModel model)
    {
        if (model.EncryptionStatus == true)
            throw new InvalidOperationException("Cannot delete a file that is encrypted.");
        if (!GetAllFileNames().Contains(model.FileName))
            throw new DirectoryNotFoundException($"Directory '{model.FileName}' does not exist.");

        InitializePaths(model.FileName);

        Directory.Delete(FileDirectoryPath, true);
    }

    /// <summary>
    /// Retrieves all file names.
    /// </summary>
    /// <returns>A list of file names.</returns>
    /// <exception cref="DirectoryNotFoundException">Thrown if the directory containing file models is not found.</exception>
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

    /// <summary>
    /// Initializes paths.
    /// </summary>
    /// <param name="fileName">The file for which file paths are to be initialized.</param>
    private void InitializePaths(string fileName)
    {
        FileDirectoryPath = Path.Combine(FileModelsDirectoryPath, fileName);
        FilePathPath = Path.Combine(FileDirectoryPath, Constants.FilePathFileName);
        EncryptionKeySaltPath = Path.Combine(FileDirectoryPath, Constants.EncryptionKeySaltFileName);
        MacPath = Path.Combine(FileDirectoryPath, Constants.MacFileName);
        MacKeySaltPath = Path.Combine(FileDirectoryPath, Constants.MacKeySaltFileName);
    }

    /// <summary>
    /// Initializes a new instance of the TextAccessor class.
    /// </summary>
    public TextAccessor()
    {
        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string appDirectoryPath = Path.Combine(appDataPath, "FileLocker");
        FileModelsDirectoryPath = Path.Combine(appDirectoryPath, "FileModels");

        if (!Directory.Exists(FileModelsDirectoryPath))
            Directory.CreateDirectory(FileModelsDirectoryPath);
    }
}
