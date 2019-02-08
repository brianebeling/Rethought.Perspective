using System;

namespace Rethought.Perspective
{
    [Flags]
    public enum Model
    {
        None = 0,
        Toxicity = 1,
        ToxicitySevere = 2,
        ToxicityFast = 4,
        Profanity = 8,
        IdentityAttack = 16,
        Insult = 32,
        Threat = 64,
        SexuallyExplicit = 128,
        Flirtation = 256,
        Inflammatory = 512,
        Obscene = 1024,
        Spam = 2048,
        Unsubstantial = 4096,
        AttackOnAuthor = 8192,
        AttackOnCommenter = 16384,
        Incoherent = 32768,
        LikelyToReject = 65536
    }
}