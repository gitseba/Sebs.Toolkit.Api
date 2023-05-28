using Newtonsoft.Json;

namespace Sebs.Toolkit.Api.UnitTests.Models
{
    /// <summary>
    /// Purpose: 
    /// Created by: sebde
    /// Created at: 5/28/2023 9:24:01 PM
    /// </summary>
    public class OfficialJokeModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("setup")]
        public string? Setup { get; set; }

        [JsonProperty("punchline")]
        public string? PunchLine { get; set; }
    }
}
