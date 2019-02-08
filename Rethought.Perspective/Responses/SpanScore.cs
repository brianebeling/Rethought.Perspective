using Newtonsoft.Json;

namespace Rethought.Perspective.Responses
{
    public class SpanScore
    {
        [JsonProperty("begin")]
        public int Begin { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("score")]
        public Score Score { get; set; }
    }
}