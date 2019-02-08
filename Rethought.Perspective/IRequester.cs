using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Rethought.Perspective
{
    public interface IRequester
    {
        Task<T> Request<T>(string request, JsonSerializerSettings jsonSerializerSettings);
    }
}