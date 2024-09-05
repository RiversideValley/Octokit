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
    /// An object that can have users assigned to it.
    /// </summary>
    [GraphQLIdentifier("Assignable")]
    public interface IAssignable : IQueryableValue<IAssignable>, IQueryableInterface
    {
        /// <summary>
        /// A list of Users assigned to this object.
        /// </summary>
        /// <param name="first">Returns the first _n_ elements from the list.</param>
        /// <param name="after">Returns the elements in the list that come after the specified cursor.</param>
        /// <param name="last">Returns the last _n_ elements from the list.</param>
        /// <param name="before">Returns the elements in the list that come before the specified cursor.</param>
        UserConnection Assignees(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null);
    }
}

namespace Octokit.Model.Internal
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    [GraphQLIdentifier("Assignable")]
    internal class StubIAssignable : QueryableValue<StubIAssignable>, IAssignable
    {
        internal StubIAssignable(Expression expression) : base(expression)
        {
        }

        public UserConnection Assignees(Arg<int>? first = null, Arg<string>? after = null, Arg<int>? last = null, Arg<string>? before = null) => this.CreateMethodCall(x => x.Assignees(first, after, last, before), Octokit.Model.UserConnection.Create);

        internal static StubIAssignable Create(Expression expression)
        {
            return new StubIAssignable(expression);
        }
    }
}