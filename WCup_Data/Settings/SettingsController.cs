using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.Json;

namespace WCup_Data.Settings;

public static class SettingsController
{
    private static Settings _settingsValue = null;
    /// <summary>
    /// Is true if no settings file is found and default settings are used.
    /// </summary>
    public static bool IsDefault = false;
    private static string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    private static string fileName = "settings.json";
    private static string folderName = "wcup_dataf";

    private static Settings LoadSettings()
    {
        try
        {
            CheckDir();
            string json = File.ReadAllText(Path.Combine(appDataPath, folderName, fileName));
            Settings settings = JsonSerializer.Deserialize<Settings>(json) 
                                ?? throw new InvalidOperationException();
            return settings;
        }
        catch (Exception)
        {
            Settings defaultSettings = new Settings
            {
                CType = Settings.CupType.women,
                DataFetchType = 'G',
                DisplayLanguage = Settings.Language.English
            };
            IsDefault = true;
            return defaultSettings;
        }
    }

        public static Settings GetSettings()
    {
        if (_settingsValue == null)
        {
            _settingsValue = LoadSettings();
        }
        return _settingsValue;
    }

    private static void CheckDir()
    {
        if (!Directory.Exists(Path.Combine(appDataPath, folderName)))
        {
            Directory.CreateDirectory(Path.Combine(appDataPath, folderName));
        }
    } 
    
    public static bool SaveSettings()
    {
        try
        {
            CheckDir();
            string json = JsonSerializer.Serialize(_settingsValue);
            File.WriteAllText(Path.Combine(appDataPath,folderName, fileName), json);
        }
        catch
        {
            return false;
        }
        return true;
    }

}