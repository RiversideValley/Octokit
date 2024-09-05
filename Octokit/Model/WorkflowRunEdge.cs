namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// An edge in a connection.
    /// </summary>
    public class WorkflowRunEdge : QueryableValue<WorkflowRunEdge>
    {
        internal WorkflowRunEdge(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A cursor for use in pagination.
        /// </summary>
        public string Cursor { get; }

        /// <summary>
        /// The item at the end of the edge.
        /// </summary>
        public WorkflowRun Node => this.CreateProperty(x => x.Node, Octokit.Model.WorkflowRun.Create);

        internal static WorkflowRunEdge Create(Expression expression)
        {
            return new WorkflowRunEdge(expression);
        }
    }
}