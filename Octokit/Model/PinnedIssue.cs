namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// A Pinned Issue is a issue pinned to a repository's index page.
    /// </summary>
    public class PinnedIssue : QueryableValue<PinnedIssue>
    {
        internal PinnedIssue(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// Identifies the primary key from the database.
        /// </summary>
        public long? DatabaseId { get; }

        /// <summary>
        /// Identifies the primary key from the database as a BigInt.
        /// </summary>
        public string FullDatabaseId { get; }

        /// <summary>
        /// The Node ID of the PinnedIssue object
        /// </summary>
        public ID Id { get; }

        /// <summary>
        /// The issue that was pinned.
        /// </summary>
        public Issue Issue => this.CreateProperty(x => x.Issue, Octokit.Model.Issue.Create);

        /// <summary>
        /// The actor that pinned this issue.
        /// </summary>
        public IActor PinnedBy => this.CreateProperty(x => x.PinnedBy, Octokit.Model.Internal.StubIActor.Create);

        /// <summary>
        /// The repository that this issue was pinned to.
        /// </summary>
        public Repository Repository => this.CreateProperty(x => x.Repository, Octokit.Model.Repository.Create);

        internal static PinnedIssue Create(Expression expression)
        {
            return new PinnedIssue(expression);
        }
    }
}