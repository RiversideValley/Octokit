namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// A user, team, or app who has the ability to dismiss a review on a protected branch.
    /// </summary>
    public class ReviewDismissalAllowance : QueryableValue<ReviewDismissalAllowance>
    {
        internal ReviewDismissalAllowance(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// The actor that can dismiss.
        /// </summary>
        public ReviewDismissalAllowanceActor Actor => this.CreateProperty(x => x.Actor, Octokit.Model.ReviewDismissalAllowanceActor.Create);

        /// <summary>
        /// Identifies the branch protection rule associated with the allowed user, team, or app.
        /// </summary>
        public BranchProtectionRule BranchProtectionRule => this.CreateProperty(x => x.BranchProtectionRule, Octokit.Model.BranchProtectionRule.Create);

        /// <summary>
        /// The Node ID of the ReviewDismissalAllowance object
        /// </summary>
        public ID Id { get; }

        internal static ReviewDismissalAllowance Create(Expression expression)
        {
            return new ReviewDismissalAllowance(expression);
        }
    }
}