namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of RemoveEnterpriseMember
    /// </summary>
    public class RemoveEnterpriseMemberInput
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The ID of the enterprise from which the user should be removed.
        /// </summary>
        public ID EnterpriseId { get; set; }

        /// <summary>
        /// The ID of the user to remove from the enterprise.
        /// </summary>
        public ID UserId { get; set; }
    }
}