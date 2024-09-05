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
    /// An object with an ID.
    /// </summary>
    [GraphQLIdentifier("Node")]
    public interface INode : IQueryableValue<INode>, IQueryableInterface
    {
        /// <summary>
        /// ID of the object.
        /// </summary>
        ID Id { get; }
    }
}

namespace Octokit.Model.Internal
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    [GraphQLIdentifier("Node")]
    internal class StubINode : QueryableValue<StubINode>, INode
    {
        internal StubINode(Expression expression) : base(expression)
        {
        }

        public ID Id { get; }

        internal static StubINode Create(Expression expression)
        {
            return new StubINode(expression);
        }
    }
}