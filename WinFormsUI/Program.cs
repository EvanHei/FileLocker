using FileLockerLibrary;
using System.Text;

namespace WinFormsUI;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // TESTING =====================================================



        //// CREATE A FILE
        //string path = @"C:\Users\Evan\Desktop\test.txt";
        //if (!File.Exists(path))
        //    File.WriteAllText(path, "Hello, World!");



        //// ADD A NEW FILEMODEL (saved to C:\Users\Evan\AppData\Roaming\FileLocker) - - - - - - - - - - - - - - -
        //FileModel model = new FileModel(path);

        //try
        //{
        //    GlobalConfig.DataAccessor.CreateFileModel(model);
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show(ex.Message);
        //}




        //// GET ALL FILEMODELS - - - - - - - - - - - - - - -
        //List<FileModel> models = GlobalConfig.DataAccessor.LoadAllFileModels();
        //model = models.Where(model => model.Path == @"C:\Users\Evan\Desktop\test.txt" || model.Path == @"C:\Users\Evan\Desktop\test.txt.ciphertext").First();




        //// ENCRYPT - - - - - - - - - - - - - - -
        //model.Password = "password";
        //model.EncryptionKey = GlobalConfig.KeyDeriver.DeriveKey(model.Password, model.EncryptionKeySalt);
        //model.Encrypt();
        //GlobalConfig.DataAccessor.SaveFileModel(model);




        //// DECRYPT - - - - - - - - - - - - - - -
        //model.Password = "password";
        //model.EncryptionKey = GlobalConfig.KeyDeriver.DeriveKey(model.Password, model.EncryptionKeySalt);
        //model.Decrypt();
        //GlobalConfig.DataAccessor.SaveFileModel(model);



        //// DELETE FILEMODEL - - - - - - - - - - - - - - -
        //try
        //{
        //    GlobalConfig.DataAccessor.DeleteFileModel(model);
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show(ex.Message);
        //}



        // =============================================================

        ApplicationConfiguration.Initialize();
        Application.Run(new DashboardForm());
    }
}