using Newtonsoft.Json;

namespace Rethought.Perspective.Requests
{
    public class Comment
    {
        [JsonProperty("text", Required = Required.Always)]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}