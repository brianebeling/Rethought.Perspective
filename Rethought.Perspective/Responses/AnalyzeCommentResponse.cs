using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rethought.Perspective.Responses
{
    public class AnalyzeCommentResponse
    {
        [JsonProperty("attributeScores")]
        public AttributeScores AttributeScores { get; set; }

        [JsonProperty("languages")]
        public IList<string> Languages { get; set; }

        [JsonProperty("clientToken")]
        public string ClientToken { get; set; }
    }
}