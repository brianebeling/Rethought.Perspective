using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Rethought.Perspective.Ratelimit;
using Rethought.Perspective.Requests;

namespace Rethought.Perspective
{
    public class Requester : IAnalyzeCommentRequester
    {
        private readonly HttpClient httpClient;
        private readonly IRateLimitPolicy rateLimitPolicy;
        private HttpResponseMessage lastResponse;

        public Requester(HttpClient httpClient, IRateLimitPolicy rateLimitPolicy)
        {
            this.httpClient = httpClient;
            this.rateLimitPolicy = rateLimitPolicy;
        }

        public async Task<T> Request<T>(
            string request,
            AnalyzeCommentRequest analyzeCommentRequest,
            JsonSerializerSettings jsonSerializerSettings)
        {
            var requestAsJson = JsonConvert.SerializeObject(analyzeCommentRequest, jsonSerializerSettings);

            var response = await httpClient.PostAsync(
                request,
                new StringContent(requestAsJson, Encoding.UTF8, "application/json"));
            lastResponse = response;

            await rateLimitPolicy.ApplyRateLimitAsync(lastResponse.Headers);

            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync(), jsonSerializerSettings);
        }
    }
}