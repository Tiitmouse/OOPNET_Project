using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text.Json;
using WCup_Data.Models;

namespace WCup_Data.Settings;

public class Settings
{
    public Settings(CupType cType, char dataFetchType, Language displayLanguage, string favrep, string res)
    {
        CType = cType;
        DataFetchType = dataFetchType;
        DisplayLanguage = displayLanguage;
        List<String> favouritePlayers;
        FavouriteRepresentation = favrep;
        resolution = res;
    }

    internal Settings()
    {
        
    }
    public CupType CType{get; set; } // 'W' or 'M'
    public char DataFetchType{get; set; } // 'L' or 'G'
    public Language DisplayLanguage{get; set; }
    public string resolution { get; set; }

    public string FavouriteRepresentation { get; set; }


    public List<String> favouritePlayers { get; set; } = new List<String>();

    public enum CupType
    {
        women , men
    }
    public enum Language
    {
        English, Croatian
    } 
    // TODO add resolution
    // TODO add fav players and team
    
}