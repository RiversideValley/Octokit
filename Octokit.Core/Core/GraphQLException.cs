using System;

namespace Octokit.Core
{
    public class GraphQLException : Exception
    {
        public GraphQLException()
        {
        }

        public GraphQLException(string message) : base(message)
        {
        }
    }
}