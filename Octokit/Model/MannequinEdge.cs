namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// Represents a mannequin.
    /// </summary>
    public class MannequinEdge : QueryableValue<MannequinEdge>
    {
        internal MannequinEdge(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public Mannequin Node => this.CreateProperty(x => x.Node, Octokit.Model.Mannequin.Create);

        internal static MannequinEdge Create(Expression expression)
        {
            return new MannequinEdge(expression);
        }
    }
}