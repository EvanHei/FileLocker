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
    /// +-- JSON Files/
    //  |   +-- <file1>.json
    //  |   +-- <file2>.json
    //  |   +-- ...
    //  +--

    private string TempExportDirectoryPath { get; set; }
    private string FileModelsDirectoryPath { get; set; }
    private string JsonFilePath { get; set; }

    public void CreateFileModel(FileModel model)
    {
        if (GetAllFileNames().Contains(model.FileName))
            throw new InvalidOperationException($"{model.FileName} already added.");

        SaveFileModel(model);

        GlobalConfig.Logger.Info($"File Created - {model.FileName}");
    }

    public void SaveFileModel(FileModel model)
    {
        if (model == null)
            throw new ArgumentNullException("Model cannot be null.", nameof(model));

        InitializeJsonFilePath(model.FileName);

        string jsonString = JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(JsonFilePath, jsonString);

        GlobalConfig.Logger.Info($"File Saved - {model.FileName}");
    }

    public void DeleteFileModel(FileModel model)
    {
        InitializeJsonFilePath(model.FileName);
        if (File.Exists(JsonFilePath))
        {
            File.Delete(JsonFilePath);

            GlobalConfig.Logger.Info($"File Deleted - {model.FileName}");
        }
    }

    public List<FileModel> LoadAllFileModels()
    {
        List<FileModel> output = new();

        foreach (string fileName in GetAllFileNames())
        {
            InitializeJsonFilePath(fileName);

            string jsonString = File.ReadAllText(JsonFilePath);
            FileModel temp = JsonSerializer.Deserialize<FileModel>(jsonString);

            output.Add(temp);
        }

        return output;
    }

    public void ShredFile(string path)
    {
        if (string.IsNullOrEmpty(path))
            throw new ArgumentException("Path cannot be null or empty.", nameof(path));

        using (FileStream stream = new(path, FileMode.Open, FileAccess.Write))
        {
            Random random = new();
            byte[] buffer = new byte[1024];

            // overwrite with random data
            long remainingBytes = stream.Length;
            while (remainingBytes > 0)
            {
                // calculate the size of the next chunk to overwrite
                int chunkSize = (int)Math.Min(buffer.Length, remainingBytes);
                random.NextBytes(buffer);
                stream.Write(buffer, 0, chunkSize);
                remainingBytes -= chunkSize;
            }
        }

        File.Delete(path);

        GlobalConfig.Logger.Info($"File Shredded - {Path.GetFileNameWithoutExtension(path)}");
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

        InitializeJsonFilePath(model.FileName);

        GenerateExportDirectory(model);

        CreateArchiveFromExportDirectory(zipPath);

        Directory.Delete(TempExportDirectoryPath, recursive: true);

        GlobalConfig.Logger.Info($"File Exported - {model.FileName}");
    }

    private void GenerateExportDirectory(FileModel model)
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

        // create file model and save
        CreateFileModel(model);

        GlobalConfig.Logger.Info($"File Imported - {model.FileName}");
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

    private void InitializeJsonFilePath(string fileName)
    {
        string extension = Path.GetExtension(fileName);
        fileName = (extension == Constants.AesExtension || extension == Constants.TripleDesExtension) ? Path.GetFileNameWithoutExtension(fileName) : fileName;
        JsonFilePath = Path.Combine(FileModelsDirectoryPath, fileName + Constants.JsonExtension);
    }

    public JsonAccessor()
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
