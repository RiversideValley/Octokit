using System;
using System.Linq.Expressions;
using Octokit.Core.Builders;

namespace Octokit.Core.UnitTests.Models
{
    public class IssueEdge : QueryableValue<IssueEdge>
    {
        public IssueEdge(Expression expression) : base(expression)
        {
        }

        public string Cursor { get; }
        public Issue Node => this.CreateProperty(x => x.Node, Models.Issue.Create);

        internal static IssueEdge Create(Expression expression)
        {
            return new IssueEdge(expression);
        }
    }
}