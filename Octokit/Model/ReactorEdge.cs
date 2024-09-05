namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// Represents an author of a reaction.
    /// </summary>
    public class ReactorEdge : QueryableValue<ReactorEdge>
    {
        internal ReactorEdge(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The author of the reaction.
        /// </summary>
        public Reactor Node => this.CreateProperty(x => x.Node, Octokit.Model.Reactor.Create);

        /// <summary>
        /// The moment when the user made the reaction.
        /// </summary>
        public DateTimeOffset ReactedAt { get; }

        internal static ReactorEdge Create(Expression expression)
        {
            return new ReactorEdge(expression);
        }
    }
}