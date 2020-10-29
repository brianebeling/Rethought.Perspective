using System;
using System.Net.Http;
using System.Threading.Tasks;
using Rethought.Perspective.Responses;

namespace Rethought.Perspective.Example
{
    internal static class Program
    {
        private static async Task Main()
        {
            var client = PerspectiveClientFactory.Create(new HttpClient(), "YourToken");
            
            var response = await client.AnalyzeCommentAsync("This is stupid!", builder => builder.WithModel(Model.Toxicity | Model.ToxicitySevere));
            
            PrintExample(response);
        }

        private static void PrintExample(AnalyzeCommentResponse analyzeCommentResponse)
        {
            var attributeScores = analyzeCommentResponse.AttributeScores;
            Console.WriteLine(attributeScores.ToString());
        }
    }
}