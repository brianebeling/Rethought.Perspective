using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rethought.Perspective.Requests
{
    public class Context
    {
        [JsonProperty("entries")]
        public IList<ContextEntry> Entries { get; set; }
    }
}