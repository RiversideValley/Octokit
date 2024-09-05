namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// An edge in a connection.
    /// </summary>
    public class RepositoryTopicEdge : QueryableValue<RepositoryTopicEdge>
    {
        internal RepositoryTopicEdge(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public RepositoryTopic Node => this.CreateProperty(x => x.Node, Octokit.Model.RepositoryTopic.Create);

        internal static RepositoryTopicEdge Create(Expression expression)
        {
            return new RepositoryTopicEdge(expression);
        }
    }
}