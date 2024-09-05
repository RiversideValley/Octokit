namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// A Dependabot Update for a dependency in a repository
    /// </summary>
    public class DependabotUpdate : QueryableValue<DependabotUpdate>
    {
        internal DependabotUpdate(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// The error from a dependency update
        /// </summary>
        public DependabotUpdateError Error => this.CreateProperty(x => x.Error, Octokit.Model.DependabotUpdateError.Create);

        /// <summary>
        /// The associated pull request
        /// </summary>
        public PullRequest PullRequest => this.CreateProperty(x => x.PullRequest, Octokit.Model.PullRequest.Create);

        /// <summary>
        /// The repository associated with this node.
        /// </summary>
        public Repository Repository => this.CreateProperty(x => x.Repository, Octokit.Model.Repository.Create);

        internal static DependabotUpdate Create(Expression expression)
        {
            return new DependabotUpdate(expression);
        }
    }
}