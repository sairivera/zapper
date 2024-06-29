using System.Text;

namespace Zapper
{
    public class FileUtilities
    {
        private const string _fileName = "UserSettings.txt";

        /// <summary>
        /// Read from file.
        /// </summary>
        /// <returns>File content.</returns>
        public static string ReadSettingsFromFile()
        {
            try
            {
                byte[] userSettingsSaved = File.ReadAllBytes(_fileName);
                string userSettings = Encoding.UTF8.GetString(userSettingsSaved);

                return userSettings;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Write settings to file.
        /// </summary>
        /// <param name="settings">User settings.</param>
        public static void WriteSettingsToFile(string settings)
        {
            try
            {
                using BinaryWriter writer = new(File.Open(_fileName, FileMode.Append));
                writer.Write(settings);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
