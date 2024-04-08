using System.Text.Json.Serialization;
using QuickType;

namespace WCup_Data.Models;

public class Group
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("letter")]
    public string Letter { get; set; }

    [JsonPropertyName("ordered_teams")]
    public List<Result> OrderedTeams { get; set; }
}