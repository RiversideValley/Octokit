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
    public class PinnedIssueEdge : QueryableValue<PinnedIssueEdge>
    {
        internal PinnedIssueEdge(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public PinnedIssue Node => this.CreateProperty(x => x.Node, Octokit.Model.PinnedIssue.Create);

        internal static PinnedIssueEdge Create(Expression expression)
        {
            return new PinnedIssueEdge(expression);
        }
    }
}