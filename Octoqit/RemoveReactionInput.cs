namespace Octoqit
{
    using System.Linq;

    /// <summary>
    /// Autogenerated input type of RemoveReaction
    /// </summary>
    public class RemoveReactionInput
    {
        public string ClientMutationId { get; set; }

        public string SubjectId { get; set; }

        public ReactionContent Content { get; set; }
    }
}