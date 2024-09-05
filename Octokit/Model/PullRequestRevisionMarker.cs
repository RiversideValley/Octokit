namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// Represents the latest point in the pull request timeline for which the viewer has seen the pull request's commits.
    /// </summary>
    public class PullRequestRevisionMarker : QueryableValue<PullRequestRevisionMarker>
    {
        internal PullRequestRevisionMarker(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public DateTimeOffset CreatedAt { get; }

        /// <summary>
        /// The last commit the viewer has seen.
        /// </summary>
        public Commit LastSeenCommit => this.CreateProperty(x => x.LastSeenCommit, Octokit.Model.Commit.Create);

        /// <summary>
        /// The pull request to which the marker belongs.
        /// </summary>
        public PullRequest PullRequest => this.CreateProperty(x => x.PullRequest, Octokit.Model.PullRequest.Create);

        internal static PullRequestRevisionMarker Create(Expression expression)
        {
            return new PullRequestRevisionMarker(expression);
        }
    }
}