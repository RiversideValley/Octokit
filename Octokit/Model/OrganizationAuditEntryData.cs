namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Octokit.Model;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// Metadata for an audit entry with action org.*
    /// </summary>
    [GraphQLIdentifier("OrganizationAuditEntryData")]
    public interface IOrganizationAuditEntryData : IQueryableValue<IOrganizationAuditEntryData>, IQueryableInterface
    {
        /// <summary>
        /// The Organization associated with the Audit Entry.
        /// </summary>
        Organization Organization { get; }

        /// <summary>
        /// The name of the Organization.
        /// </summary>
        string OrganizationName { get; }

        /// <summary>
        /// The HTTP path for the organization
        /// </summary>
        string OrganizationResourcePath { get; }

        /// <summary>
        /// The HTTP URL for the organization
        /// </summary>
        string OrganizationUrl { get; }
    }
}

namespace Octokit.Model.Internal
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    [GraphQLIdentifier("OrganizationAuditEntryData")]
    internal class StubIOrganizationAuditEntryData : QueryableValue<StubIOrganizationAuditEntryData>, IOrganizationAuditEntryData
    {
        internal StubIOrganizationAuditEntryData(Expression expression) : base(expression)
        {
        }

        public Organization Organization => this.CreateProperty(x => x.Organization, Octokit.Model.Organization.Create);

        public string OrganizationName { get; }

        public string OrganizationResourcePath { get; }

        public string OrganizationUrl { get; }

        internal static StubIOrganizationAuditEntryData Create(Expression expression)
        {
            return new StubIOrganizationAuditEntryData(expression);
        }
    }
}