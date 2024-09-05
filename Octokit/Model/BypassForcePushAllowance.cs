namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// A user, team, or app who has the ability to bypass a force push requirement on a protected branch.
    /// </summary>
    public class BypassForcePushAllowance : QueryableValue<BypassForcePushAllowance>
    {
        internal BypassForcePushAllowance(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// The actor that can force push.
        /// </summary>
        public BranchActorAllowanceActor Actor => this.CreateProperty(x => x.Actor, Octokit.Model.BranchActorAllowanceActor.Create);

        /// <summary>
        /// Identifies the branch protection rule associated with the allowed user, team, or app.
        /// </summary>
        public BranchProtectionRule BranchProtectionRule => this.CreateProperty(x => x.BranchProtectionRule, Octokit.Model.BranchProtectionRule.Create);

        /// <summary>
        /// The Node ID of the BypassForcePushAllowance object
        /// </summary>
        public ID Id { get; }

        internal static BypassForcePushAllowance Create(Expression expression)
        {
            return new BypassForcePushAllowance(expression);
        }
    }
}