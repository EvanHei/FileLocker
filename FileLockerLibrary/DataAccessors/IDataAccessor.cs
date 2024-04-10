using System.Collections.Generic;
using System.Reflection;

namespace FileLockerLibrary;

/// <summary>
/// Interface for accessing file-related data and operations.
/// </summary>
public interface IDataAccessor
{
    /// <summary>
    /// Creates a new file model.
    /// </summary>
    /// <param name="model">The file model to create.</param>
    void CreateFileModel(FileModel model);

    /// <summary>
    /// Saves changes to an existing file model.
    /// </summary>
    /// <param name="model">The file model to save.</param>
    void SaveFileModel(FileModel model);

    /// <summary>
    /// Deletes a file model.
    /// </summary>
    /// <param name="model">The file model to delete.</param>
    void DeleteFileModel(FileModel model);

    /// <summary>
    /// Relocates a file to a new path.
    /// </summary>
    /// <param name="model">The file model to relocate.</param>
    /// <param name="newPath">The new path for the file.</param>
    void RelocateFile(FileModel model, string newPath);

    /// <summary>
    /// Loads all file models.
    /// </summary>
    /// <returns>A list of all file models.</returns>
    List<FileModel> LoadAllFileModels();

    /// <summary>
    /// Exports a file model to a ZIP archive.
    /// </summary>
    /// <param name="model">The file model to export.</param>
    /// <param name="zipPath">The path for the ZIP archive.</param>
    void ExportZipFileModel(FileModel model, string zipPath);

    /// <summary>
    /// Imports a file model from a ZIP archive.
    /// </summary>
    /// <param name="zipPath">The path of the ZIP archive.</param>
    /// <param name="savePath">The path to save the imported file model.</param>
    void ImportZipFileModel(string zipPath, string savePath);

    void CreateKeyPairModel(KeyPairModel model, string password);

    void DeleteKeyPairModel(KeyPairModel model);

    List<KeyPairModel> LoadAllPrivateKeyPairModels();

    List<KeyPairModel> LoadAllPublicKeyPairModels();

    void ExportZipKeyPairModel(KeyPairModel model, string zipPath);

    void ImportZipKeyPairModel(string zipPath);
}
