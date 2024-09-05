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
    public class PullRequestReviewEdge : QueryableValue<PullRequestReviewEdge>
    {
        internal PullRequestReviewEdge(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public PullRequestReview Node => this.CreateProperty(x => x.Node, Octokit.Model.PullRequestReview.Create);

        internal static PullRequestReviewEdge Create(Expression expression)
        {
            return new PullRequestReviewEdge(expression);
        }
    }
}