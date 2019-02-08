using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rethought.Perspective.Responses
{
    public class AttributeScore
    {
        [JsonProperty("summaryScore")]
        public SummaryScore SummaryScore { get; set; }

        [JsonProperty("spanScores")]
        public IList<SpanScore> SpanScores { get; set; }
    }
}