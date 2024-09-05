using System;
using System.Collections.Generic;
using System.Reflection;

namespace Octokit.Core.Syntax
{
    public interface ISelectionSet : ISyntaxNode
    {
        IList<ISyntaxNode> Selections { get; }
    }
}
