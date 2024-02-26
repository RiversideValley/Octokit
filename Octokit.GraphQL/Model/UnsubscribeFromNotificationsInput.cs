namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of UnsubscribeFromNotifications
    /// </summary>
    public class UnsubscribeFromNotificationsInput
    {
        /// <summary>
        /// The NotificationThread IDs of the objects to unsubscribe from.
        /// </summary>
        public IEnumerable<ID> Ids { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}