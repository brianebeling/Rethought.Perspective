using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Rethought.Perspective.Ratelimit
{
    public class RateLimitPolicy : IRateLimitPolicy
    {
        public async Task ApplyRateLimitAsync(HttpHeaders httpResponseHeaders)
        {
            if (httpResponseHeaders.TryGetValues("X-RateLimit-Remaining", out var rateLimitRemaining) &&
                int.Parse(rateLimitRemaining.First()) <= 1)
                if (httpResponseHeaders.TryGetValues("X-RateLimit-Limit", out var rateLimitReset))
                    await Task.Delay(TimeSpan.FromSeconds(60 / double.Parse(rateLimitReset.FirstOrDefault())));
        }
    }
}