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
    public class RefEdge : QueryableValue<RefEdge>
    {
        internal RefEdge(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public Ref Node => this.CreateProperty(x => x.Node, Octokit.Model.Ref.Create);

        internal static RefEdge Create(Expression expression)
        {
            return new RefEdge(expression);
        }
    }
}