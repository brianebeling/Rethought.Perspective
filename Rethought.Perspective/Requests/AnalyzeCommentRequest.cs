using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rethought.Perspective.Requests
{
    public class AnalyzeCommentRequest
    {
        [JsonProperty("comment")]
        public Comment Comment { get; set; }

        [JsonProperty("context")]
        public Context Context { get; set; }

        [JsonProperty("requestedAttributes")]
        public RequestedAttributes RequestedAttributes { get; set; }

        [JsonProperty("languages")]
        public IList<string> Languages { get; set; }

        [JsonProperty("doNotStore")]
        public bool DoNotStore { get; set; }

        [JsonProperty("clientToken")]
        public string ClientToken { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }
    }
}