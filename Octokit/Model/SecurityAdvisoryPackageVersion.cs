namespace Octokit.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Octokit.Core;
    using Octokit.Core.Builders;

    /// <summary>
    /// An individual package version
    /// </summary>
    public class SecurityAdvisoryPackageVersion : QueryableValue<SecurityAdvisoryPackageVersion>
    {
        internal SecurityAdvisoryPackageVersion(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// The package name or version
        /// </summary>
        public string Identifier { get; }

        internal static SecurityAdvisoryPackageVersion Create(Expression expression)
        {
            return new SecurityAdvisoryPackageVersion(expression);
        }
    }
}