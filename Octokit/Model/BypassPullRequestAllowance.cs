namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// A user, team, or app who has the ability to bypass a pull request requirement on a protected branch.
    /// </summary>
    public class BypassPullRequestAllowance : QueryableValue<BypassPullRequestAllowance>
    {
        internal BypassPullRequestAllowance(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// The actor that can bypass.
        /// </summary>
        public BranchActorAllowanceActor Actor => this.CreateProperty(x => x.Actor, Octokit.Model.BranchActorAllowanceActor.Create);

        /// <summary>
        /// Identifies the branch protection rule associated with the allowed user, team, or app.
        /// </summary>
        public BranchProtectionRule BranchProtectionRule => this.CreateProperty(x => x.BranchProtectionRule, Octokit.Model.BranchProtectionRule.Create);

        /// <summary>
        /// The Node ID of the BypassPullRequestAllowance object
        /// </summary>
        public ID Id { get; }

        internal static BypassPullRequestAllowance Create(Expression expression)
        {
            return new BypassPullRequestAllowance(expression);
        }
    }
}