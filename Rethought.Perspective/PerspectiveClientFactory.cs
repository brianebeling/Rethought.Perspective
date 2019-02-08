using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Rethought.Perspective.Ratelimit;

namespace Rethought.Perspective
{
    public static class PerspectiveClientFactory
    {
        public static PerspectiveClient Create(HttpClient httpClient, string token)
        {
            return PerspectiveClient.Create(
                new Requester(httpClient, new RateLimitPolicy()),
                new RequestUrlBuilder(
                    EndPoints.BaseUrl,
                    new List<IParameter>
                    {
                        new Parameter("key", token)
                    }),
                new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore});
        }
    }
}