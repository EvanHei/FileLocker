using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Tar;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FileLockerLibrary;

public class JsonAccessor : IDataAccessor
{
    // File structure:
    /// +-- JSON FileModels/
    //  |   +-- <file1>.json
    //  |   +-- <file2>.json
    //  |   +-- ...
    //  +-- JSON KeyPairModels/
    //  |   +-- <file3>.json
    //  |   +-- <file4>.json
    //  |   +-- ...
    //  +-- ...

    private string TempExportDirectoryPath { get; set; }
    private string FileModelsDirectoryPath { get; set; }
    private string KeyPairModelsDirectoryPath { get; set; }
    private string JsonFilePath { get; set; }

    public void CreateFileModel(FileModel model)
    {
        if (GetAllFileNames().Contains(model.FileName))
            throw new InvalidOperationException($"{model.FileName} already added.");

        model.DateAdded = DateTime.Now;
        SaveFileModel(model);
    }

    public void SaveFileModel(FileModel model)
    {
        if (model == null)
            throw new ArgumentNullException("Model cannot be null.", nameof(model));

        InitializeFileModelJsonFilePath(model.FileName);

        string jsonString = JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(JsonFilePath, jsonString);
    }

    public void DeleteFileModel(FileModel model)
    {
        InitializeFileModelJsonFilePath(model.FileName);

        if (File.Exists(JsonFilePath))
            File.Delete(JsonFilePath);

        GlobalConfig.Logger.Log($"File removed from scope - {model.FileName}", LogLevel.Information);
    }

    public List<FileModel> LoadAllFileModels()
    {
        List<FileModel> output = new();

        foreach (string fileName in GetAllFileNames())
        {
            InitializeFileModelJsonFilePath(fileName);

            string jsonString = File.ReadAllText(JsonFilePath);
            FileModel temp = JsonSerializer.Deserialize<FileModel>(jsonString);

            output.Add(temp);
        }

        return output;
    }

    public void RelocateFile(FileModel model, string newPath)
    {
        model.Path = newPath;
        SaveFileModel(model);
    }

    public void ExportZipFileModel(FileModel model, string zipPath)
    {
        if (model == null)
            throw new ArgumentNullException("Model cannot be null.", nameof(model));

        InitializeFileModelJsonFilePath(model.FileName);

        GenerateFileModelExportDirectory(model);

        CreateArchiveFromExportDirectory(zipPath);

        Directory.Delete(TempExportDirectoryPath, recursive: true);
    }

