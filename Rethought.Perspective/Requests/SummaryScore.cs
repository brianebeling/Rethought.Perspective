using Newtonsoft.Json;

namespace Rethought.Perspective.Requests
{
    public struct SummaryScore
    {
        [JsonProperty("value")]
        public double Value { get; private set; }

        [JsonProperty("type")]
        public Type Type { get; private set; }
    }
}