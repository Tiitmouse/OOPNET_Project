using System.Text.Json;
namespace WCup_Data.Settings;

public class Settings
{ 
    public char CupType{get; set; } // 'W' or 'M'
    public char DataFetchType{get; set; } // 'L' or 'G'
    public Language DisplayLanguage{get; set; }
    public enum Language
    {
        English, Croatian
    } 
    
    public static Settings? LoadSettings()
    {
        if (!File.Exists("settings.json"))
        {
            Settings defaultSettings = new Settings
            {
                CupType = 'W',
                DataFetchType = 'L',
                DisplayLanguage = Language.English
            };
            return defaultSettings;
        }
        try
        {
            string json = File.ReadAllText("settings.json");
            Settings settings = JsonSerializer.Deserialize<Settings>(json) 
                                ?? throw new InvalidOperationException();
            return settings;
        }
        catch (Exception ex)
        {
            //TODO handle exceptions
            return null;
        }
    }
    public bool SaveSettings()
    {
        try
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText("settings.json", json);
        }
        catch
        {
            return false;
        }
        return true;
    }
    
}