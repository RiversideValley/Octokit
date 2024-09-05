namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// An edge in a connection.
    /// </summary>
    public class SponsorAndLifetimeValueEdge : QueryableValue<SponsorAndLifetimeValueEdge>
    {
        internal SponsorAndLifetimeValueEdge(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public SponsorAndLifetimeValue Node => this.CreateProperty(x => x.Node, Octokit.Model.SponsorAndLifetimeValue.Create);

        internal static SponsorAndLifetimeValueEdge Create(Expression expression)
        {
            return new SponsorAndLifetimeValueEdge(expression);
        }
    }
}