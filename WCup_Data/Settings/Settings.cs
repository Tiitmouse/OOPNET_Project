using System.Text.Json;
namespace WCup_Data.Settings;

public class Settings
{
    public Settings(CupType cType, char dataFetchType, Language displayLanguage)
    {
        CType = cType;
        DataFetchType = dataFetchType;
        DisplayLanguage = displayLanguage;
    }

    internal Settings()
    {
        
    }
    public CupType CType{get; set; } // 'W' or 'M'
    public char DataFetchType{get; set; } // 'L' or 'G'
    public Language DisplayLanguage{get; set; }

    public enum CupType
    {
        women , men
    }
    public enum Language
    {
        English, Croatian
    } 
    // TODO add resolution
    
}