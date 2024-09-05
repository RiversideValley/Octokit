namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// A suggestion to review a pull request based on a user's commit history and review comments.
    /// </summary>
    public class SuggestedReviewer : QueryableValue<SuggestedReviewer>
    {
        internal SuggestedReviewer(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// Is this suggestion based on past commits?
        /// </summary>
        public bool IsAuthor { get; }

        /// <summary>
        /// Is this suggestion based on past review comments?
        /// </summary>
        public bool IsCommenter { get; }

        /// <summary>
        /// Identifies the user suggested to review the pull request.
        /// </summary>
        public User Reviewer => this.CreateProperty(x => x.Reviewer, Octokit.Model.User.Create);

        internal static SuggestedReviewer Create(Expression expression)
        {
            return new SuggestedReviewer(expression);
        }
    }
}