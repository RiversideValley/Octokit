using System;

namespace Octokit.Core
{
    public class GraphQLIdentifierAttribute : Attribute
    {
        public GraphQLIdentifierAttribute(string identifier)
        {
            Identifier = identifier;
        }

        public string Identifier { get; }
    }
}
