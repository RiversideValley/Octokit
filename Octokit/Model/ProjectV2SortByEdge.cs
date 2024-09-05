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
    public class ProjectV2SortByEdge : QueryableValue<ProjectV2SortByEdge>
    {
        internal ProjectV2SortByEdge(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public ProjectV2SortBy Node => this.CreateProperty(x => x.Node, Octokit.Model.ProjectV2SortBy.Create);

        internal static ProjectV2SortByEdge Create(Expression expression)
        {
            return new ProjectV2SortByEdge(expression);
        }
    }
}