namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// The Common Vulnerability Scoring System
    /// </summary>
    public class CVSS : QueryableValue<CVSS>
    {
        internal CVSS(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// The CVSS score associated with this advisory
        /// </summary>
        public double Score { get; }

        /// <summary>
        /// The CVSS vector string associated with this advisory
        /// </summary>
        public string VectorString { get; }

        internal static CVSS Create(Expression expression)
        {
            return new CVSS(expression);
        }
    }
}