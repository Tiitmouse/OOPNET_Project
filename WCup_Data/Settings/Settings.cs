using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text.Json;
using WCup_Data.Models;

namespace WCup_Data.Settings;

public class Settings
{


    public  Settings()
    {
        
    }
    public CupType CType{get; set; } // 'W' or 'M'
    public char DataFetchType{get; set; } // 'L' or 'G'
    public Language DisplayLanguage{get; set; }
    public string Resolution { get; set; }

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
}