using System;
using System.Reflection;

namespace Octokit.Core.Syntax
{
    public class InlineFragment : SelectionSet
    {
        public InlineFragment(Type typeCondition)
        {
            TypeCondition = GetIdentifier(typeCondition);
        }

        public string TypeCondition { get; }
    }
}
