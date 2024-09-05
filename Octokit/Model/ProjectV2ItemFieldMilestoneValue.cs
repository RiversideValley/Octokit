namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// The value of a milestone field in a Project item.
    /// </summary>
    public class ProjectV2ItemFieldMilestoneValue : QueryableValue<ProjectV2ItemFieldMilestoneValue>
    {
        internal ProjectV2ItemFieldMilestoneValue(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// The field that contains this value.
        /// </summary>
        public ProjectV2FieldConfiguration Field => this.CreateProperty(x => x.Field, Octokit.Model.ProjectV2FieldConfiguration.Create);

        /// <summary>
        /// Milestone value of a field
        /// </summary>
        public Milestone Milestone => this.CreateProperty(x => x.Milestone, Octokit.Model.Milestone.Create);

        internal static ProjectV2ItemFieldMilestoneValue Create(Expression expression)
        {
            return new ProjectV2ItemFieldMilestoneValue(expression);
        }
    }
}