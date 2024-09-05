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
    /// Entities that can be updated.
    /// </summary>
    [GraphQLIdentifier("Updatable")]
    public interface IUpdatable : IQueryableValue<IUpdatable>, IQueryableInterface
    {
        /// <summary>
        /// Check if the current viewer can update this object.
        /// </summary>
        bool ViewerCanUpdate { get; }
    }
}

namespace Octokit.Model.Internal
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    [GraphQLIdentifier("Updatable")]
    internal class StubIUpdatable : QueryableValue<StubIUpdatable>, IUpdatable
    {
        internal StubIUpdatable(Expression expression) : base(expression)
        {
        }

        public bool ViewerCanUpdate { get; }

        internal static StubIUpdatable Create(Expression expression)
        {
            return new StubIUpdatable(expression);
        }
    }
}