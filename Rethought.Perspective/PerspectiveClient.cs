using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Rethought.Perspective.Responses;

namespace Rethought.Perspective
{
    public class PerspectiveClient
    {
        private readonly IAnalyzeCommentRequester analyzeCommentRequester;
        private readonly JsonSerializerSettings jsonSerializerSettings;
        private readonly IRequestUrlBuilder requestUrlBuilder;

        internal PerspectiveClient(
            IAnalyzeCommentRequester analyzeCommentRequester,
            IRequestUrlBuilder requestUrlBuilder,
            JsonSerializerSettings jsonSerializerSettings)
        {
            this.analyzeCommentRequester = analyzeCommentRequester;
            this.requestUrlBuilder = requestUrlBuilder;
            this.jsonSerializerSettings = jsonSerializerSettings;
        }

        public Task<AnalyzeCommentResponse> AnalyzeCommentAsync(
            string comment,
            Action<AnalyzeCommentRequestBuilder> configuration)
        {
            var commentBuilder = new AnalyzeCommentRequestBuilder();
            configuration.Invoke(commentBuilder);

            commentBuilder.Build(comment);

            return analyzeCommentRequester.Request<AnalyzeCommentResponse>(
                requestUrlBuilder.Build(EndPoints.Analyze, new List<IParameter>()),
                commentBuilder.Build(comment),
                jsonSerializerSettings);
        }

        public static PerspectiveClient Create(
            IAnalyzeCommentRequester analyzeCommentRequester,
            IRequestUrlBuilder requestUrlBuilder,
            JsonSerializerSettings jsonSerializerSettings)
        {
            return new PerspectiveClient(analyzeCommentRequester, requestUrlBuilder, jsonSerializerSettings);
        }
    }
}