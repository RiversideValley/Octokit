namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// A GitHub Security Advisory Identifier
    /// </summary>
    public class SecurityAdvisoryIdentifier : QueryableValue<SecurityAdvisoryIdentifier>
    {
        internal SecurityAdvisoryIdentifier(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// The identifier type, e.g. GHSA, CVE
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// The identifier
        /// </summary>
        public string Value { get; }

        internal static SecurityAdvisoryIdentifier Create(Expression expression)
        {
            return new SecurityAdvisoryIdentifier(expression);
        }
    }
}