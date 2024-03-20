using System.Collections.Generic;
using System.Reflection;

namespace FileLockerLibrary;

public interface IDataAccessor
{
    void CreateFileModel(FileModel model);
    void SaveFileModel(FileModel model);
    void DeleteFileModel(FileModel model);
    void RelocateFile(FileModel model, string newPath);
    List<FileModel> LoadAllFileModels();
    void ExportZipFileModel(FileModel model, string zipPath);
    void ImportZipFileModel(string zipPath, string savePath);
}
