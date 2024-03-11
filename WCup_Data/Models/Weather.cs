using System.Text.Json.Serialization;
using WCup_Data.ModelHelpers;
using WCup_Data.Models.Enums;

namespace WCup_Data.Models;

public class Weather
{
    [JsonPropertyName("humidity")]
    [JsonConverter(typeof(IntConverter))]
    public int Humidity { get; set; }

    [JsonPropertyName("temp_celsius")]
    [JsonConverter(typeof(IntConverter))]
    public int TempCelsius { get; set; }

    [JsonPropertyName("temp_farenheit")]
    [JsonConverter(typeof(IntConverter))]
    public int TempFarenheit { get; set; }

    [JsonPropertyName("wind_speed")]
    [JsonConverter(typeof(IntConverter))]
    public int WindSpeed { get; set; }

    [JsonPropertyName("description")]
    public WeatherDescription WeatherDescription { get; set; }
}