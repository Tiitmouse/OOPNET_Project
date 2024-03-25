using System.Text.Json.Serialization;
using WCup_Data.ModelHelpers;
using WCup_Data.Models.Enums;

namespace WCup_Data.Models;

public class Player
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("captain")]
    public bool Captain { get; set; }

    [JsonPropertyName("shirt_number")]
    public int ShirtNumber { get; set; }

    [JsonPropertyName("position")]
    [JsonConverter(typeof(PositionConverter))]
    public Position Position { get; set; }
}