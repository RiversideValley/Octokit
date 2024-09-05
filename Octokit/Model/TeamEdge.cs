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
    public class TeamEdge : QueryableValue<TeamEdge>
    {
        internal TeamEdge(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public Team Node => this.CreateProperty(x => x.Node, Octokit.Model.Team.Create);

        internal static TeamEdge Create(Expression expression)
        {
            return new TeamEdge(expression);
        }
    }
}