    private void GenerateFileModelExportDirectory(FileModel model)
    {
        if (string.IsNullOrEmpty(model.Path))
            throw new ArgumentException("Path cannot be null or empty.", nameof(model.Path));
        if (!File.Exists(JsonFilePath))
            throw new FileNotFoundException($"File '{JsonFilePath}' does not exist.");

        CreateTempExportDirectory();

        // insert source file data into TempExportDirectoryPath
        byte[] content = File.ReadAllBytes(model.Path);
        string tempContentPath = Path.Combine(TempExportDirectoryPath, model.FileName);
        File.WriteAllBytes(tempContentPath, content);

        // insert JSON file without the path
        string tempJsonFilePath = Path.Combine(TempExportDirectoryPath, model.FileName + Constants.JsonExtension);
        string originalPath = model.Path;
        model.Path = "";
        string jsonString = JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true });
        model.Path = originalPath;
        File.WriteAllText(tempJsonFilePath, jsonString);
    }

    private void CreateTempExportDirectory()
    {
        Directory.CreateDirectory(TempExportDirectoryPath);
        FileAttributes attributes = File.GetAttributes(TempExportDirectoryPath);
        attributes |= FileAttributes.Hidden;
        File.SetAttributes(TempExportDirectoryPath, attributes);
    }

    private void CreateArchiveFromExportDirectory(string zipPath)
    {
        if (string.IsNullOrEmpty(zipPath))
            throw new ArgumentException("Zip path cannot be null or empty.", nameof(zipPath));

        if (File.Exists(zipPath))
            File.Delete(zipPath);

        // create archive
        ZipFile.CreateFromDirectory(TempExportDirectoryPath, zipPath);
    }

    public void ImportZipFileModel(string zipPath, string savePath)
    {
        if (string.IsNullOrEmpty(zipPath))
            throw new ArgumentException("Zip path cannot be null or empty.", nameof(zipPath));

        using ZipArchive archive = ZipFile.OpenRead(zipPath);
        List<string> zipEntriesToProcess = GetZipEntryNames(archive);

        // get JSON file
        string jsonFilePath = zipEntriesToProcess.Where(filePath => Path.GetExtension(filePath).Equals(Constants.JsonExtension)).First();
        ZipArchiveEntry jsonEntry = archive.GetEntry(jsonFilePath);
        zipEntriesToProcess.Remove(jsonFilePath);

        // get content file
        ZipArchiveEntry contentEntry = archive.GetEntry(zipEntriesToProcess.First());

        if (contentEntry == null ||
            jsonEntry == null)
            throw new FileNotFoundException($"Archive does not contain the necessary files.");

        // read the JSON file and create the FileModel
        FileModel model = new(savePath);
        using (MemoryStream ms = new())
        using (Stream stream = jsonEntry.Open())
        {
            stream.CopyTo(ms);
            string jsonString = Encoding.UTF8.GetString(ms.ToArray());
            model = JsonSerializer.Deserialize<FileModel>(jsonString);
            model.Path = savePath;
        }

        // read the content and save to the chosen path
        byte[] content;
        using (MemoryStream ms = new())
        using (Stream stream = contentEntry.Open())
        {
            stream.CopyTo(ms);
            content = ms.ToArray();
            File.WriteAllBytes(model.Path, content);
        }

        // create model and save
        CreateFileModel(model);
    }

    public void CreateKeyPairModel(KeyPairModel model, string password)
    {
        if (LoadAllKeyPairModels().Any(keyPairModel => keyPairModel.Name == model.Name))
            throw new InvalidOperationException($"{model.Name} already added.");

        // temporarily encrypt the private key
        byte[] privateKey = model.PrivateKey;
        byte[] encryptionKey = GlobalConfig.KeyDeriver.DeriveKey(password);
        model.PrivateKey = GlobalConfig.Encryptor(EncryptionAlgorithm.AES).Encrypt(model.PrivateKey, encryptionKey);

        string jsonFilePath = InitializeKeyPairModelJsonFilePath(model.Name);
        string jsonString = JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(jsonFilePath, jsonString);

        model.PrivateKey = privateKey;

        GlobalConfig.Logger.Log($"Key pair created - {model.Name}", LogLevel.Information);
    }

    public void DeleteKeyPairModel(KeyPairModel model)
    {
        string jsonFilePath = InitializeKeyPairModelJsonFilePath(model.Name);

        if (File.Exists(jsonFilePath))
            File.Delete(jsonFilePath);

        GlobalConfig.Logger.Log($"Key pair deleted - {model.Name}", LogLevel.Information);
    }

    public List<KeyPairModel> LoadAllPrivateKeyPairModels()
    {
        return LoadAllKeyPairModels().Where(model => model.PrivateKey != null).ToList();
    }

    public List<KeyPairModel> LoadAllPublicKeyPairModels()
    {
        return LoadAllKeyPairModels().Where(model => model.PrivateKey == null).ToList();
    }

    public List<KeyPairModel> LoadAllKeyPairModels()
    {
        List<KeyPairModel> output = new();
        string[] filePaths = Directory.GetFiles(KeyPairModelsDirectoryPath, "*" + Constants.JsonExtension);

        foreach (string filePath in filePaths)
        {
            string jsonString = File.ReadAllText(filePath);
            KeyPairModel temp = JsonSerializer.Deserialize<KeyPairModel>(jsonString);
            output.Add(temp);
        }

        return output;
    }

    public void ExportZipKeyPairModel(KeyPairModel model, string zipPath)
    {
        if (model == null)
            throw new ArgumentNullException("Model cannot be null.", nameof(model));

        GenerateKeyPairModelExportDirectory(model);

        CreateArchiveFromExportDirectory(zipPath);

        Directory.Delete(TempExportDirectoryPath, recursive: true);
    }

    private void GenerateKeyPairModelExportDirectory(KeyPairModel model)
    {
        if (model.PublicKey == null)
            throw new ArgumentException("PublicKey cannot be null or empty.", nameof(model.PublicKey));

        string jsonFilePath = InitializeKeyPairModelJsonFilePath(model.Name);

        if (!File.Exists(jsonFilePath))
            throw new FileNotFoundException($"File '{jsonFilePath}' does not exist.");

        CreateTempExportDirectory();

        // insert JSON file without the private key
        string tempJsonFilePath = Path.Combine(TempExportDirectoryPath, model.Name + Constants.JsonExtension);
        byte[] originalPrivateKey = model.PrivateKey;
        model.PrivateKey = null;
        string jsonString = JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true });
        model.PrivateKey = originalPrivateKey;
        File.WriteAllText(tempJsonFilePath, jsonString);
    }

    public void ImportZipKeyPairModel(string zipPath)
    {
        if (string.IsNullOrEmpty(zipPath))
            throw new ArgumentException("Zip path cannot be null or empty.", nameof(zipPath));

        using ZipArchive archive = ZipFile.OpenRead(zipPath);
        ZipArchiveEntry jsonEntry = archive.Entries.FirstOrDefault();

        if (jsonEntry == null)
            throw new FileNotFoundException($"Archive does not contain the necessary file.");

        // read the JSON file and create the FileModel
        using MemoryStream ms = new();
        using Stream stream = jsonEntry.Open();
        stream.CopyTo(ms);
        string jsonString = Encoding.UTF8.GetString(ms.ToArray());
        KeyPairModel model = JsonSerializer.Deserialize<KeyPairModel>(jsonString);

        // create model and save
        if (LoadAllKeyPairModels().Any(keyPairModel => keyPairModel.Name == model.Name))
            throw new InvalidOperationException($"{model.Name} already added.");

        string jsonFilePath = InitializeKeyPairModelJsonFilePath(model.Name);
        File.WriteAllText(jsonFilePath, jsonString);

        GlobalConfig.Logger.Log($"Public key imported - {model.Name}", LogLevel.Information);
    }

    private List<string> GetZipEntryNames(ZipArchive archive)
    {
        List<string> output = new();

        foreach (ZipArchiveEntry entry in archive.Entries)
            output.Add(entry.FullName);

        return output;
    }

    private List<string> GetAllFileNames()
    {
        if (!Directory.Exists(FileModelsDirectoryPath))
            throw new DirectoryNotFoundException($"Directory not found: {FileModelsDirectoryPath}");

        List<string> output = new();

        string[] filePaths = Directory.GetFiles(FileModelsDirectoryPath, "*" + Constants.JsonExtension);
        foreach (string filePath in filePaths)
        {
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            output.Add(fileName);
        }

        return output;
    }

    // TODO - refactor InitializeFileModelJsonFilePath() similar to InitializeKeyPairModelJsonFilePath()
    private void InitializeFileModelJsonFilePath(string fileName)
    {
        string extension = Path.GetExtension(fileName);
        fileName = (extension == Constants.AesExtension || extension == Constants.TripleDesExtension) ? Path.GetFileNameWithoutExtension(fileName) : fileName;
        JsonFilePath = Path.Combine(FileModelsDirectoryPath, fileName + Constants.JsonExtension);
    }

    private string InitializeKeyPairModelJsonFilePath(string keyPairName)
    {
        return Path.Combine(KeyPairModelsDirectoryPath, keyPairName + Constants.JsonExtension);
    }

    public JsonAccessor()
    {
        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string appDirectoryPath = Path.Combine(appDataPath, Constants.AppDirectoryName);
        FileModelsDirectoryPath = Path.Combine(appDirectoryPath, Constants.FileModelsDirectoryName);
        KeyPairModelsDirectoryPath = Path.Combine(appDirectoryPath, Constants.KeyPairModelsDirectoryName);
        TempExportDirectoryPath = Path.Combine(appDirectoryPath, Constants.TempExportDirectoryName);

        // create hidden data directories
        Directory.CreateDirectory(FileModelsDirectoryPath);
        Directory.CreateDirectory(KeyPairModelsDirectoryPath);
        FileAttributes attributes = File.GetAttributes(FileModelsDirectoryPath);
        attributes |= FileAttributes.Hidden;
        File.SetAttributes(FileModelsDirectoryPath, attributes);
        File.SetAttributes(KeyPairModelsDirectoryPath, attributes);
    }
}
