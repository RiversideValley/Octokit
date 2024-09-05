using System;
using System.Linq;
using Octokit.Core;
using Octokit.Core.Builders;
using Octokit.Core.Deserializers;
using Xunit;

namespace Octokit.UnitTests
{
    public class PartialEvaluationTests
    {
        [Fact]
        public void RepositoryOwner_Repository_Append_From_Different_Entities()
        {
            var expression = new Query()
                .RepositoryOwner("foo")
                .Repository("bar")
                .Select(x => new
                {
                    Owner = x.Owner.Select(o => new
                    {
                        Thing = x.Name + ": " + o.Login,
                    }).Single(),
                });

            string data = @"{
  ""data"": {
    ""repositoryOwner"": {
      ""repository"": {
        ""name"": ""Octokit.Core"",
        ""owner"": {
          ""login"": ""grokys""
        },
      }
    }
  }
}";

            var query = new QueryBuilder().Build(expression);
            var result = query.Deserialize(data);

            Assert.Equal("Octokit.Core: grokys", result.Owner.Thing);
        }
    }
}
