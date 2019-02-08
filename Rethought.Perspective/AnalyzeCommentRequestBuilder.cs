using System.Collections.Generic;
using Rethought.Perspective.Requests;

namespace Rethought.Perspective
{
    public class AnalyzeCommentRequestBuilder
    {
        private Model model;

        public AnalyzeCommentRequestBuilder WithModel(Model model)
        {
            this.model = model;
            return this;
        }

        // TODO Add support for future concepts, like context

        public AnalyzeCommentRequest Build(string comment)
        {
            var analyzeCommentRequest = new AnalyzeCommentRequest
            {
                Comment = new Comment {Text = comment}, RequestedAttributes = new RequestedAttributes()
            };

            var requestAttribute = new RequestAttribute();

            // TODO think about something to clean this up..
            if (model.HasFlag(Model.Toxicity)) analyzeCommentRequest.RequestedAttributes.Toxicity = requestAttribute;
            if (model.HasFlag(Model.ToxicitySevere))
                analyzeCommentRequest.RequestedAttributes.SevereToxicity = requestAttribute;
            if (model.HasFlag(Model.ToxicityFast))
                analyzeCommentRequest.RequestedAttributes.ToxicityFast = requestAttribute;
            if (model.HasFlag(Model.Profanity)) analyzeCommentRequest.RequestedAttributes.Profanity = requestAttribute;
            if (model.HasFlag(Model.IdentityAttack))
                analyzeCommentRequest.RequestedAttributes.IdentityAttack = requestAttribute;
            if (model.HasFlag(Model.Insult)) analyzeCommentRequest.RequestedAttributes.Insult = requestAttribute;
            if (model.HasFlag(Model.Threat)) analyzeCommentRequest.RequestedAttributes.Threat = requestAttribute;
            if (model.HasFlag(Model.SexuallyExplicit))
                analyzeCommentRequest.RequestedAttributes.SexuallyExplicit = requestAttribute;
            if (model.HasFlag(Model.Flirtation))
                analyzeCommentRequest.RequestedAttributes.Flirtation = requestAttribute;
            if (model.HasFlag(Model.Inflammatory))
                analyzeCommentRequest.RequestedAttributes.Inflammatory = requestAttribute;
            if (model.HasFlag(Model.Obscene)) analyzeCommentRequest.RequestedAttributes.Obscene = requestAttribute;
            if (model.HasFlag(Model.Spam)) analyzeCommentRequest.RequestedAttributes.Spam = requestAttribute;
            if (model.HasFlag(Model.Unsubstantial))
                analyzeCommentRequest.RequestedAttributes.Unsubstantial = requestAttribute;
            if (model.HasFlag(Model.AttackOnAuthor))
                analyzeCommentRequest.RequestedAttributes.AttackOnAuthor = requestAttribute;
            if (model.HasFlag(Model.AttackOnCommenter))
                analyzeCommentRequest.RequestedAttributes.AttackOnCommenter = requestAttribute;
            if (model.HasFlag(Model.Incoherent))
                analyzeCommentRequest.RequestedAttributes.Incoherent = requestAttribute;
            if (model.HasFlag(Model.LikelyToReject))
                analyzeCommentRequest.RequestedAttributes.LikelyToReject = requestAttribute;


            analyzeCommentRequest.Languages = new List<string> {"en"};

            return analyzeCommentRequest;
        }
    }
}