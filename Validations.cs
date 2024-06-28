using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zapper
{
    public class Validations
    {
        /// <summary>
        /// Check if the user settings given is valid.
        /// </summary>
        /// <param name="userSettings">The user settings string.</param>
        /// <returns>True if valid.</returns>
        /// <exception cref="ArgumentException">Invalid user settings.</exception>
        public static bool IsUserSettingsValid(string userSettings)
        {
            if (string.IsNullOrWhiteSpace(userSettings) || userSettings.Length != 8 || userSettings.Any(char.IsLetter) || !Regex.IsMatch(userSettings, "^[01]*$"))
            {
                throw new ArgumentException("Invalid user settings.");
            }
            
            return true;
        }
    }
}
