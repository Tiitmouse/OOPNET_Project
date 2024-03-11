using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using WCup_Data.ModelHelpers;
using WCup_Data.Models.Enums;

namespace WCup_Data.Models
{
    public class Match
    {
        [JsonPropertyName("venue")]
        public string Venue { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("status")]
        public Status Status { get; set; }

        [JsonPropertyName("time")]
        public Time Time { get; set; }

        [JsonPropertyName("fifa_id")]
        [JsonConverter(typeof(IntConverter))]
        public int FifaId { get; set; }

        [JsonPropertyName("weather")]
        public Weather Weather { get; set; }

        [JsonPropertyName("attendance")]
        [JsonConverter(typeof(IntConverter))]
        public int Attendance { get; set; }

        [JsonPropertyName("officials")]
        public string[] Officials { get; set; }

        [JsonPropertyName("stage_name")]
        public StageName StageName { get; set; }

        [JsonPropertyName("home_team_country")]
        public string HomeTeamCountry { get; set; }

        [JsonPropertyName("away_team_country")]
        public string AwayTeamCountry { get; set; }

        [JsonPropertyName("datetime")]
        public DateTimeOffset Datetime { get; set; }

        [JsonPropertyName("winner")]
        public string Winner { get; set; }

        [JsonPropertyName("winner_code")]
        public string WinnerCode { get; set; }

        [JsonPropertyName("home_team")]
        public Team HomeTeam { get; set; }

        [JsonPropertyName("away_team")]
        public Team AwayTeam { get; set; }

        [JsonPropertyName("home_team_events")]
        public TeamEvent[] HomeTeamEvents { get; set; }

        [JsonPropertyName("away_team_events")]
        public TeamEvent[] AwayTeamEvents { get; set; }

        [JsonPropertyName("home_team_statistics")]
        public TeamStatistics HomeTeamStatistics { get; set; }

        [JsonPropertyName("away_team_statistics")]
        public TeamStatistics AwayTeamStatistics { get; set; }

        [JsonPropertyName("last_event_update_at")]
        public DateTimeOffset LastEventUpdateAt { get; set; }

        [JsonPropertyName("last_score_update_at")]
        public DateTimeOffset? LastScoreUpdateAt { get; set; }
    }

}
