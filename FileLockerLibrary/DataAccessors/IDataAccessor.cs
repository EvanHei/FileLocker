using System.Collections.Generic;

namespace FileLockerLibrary;

public interface IDataAccessor
{
    void CreateFileModel(FileModel model);
    void SaveFileModel(FileModel model);
    void DeleteFileModel(FileModel model);
    void ShredFile(string path);
    List<FileModel> LoadAllFileModels();
    void ExportZipFileModel(FileModel model, string zipPath);
    void ImportZipFileModel(string zipPath, string savePath);
}
