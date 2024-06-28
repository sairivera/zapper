using Zapper;
using Zapper.Enumerations;


// Valid Test Cases
try
{
    
    Console.WriteLine("VALID TEST CASES \n");

    Console.WriteLine("settings = 00000000, setting = 7");
    if (Validations.IsUserSettingsValid("00000000"))
    {
        Console.WriteLine("Output = {0}", Features.IsEnabled("00000000", Settings.Vouchers).ToString());
    }

    Console.WriteLine("settings = 00000010, setting = 7");
    if (Validations.IsUserSettingsValid("00000010"))
    {
        Console.WriteLine("Output = {0}", Features.IsEnabled("00000010", Settings.Vouchers).ToString());
    }

    Console.WriteLine("settings = 11111111, setting = 4");
    if (Validations.IsUserSettingsValid("11111111"))
    {
        Console.WriteLine("Output = {0}", Features.IsEnabled("11111111", Settings.Camera).ToString());
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("\nINVALID TEST CASE \n");

// INVALID TEST CASE
try
{
    // User settings is empty
    Console.WriteLine("settings = , setting = 6");
    if (Validations.IsUserSettingsValid(""))
    {
        Console.WriteLine("Output = {0}", Features.IsEnabled("", Settings.NFC).ToString());
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    // User settings contains a letter.
    Console.WriteLine("settings = 1111111A, setting = 8");
    if (Validations.IsUserSettingsValid("1111111A"))
    {
        Console.WriteLine("Output = {0}", Features.IsEnabled("1111111A", Settings.Loyalty).ToString());
    }
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

try
{
    // User settings length is not 8.
    Console.WriteLine("settings = 000000, setting = 6");
    if (Validations.IsUserSettingsValid("000000"))
    {
        Console.WriteLine("Output = {0}", Features.IsEnabled("000000", Settings.NFC).ToString());
    }

    // User settings contains other number than 0 or 1.
    Console.WriteLine("settings = 11111113, setting = 8");
    if (Validations.IsUserSettingsValid("11111113"))
    {
        Console.WriteLine("Output = {0}", Features.IsEnabled("11111113", Settings.Loyalty).ToString());
    }
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

try
{
    // User settings contains other number than 0 or 1.
    Console.WriteLine("settings = 11111113, setting = 8");
    if (Validations.IsUserSettingsValid("11111113"))
    {
        Console.WriteLine("Output = {0}", Features.IsEnabled("11111113", Settings.Loyalty).ToString());
    }
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

// SAVING AND RETRIEVING USER SETTINGS

try
{
    Console.WriteLine("\nUSER SETTINGS FILE\n");
    Console.WriteLine("Writing to file...");
    FileUtilities.WriteSettingsToFile("11111111");
    FileUtilities.WriteSettingsToFile("00000010");
    Console.WriteLine("Write to file successful!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    Console.WriteLine("\nReading From file...");
    Console.WriteLine("File contents: \n{0}", FileUtilities.ReadSettingsFromFile());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




