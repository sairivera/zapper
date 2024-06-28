using Zapper.Enumerations;

namespace Zapper
{
    public class Features
    {
        /// <summary>
        /// Checks if the feature is enabled for the user.
        /// </summary>
        public static bool IsEnabled(string userSettings, Settings setting)
        {
            return userSettings[(int)setting - 1] == '1';  
        }
    }
}
