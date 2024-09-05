using System;
using System.Linq.Expressions;

namespace Octokit.Core.UnitTests.Models
{
    public class LicenseRule : QueryableValue<LicenseRule>
    {
        public LicenseRule(Expression expression) : base(expression)
        {
        }

        public string Description { get; }
        public string Key { get; }
        public string Label { get; }

        internal static LicenseRule Create(Expression expression)
        {
            return new LicenseRule(expression);
        }
    }
}