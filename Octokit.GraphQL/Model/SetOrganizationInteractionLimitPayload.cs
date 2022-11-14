namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of SetOrganizationInteractionLimit
    /// </summary>
    public class SetOrganizationInteractionLimitPayload : QueryableValue<SetOrganizationInteractionLimitPayload>
    {
        internal SetOrganizationInteractionLimitPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The organization that the interaction limit was set for.
        /// </summary>
        public Organization Organization => this.CreateProperty(x => x.Organization, Octokit.GraphQL.Model.Organization.Create);

        internal static SetOrganizationInteractionLimitPayload Create(Expression expression)
        {
            return new SetOrganizationInteractionLimitPayload(expression);
        }
    }
}