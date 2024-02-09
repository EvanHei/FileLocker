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
    //      |   +-- Password.hash
    //      |   +-- EncryptionStatus.txt
    //      +-- ...

    private const string FILE_PATH_FILE_NAME = "Path.txt";
    private const string ENCRYPTION_KEY_SALT_FILE_NAME = "EncryptionKey.salt";
    private const string PASSWORD_HASH_FILE_NAME = "Password.hash";
    private const string ENCRYPTION_STATUS_FILE_NAME = "EncryptionStatus.txt";

    private string FileModelsDirectoryPath { get; set; }
    private string FileDirectoryPath { get; set; }
    private string FilePathPath { get; set; }
    private string PasswordHashPath { get; set; }
    private string EncryptionKeySaltPath { get; set; }
    private string EncryptionStatusPath { get; set; }

    /// <summary>
    /// Saves the file model.
    /// </summary>
    /// <param name="model">The file model to be saved.</param>
    /// <exception cref="ArgumentNullException">Thrown if the file model is null.</exception>
    /// <exception cref="ArgumentException">Thrown if the file path or encryption salt is null or empty.</exception>
    /// <exception cref="InvalidOperationException">Thrown if the directory already exists.</exception>
    public void SaveFileModel(FileModel model)
    {
        if (model == null)
            throw new ArgumentNullException(nameof(model));
        if (string.IsNullOrEmpty(model.Path))
            throw new ArgumentException("File path cannot be null or empty.", nameof(model.Path));
        if (model.EncryptionKeySalt == null || model.EncryptionKeySalt.Length == 0)
            throw new ArgumentException("Encryption salt cannot be null or empty.", nameof(model.EncryptionKeySalt));

        InitializePaths(Path.GetFileName(model.Path));

        // if the file name already exists
        if (Directory.Exists(FileDirectoryPath))
            throw new InvalidOperationException($"Directory '{Path.GetFileName(model.Path)}' already exists.");

        // write to the files
        Directory.CreateDirectory(FileDirectoryPath);
        File.WriteAllText(FilePathPath, model.Path);
        File.WriteAllText(PasswordHashPath, model.PasswordHash);
        File.WriteAllBytes(EncryptionKeySaltPath, model.EncryptionKeySalt);
        File.WriteAllText(EncryptionStatusPath, model.EncryptionStatus.ToString());
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
            string fileDirectoryPath = Path.Combine(FileModelsDirectoryPath, fileName);
            string filePathPath = Path.Combine(fileDirectoryPath, FILE_PATH_FILE_NAME);
            string encryptionSaltPath = Path.Combine(fileDirectoryPath, ENCRYPTION_KEY_SALT_FILE_NAME);
            string passwordHashPath = Path.Combine(fileDirectoryPath, PASSWORD_HASH_FILE_NAME);
            string encryptionStatusPath = Path.Combine(fileDirectoryPath, ENCRYPTION_STATUS_FILE_NAME);

            // TODO - add error checking

            FileModel temp = new FileModel();
            temp.Path = File.ReadAllText(filePathPath);
            temp.Content = File.ReadAllBytes(temp.Path);
            temp.PasswordHash = File.ReadAllText(passwordHashPath);
            temp.EncryptionKeySalt = File.ReadAllBytes(encryptionSaltPath);
            temp.EncryptionStatus = bool.Parse(File.ReadAllText(encryptionStatusPath));

            output.Add(temp);
        }

        return output;
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
            .Select(path => Path.GetFileName(path))
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
        FilePathPath = Path.Combine(FileDirectoryPath, FILE_PATH_FILE_NAME);
        EncryptionKeySaltPath = Path.Combine(FileDirectoryPath, ENCRYPTION_KEY_SALT_FILE_NAME);
        PasswordHashPath = Path.Combine(FileDirectoryPath, PASSWORD_HASH_FILE_NAME);
        EncryptionStatusPath = Path.Combine(FileDirectoryPath, ENCRYPTION_STATUS_FILE_NAME);
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
