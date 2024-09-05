namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// A team, user, or app who has the ability to push to a protected branch.
    /// </summary>
    public class PushAllowance : QueryableValue<PushAllowance>
    {
        internal PushAllowance(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// The actor that can push.
        /// </summary>
        public PushAllowanceActor Actor => this.CreateProperty(x => x.Actor, Octokit.Model.PushAllowanceActor.Create);

        /// <summary>
        /// Identifies the branch protection rule associated with the allowed user, team, or app.
        /// </summary>
        public BranchProtectionRule BranchProtectionRule => this.CreateProperty(x => x.BranchProtectionRule, Octokit.Model.BranchProtectionRule.Create);

        /// <summary>
        /// The Node ID of the PushAllowance object
        /// </summary>
        public ID Id { get; }

        internal static PushAllowance Create(Expression expression)
        {
            return new PushAllowance(expression);
        }
    }
}