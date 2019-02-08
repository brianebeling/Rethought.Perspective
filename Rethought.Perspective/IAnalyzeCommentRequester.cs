using System.Threading.Tasks;
using Newtonsoft.Json;
using Rethought.Perspective.Requests;

namespace Rethought.Perspective
{
    public interface IAnalyzeCommentRequester
    {
        Task<T> Request<T>(
            string request,
            AnalyzeCommentRequest analyzeCommentRequest,
            JsonSerializerSettings jsonSerializerSettings);
    }
}