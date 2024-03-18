using System.Text.Json;
namespace WCup_Data.Settings;

public class Settings
{ 
    public char CupType{get; set; } // 'W' or 'M'
    public char DataFetchType{get; set; } // 'W' or 'M'
    public Languages Language{get; set; }
    public enum Languages
    {
        English, Croatian
    } 
    
    public Settings? LoadSettings()
    {
        if (!File.Exists("settings.json"))
        {
            return null;
        }
        try
        {
            string json = File.ReadAllText("settings.json");
            Settings settings = JsonSerializer.Deserialize<Settings>(json) ?? throw new InvalidOperationException();
            return settings;
        }
        catch
        {
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