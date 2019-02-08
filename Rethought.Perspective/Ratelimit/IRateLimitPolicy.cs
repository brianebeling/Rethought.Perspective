using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Rethought.Perspective.Ratelimit
{
    public interface IRateLimitPolicy
    {
        Task ApplyRateLimitAsync(HttpHeaders httpResponseHeaders);
    }
}