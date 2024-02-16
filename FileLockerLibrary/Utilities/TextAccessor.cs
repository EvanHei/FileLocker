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
    //      |   +-- Encryption.salt
    //      |   +-- MACs/
    //      |       +-- Path.txt.hmac
    //      |       +-- Encryption.salt.hmac
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
            // TODO - use Initialize()
            string fileDirectoryPath = Path.Combine(FileModelsDirectoryPath, fileName);
            string filePathPath = Path.Combine(fileDirectoryPath, Constants.FilePathFileName);
            string encryptionSaltPath = Path.Combine(fileDirectoryPath, Constants.EncryptionKeySaltFileName);
            string macSaltPath = Path.Combine(fileDirectoryPath, Constants.MacKeySaltFileName);
            string macPath = Path.Combine(fileDirectoryPath, Constants.MacFileName);

            // TODO - add error checking
            string path = File.ReadAllText(filePathPath);
            FileModel temp = new FileModel(path);

            if (File.Exists(encryptionSaltPath))
                temp.EncryptionKeySalt = File.ReadAllBytes(encryptionSaltPath);
            if (File.Exists(macSaltPath))
                temp.MacKeySalt = File.ReadAllBytes(macSaltPath);
            if (File.Exists(macPath))
                temp.Mac = File.ReadAllBytes(macPath);

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
    /// Generates MACs for all files in the specified directory using the provided key.
    /// </summary>
    /// <param name="key">The key for the MAC generation.</param>
    private void GenerateMacFiles(byte[] key)
    {
        GlobalConfig.MacGenerator.Key = key;

        foreach (string filePath in Directory.GetFiles(FileDirectoryPath))
        {
            byte[] data = File.ReadAllBytes(filePath);
            byte[] mac = GlobalConfig.MacGenerator.GenerateMac(data);
            string macFilePath = Path.Combine(MacPath, Path.GetFileName(filePath) + ".hmac");

            File.WriteAllBytes(macFilePath, mac);
        }
    }

    /// <summary>
    /// Validates MAC files for all files in the user directory using the configured encryption key.
    /// </summary>
    /// <param name="key">The key for the MAC generation.</param>
    /// <returns>True if all MAC files are valid; otherwise, false.</returns>
    private bool ValidateMacFiles(byte[] key)
    {
        GlobalConfig.MacGenerator.Key = key;

        foreach (string filePath in Directory.GetFiles(FileDirectoryPath))
        {
            byte[] data = File.ReadAllBytes(filePath);
            string macFilePath = Path.Combine(MacPath, Path.GetFileNameWithoutExtension(filePath) + ".hmac");

            if (!File.Exists(macFilePath))
                return false;

            byte[] mac = File.ReadAllBytes(macFilePath);

            if (!GlobalConfig.MacGenerator.ValidateMac(data, mac))
                return false;
        }

        return true;
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
