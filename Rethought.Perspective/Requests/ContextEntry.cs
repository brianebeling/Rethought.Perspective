using Newtonsoft.Json;

namespace Rethought.Perspective.Requests
{
    public class ContextEntry
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}