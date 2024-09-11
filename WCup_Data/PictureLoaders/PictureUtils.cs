using System.Drawing;
using static System.Net.Mime.MediaTypeNames;



namespace WCup_Data.PictureLoaders
{
    public static class PictureUtils
    {
        private static string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string folder = "wcup_dataf";


        public static void savePicture(string picPath, string name)
        {
            try
            {
                File.Copy(picPath, Path.Combine(appDataPath,folder, name), overwrite: true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static string? LoadPicture(string name)
        {
            try
            {
                string fullPath = Path.Combine(appDataPath,folder, name);
                return fullPath;
            }
            catch (Exception) {
                return null;
            }
        }

    }
}
