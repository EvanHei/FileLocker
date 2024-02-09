using FileLockerLibrary;
using System.Text;

namespace WinFormsUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // TESTING =====================================================

            // ADD A NEW FILE (saved to C:\Users\Evan\AppData\Roaming\FileLocker) - - - - - - - - - - - - - - -
            string path = @"C:\Users\Evan\Desktop\test.txt";
            File.WriteAllText(path, "Hello, World!");

            FileModel model = new FileModel();
            model.Path = path;
            model.Content = File.ReadAllBytes(model.Path);
            model.Password = "password";
            model.EncryptionKeySalt = GlobalConfig.KeyDeriver.GenerateSalt();
            model.EncryptionKey = GlobalConfig.KeyDeriver.DeriveKey(model.Password, model.EncryptionKeySalt);
            model.EncryptionStatus = false;

            try
            {
                GlobalConfig.DataAccessor.SaveFileModel(model);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // GET ALL FILES - - - - - - - - - - - - - - -
            List<FileModel> models = GlobalConfig.DataAccessor.LoadAllFileModels();

            // =============================================================

            ApplicationConfiguration.Initialize();
            Application.Run(new DashboardForm());
        }
    }
}