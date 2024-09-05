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
    public class PublicKeyEdge : QueryableValue<PublicKeyEdge>
    {
        internal PublicKeyEdge(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public PublicKey Node => this.CreateProperty(x => x.Node, Octokit.Model.PublicKey.Create);

        internal static PublicKeyEdge Create(Expression expression)
        {
            return new PublicKeyEdge(expression);
        }
    }
}