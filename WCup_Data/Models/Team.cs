using System.Text.Json.Serialization;
namespace WCup_Data.Models;

//probaby useless
    public class Team
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("goals")]
        public int Goals { get; set; }

        [JsonPropertyName("penalties")]
        public int Penalties { get; set; }
    }
