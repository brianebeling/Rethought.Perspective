using Newtonsoft.Json;

namespace Rethought.Perspective.Responses
{
    public class AttributeScores
    {
        [JsonProperty("TOXICITY")]
        public AttributeScore Toxicity { get; set; }

        [JsonProperty("SEVERE_TOXICITY")]
        public AttributeScore SevereToxicity { get; set; }

        [JsonProperty("IDENTITY_ATTACK")]
        public AttributeScore IdentityAttack { get; set; }

        [JsonProperty("INSULT")]
        public AttributeScore Insult { get; set; }

        [JsonProperty("PROFANITY")]
        public AttributeScore Profanity { get; set; }

        [JsonProperty("THREAT")]
        public AttributeScore Threat { get; set; }

        [JsonProperty("SEXUALLY_EXPLICIT")]
        public AttributeScore SexuallyExplicit { get; set; }

        [JsonProperty("FLIRTATION")]
        public AttributeScore Flirtation { get; set; }

        [JsonProperty("ATTACK_ON_AUTHOR")]
        public AttributeScore AttackOnAuthor { get; set; }

        [JsonProperty("ATTACK_ON_COMMENTER")]
        public AttributeScore AttackOnCommenter { get; set; }

        [JsonProperty("INCOHERENT")]
        public AttributeScore Incoherent { get; set; }

        [JsonProperty("INFLAMMATORY")]
        public AttributeScore Inflammatory { get; set; }

        [JsonProperty("LIKELY_TO_REJECT")]
        public AttributeScore LikelyToReject { get; set; }

        [JsonProperty("OBSCENE")]
        public AttributeScore Obscene { get; set; }

        [JsonProperty("SPAM")]
        public AttributeScore Spam { get; set; }

        [JsonProperty("UNSUBSTANTIAL")]
        public AttributeScore Unsubstantial { get; set; }
    }
}