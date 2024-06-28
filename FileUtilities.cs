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
            StringBuilder fileDetails = new();

            try
            {
                using StreamReader sr = new(_fileName);
                string line = sr.ReadLine();

                while(line != null)
                {
                    fileDetails.AppendLine(line);
                    line = sr.ReadLine();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return fileDetails.ToString();
        }

        /// <summary>
        /// Write settings to file.
        /// </summary>
        /// <param name="settings">User settings.</param>
        public static void WriteSettingsToFile(string settings)
        {
            try
            {
                FileStream fileStream = new(_fileName, FileMode.Append, FileAccess.Write);
                using StreamWriter writer = new(fileStream);
                writer.WriteLine(settings);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
