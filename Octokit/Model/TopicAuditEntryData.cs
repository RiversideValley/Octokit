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
    /// Metadata for an audit entry with a topic.
    /// </summary>
    [GraphQLIdentifier("TopicAuditEntryData")]
    public interface ITopicAuditEntryData : IQueryableValue<ITopicAuditEntryData>, IQueryableInterface
    {
        /// <summary>
        /// The name of the topic added to the repository
        /// </summary>
        Topic Topic { get; }

        /// <summary>
        /// The name of the topic added to the repository
        /// </summary>
        string TopicName { get; }
    }
}

namespace Octokit.Model.Internal
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    [GraphQLIdentifier("TopicAuditEntryData")]
    internal class StubITopicAuditEntryData : QueryableValue<StubITopicAuditEntryData>, ITopicAuditEntryData
    {
        internal StubITopicAuditEntryData(Expression expression) : base(expression)
        {
        }

        public Topic Topic => this.CreateProperty(x => x.Topic, Octokit.Model.Topic.Create);

        public string TopicName { get; }

        internal static StubITopicAuditEntryData Create(Expression expression)
        {
            return new StubITopicAuditEntryData(expression);
        }
    }
}