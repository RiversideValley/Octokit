namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of UpdateUserList
    /// </summary>
    public class UpdateUserListPayload : QueryableValue<UpdateUserListPayload>
    {
        internal UpdateUserListPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The list that was just updated
        /// </summary>
        public UserList List => this.CreateProperty(x => x.List, Octokit.GraphQL.Model.UserList.Create);

        internal static UpdateUserListPayload Create(Expression expression)
        {
            return new UpdateUserListPayload(expression);
        }
    }
}