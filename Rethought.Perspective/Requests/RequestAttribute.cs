using Newtonsoft.Json;

namespace Rethought.Perspective.Requests
{
    public class RequestAttribute
    {
        [JsonProperty("scoreType")]
        public string ScoreType { get; set; }

        [JsonProperty("scoreThreshold")]
        public double? ScoreThreshold { get; set; }
    }
}