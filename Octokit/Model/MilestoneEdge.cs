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
    public class MilestoneEdge : QueryableValue<MilestoneEdge>
    {
        internal MilestoneEdge(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public Milestone Node => this.CreateProperty(x => x.Node, Octokit.Model.Milestone.Create);

        internal static MilestoneEdge Create(Expression expression)
        {
            return new MilestoneEdge(expression);
        }
    }
}