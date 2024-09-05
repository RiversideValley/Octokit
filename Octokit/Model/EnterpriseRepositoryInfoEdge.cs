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
    public class EnterpriseRepositoryInfoEdge : QueryableValue<EnterpriseRepositoryInfoEdge>
    {
        internal EnterpriseRepositoryInfoEdge(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public EnterpriseRepositoryInfo Node => this.CreateProperty(x => x.Node, Octokit.Model.EnterpriseRepositoryInfo.Create);

        internal static EnterpriseRepositoryInfoEdge Create(Expression expression)
        {
            return new EnterpriseRepositoryInfoEdge(expression);
        }
    }
}