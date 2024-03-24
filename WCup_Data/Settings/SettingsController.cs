using System.Text.Json;

namespace WCup_Data.Settings;

public static class SettingsController
{
    private static Settings _settingsValue = null;
    public static bool IsDefault = false;
    
    private static Settings LoadSettings()
    {
        try
        {
            string json = File.ReadAllText("settings.json");
            Settings settings = JsonSerializer.Deserialize<Settings>(json) 
                                ?? throw new InvalidOperationException();
            return settings;
        }
        catch (Exception)
        {
            Settings defaultSettings = new Settings
            {
                CType = Settings.CupType.women,
                DataFetchType = 'L',
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
    
    public static bool SaveSettings()
    {
        try
        {
            string json = JsonSerializer.Serialize(_settingsValue);
            File.WriteAllText("settings.json", json);
        }
        catch
        {
            return false;
        }
        return true;
    }

}