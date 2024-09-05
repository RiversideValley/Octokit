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
    /// An object that can be locked.
    /// </summary>
    [GraphQLIdentifier("Lockable")]
    public interface ILockable : IQueryableValue<ILockable>, IQueryableInterface
    {
        /// <summary>
        /// Reason that the conversation was locked.
        /// </summary>
        LockReason? ActiveLockReason { get; }

        /// <summary>
        /// `true` if the object is locked
        /// </summary>
        bool Locked { get; }
    }
}

namespace Octokit.Model.Internal
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    [GraphQLIdentifier("Lockable")]
    internal class StubILockable : QueryableValue<StubILockable>, ILockable
    {
        internal StubILockable(Expression expression) : base(expression)
        {
        }

        public LockReason? ActiveLockReason { get; }

        public bool Locked { get; }

        internal static StubILockable Create(Expression expression)
        {
            return new StubILockable(expression);
        }
    }
}