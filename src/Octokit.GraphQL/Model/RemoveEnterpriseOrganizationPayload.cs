namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of RemoveEnterpriseOrganization
    /// </summary>
    public class RemoveEnterpriseOrganizationPayload : QueryableValue<RemoveEnterpriseOrganizationPayload>
    {
        internal RemoveEnterpriseOrganizationPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The updated enterprise.
        /// </summary>
        public Enterprise Enterprise => this.CreateProperty(x => x.Enterprise, Octokit.GraphQL.Model.Enterprise.Create);

        /// <summary>
        /// The organization that was removed from the enterprise.
        /// </summary>
        public Organization Organization => this.CreateProperty(x => x.Organization, Octokit.GraphQL.Model.Organization.Create);

        /// <summary>
        /// The viewer performing the mutation.
        /// </summary>
        public User Viewer => this.CreateProperty(x => x.Viewer, Octokit.GraphQL.Model.User.Create);

        internal static RemoveEnterpriseOrganizationPayload Create(Expression expression)
        {
            return new RemoveEnterpriseOrganizationPayload(expression);
        }
    }
}