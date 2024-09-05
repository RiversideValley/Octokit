namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// A GitHub Security Advisory Reference
    /// </summary>
    public class SecurityAdvisoryReference : QueryableValue<SecurityAdvisoryReference>
    {
        internal SecurityAdvisoryReference(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A publicly accessible reference
        /// </summary>
        public string Url { get; }

        internal static SecurityAdvisoryReference Create(Expression expression)
        {
            return new SecurityAdvisoryReference(expression);
        }
    }
}