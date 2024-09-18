namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of RemoveReaction
    /// </summary>
    public class RemoveReactionPayload : QueryableValue<RemoveReactionPayload>
    {
        internal RemoveReactionPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The reaction object.
        /// </summary>
        public Reaction Reaction => this.CreateProperty(x => x.Reaction, Octokit.GraphQL.Model.Reaction.Create);

        /// <summary>
        /// The reaction groups for the subject.
        /// </summary>
        public IQueryableList<ReactionGroup> ReactionGroups => this.CreateProperty(x => x.ReactionGroups);

        /// <summary>
        /// The reactable subject.
        /// </summary>
        public IReactable Subject => this.CreateProperty(x => x.Subject, Octokit.GraphQL.Model.Internal.StubIReactable.Create);

        internal static RemoveReactionPayload Create(Expression expression)
        {
            return new RemoveReactionPayload(expression);
        }
    }
}