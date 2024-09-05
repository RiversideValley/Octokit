using System;
using Octokit.Core.Builders;

namespace Octokit.Core.Introspection
{
    public class IntrospectionQuery : QueryableValue<IntrospectionQuery>, IQuery
    {
        public IntrospectionQuery()
            : base(null)
        {
        }

        [GraphQLIdentifier("__schema")]
        public Schema Schema => this.CreateProperty(x => x.Schema, Schema.Create);
    }
}
