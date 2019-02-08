using Newtonsoft.Json;

namespace Rethought.Perspective.Requests
{
    public class RequestedAttributes
    {
        [JsonProperty("TOXICITY")]
        public RequestAttribute Toxicity { get; set; }

        [JsonProperty("SEVERE_TOXICITY")]
        public RequestAttribute SevereToxicity { get; set; }

        [JsonProperty("IDENTITY_ATTACK")]
        public RequestAttribute IdentityAttack { get; set; }

        [JsonProperty("INSULT")]
        public RequestAttribute Insult { get; set; }

        [JsonProperty("PROFANITY")]
        public RequestAttribute Profanity { get; set; }

        [JsonProperty("THREAT")]
        public RequestAttribute Threat { get; set; }

        [JsonProperty("SEXUALLY_EXPLICIT")]
        public RequestAttribute SexuallyExplicit { get; set; }

        [JsonProperty("FLIRTATION")]
        public RequestAttribute Flirtation { get; set; }

        [JsonProperty("ATTACK_ON_AUTHOR")]
        public RequestAttribute AttackOnAuthor { get; set; }

        [JsonProperty("ATTACK_ON_COMMENTER")]
        public RequestAttribute AttackOnCommenter { get; set; }

        [JsonProperty("INCOHERENT")]
        public RequestAttribute Incoherent { get; set; }

        [JsonProperty("INFLAMMATORY")]
        public RequestAttribute Inflammatory { get; set; }

        [JsonProperty("LIKELY_TO_REJECT")]
        public RequestAttribute LikelyToReject { get; set; }

        [JsonProperty("OBSCENE")]
        public RequestAttribute Obscene { get; set; }

        [JsonProperty("SPAM")]
        public RequestAttribute Spam { get; set; }

        [JsonProperty("UNSUBSTANTIAL")]
        public RequestAttribute Unsubstantial { get; set; }

        [JsonProperty("TOXICITY_FAST")]
        public RequestAttribute ToxicityFast { get; set; }
    }
}