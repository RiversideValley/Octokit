using System;

namespace Octokit.Core
{
    internal interface IArg
    {
        bool IsNullableVariable { get; }
        Type Type { get; }
        string VariableName { get; }
        object Value { get; }
    }
}
