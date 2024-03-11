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
        if (GetAllFileNames().Contains(model.FileName))
            throw new InvalidOperationException($"{model.FileName} already added.");

        InitializePaths(model.FileName);

        Directory.CreateDirectory(FileDirectoryPath);
        WriteFileModelToFiles(model);

        GlobalConfig.Logger.Info($"File Created - {model.FileName}");
    }

    public void SaveFileModel(FileModel model)
    {
        if (model == null)
            throw new ArgumentNullException("Model cannot be null.", nameof(model));

        InitializePaths(model.FileName);

        WriteFileModelToFiles(model);

        GlobalConfig.Logger.Info($"File Saved - {model.FileName}");
    }

    private void WriteFileModelToFiles(FileModel model)
    {
        if (model == null)
            throw new ArgumentNullException("Model cannot be null.", nameof(model));
        if (string.IsNullOrEmpty(model.Path))
            throw new ArgumentException("Path cannot be null or empty.", nameof(model.Path));
        if (!Directory.Exists(FileDirectoryPath))
            throw new DirectoryNotFoundException($"Directory '{FileDirectoryPath}' does not exist.");
        if (model.EncryptionStatus == true && model.EncryptionKeySalt.Length == 0)
            throw new InvalidOperationException("File is missing data to be unlocked.");

        File.WriteAllText(FilePathPath, model.Path);
        File.WriteAllBytes(EncryptionKeySaltPath, model.EncryptionKeySalt);
        File.WriteAllBytes(MacKeySaltPath, model.MacKeySalt);
        File.WriteAllBytes(MacPath, model.Mac);
    }

    public void DeleteFileModel(FileModel model)
    {
        InitializePaths(model.FileName);

        if (Directory.Exists(FileDirectoryPath))
        {
            Directory.Delete(FileDirectoryPath, true);

            GlobalConfig.Logger.Info($"File Deleted - {model.FileName}");
        }
    }

    public List<FileModel> LoadAllFileModels()
    {
        List<FileModel> output = new();

        foreach (string fileName in GetAllFileNames())
        {
            InitializePaths(fileName);

            string path = File.ReadAllText(FilePathPath);
            FileModel temp = new(path);
            ReadFileModelFromFiles(temp);
            output.Add(temp);
        }

        return output;
    }

    private void ReadFileModelFromFiles(FileModel model)
    {
        model.EncryptionKeySalt = File.ReadAllBytes(EncryptionKeySaltPath);
        model.MacKeySalt = File.ReadAllBytes(MacKeySaltPath);
        model.Mac = File.ReadAllBytes(MacPath);
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

    public void ExportZipFileModel(FileModel model, string zipPath)
    {
        if (model == null)
            throw new ArgumentNullException("Model cannot be null.", nameof(model));

        InitializePaths(model.FileName);

        GenerateExportDirectory(model);

        CreateArchiveFromExportDirectory(zipPath);

        Directory.Delete(TempExportDirectoryPath, recursive: true);

        GlobalConfig.Logger.Info($"File Exported - {model.FileName}");
    }

    private void GenerateExportDirectory(FileModel model)
    {
        if (string.IsNullOrEmpty(model.Path))
            throw new ArgumentException("Path cannot be null or empty.", nameof(model.Path));
        if (!Directory.Exists(FileDirectoryPath))
            throw new DirectoryNotFoundException($"Directory '{FileDirectoryPath}' does not exist.");

        CreateExportDirectory();

        // copy source file data to TempExportDirectoryPath
        byte[] content = File.ReadAllBytes(model.Path);
        string tempContentPath = Path.Combine(TempExportDirectoryPath, model.FileName);
        File.WriteAllBytes(tempContentPath, content);

        // copy all files in the model's directory to TempExportDirectoryPath, except the path file
        foreach (string path in Directory.GetFiles(FileDirectoryPath))
        {
            if (Path.GetFileName(path) == Constants.FilePathFileName)
                continue;

            string fileName = Path.GetFileName(path);
            string destinationPath = Path.Combine(TempExportDirectoryPath, fileName);
            File.Copy(path, destinationPath, overwrite: true);
        }
    }

    private void CreateExportDirectory()
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

        // change .zip extension
        string newFilePath = Path.ChangeExtension(zipPath, Constants.ExportExtension);
        File.Move(zipPath, newFilePath);
    }

    public void ImportZipFileModel(string zipPath, string savePath)
    {
        if (string.IsNullOrEmpty(zipPath))
            throw new ArgumentException("Zip path cannot be null or empty.", nameof(zipPath));

        using ZipArchive archive = ZipFile.OpenRead(zipPath);

        // TODO - remove?
        List<string> zipEntriesToProcess = GetZipEntryNames(archive);
        ZipArchiveEntry encryptionKeySaltEntry = archive.GetEntry(Constants.EncryptionKeySaltFileName);
        ZipArchiveEntry macKeySaltEntry = archive.GetEntry(Constants.MacKeySaltFileName);
        ZipArchiveEntry macEntry = archive.GetEntry(Constants.MacFileName);

        // error checking
        if (encryptionKeySaltEntry == null ||
            macKeySaltEntry == null ||
            macEntry == null)
            throw new FileNotFoundException($"Archive does not contain the necessary files.");

        FileModel model = new(savePath);

        // TODO - refactor to adhere to the SRP
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

        List<string> output = Directory
            .GetDirectories(FileModelsDirectoryPath)
            .Select(Path.GetFileName)
            .ToList();

        return output;
    }

    private void InitializePaths(string fileName)
    {
        string extension = Path.GetExtension(fileName);
        fileName = (extension == Constants.AesExtension || extension == Constants.TripleDesExtension) ? Path.GetFileNameWithoutExtension(fileName) : fileName;
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
