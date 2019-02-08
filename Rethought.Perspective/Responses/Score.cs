using Newtonsoft.Json;

namespace Rethought.Perspective.Responses
{
    public class Score
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}