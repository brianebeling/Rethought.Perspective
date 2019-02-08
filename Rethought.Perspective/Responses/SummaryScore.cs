using Newtonsoft.Json;

namespace Rethought.Perspective.Responses
{
    public class SummaryScore
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}