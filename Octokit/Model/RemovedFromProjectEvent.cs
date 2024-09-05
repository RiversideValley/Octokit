namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// Represents a 'removed_from_project' event on a given issue or pull request.
    /// </summary>
    public class RemovedFromProjectEvent : QueryableValue<RemovedFromProjectEvent>
    {
        internal RemovedFromProjectEvent(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// Identifies the actor who performed the event.
        /// </summary>
        public IActor Actor => this.CreateProperty(x => x.Actor, Octokit.Model.Internal.StubIActor.Create);

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public DateTimeOffset CreatedAt { get; }

        /// <summary>
        /// Identifies the primary key from the database.
        /// </summary>
        public long? DatabaseId { get; }

        /// <summary>
        /// The Node ID of the RemovedFromProjectEvent object
        /// </summary>
        public ID Id { get; }

        internal static RemovedFromProjectEvent Create(Expression expression)
        {
            return new RemovedFromProjectEvent(expression);
        }
    }
}