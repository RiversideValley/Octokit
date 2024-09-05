using System.Collections.Generic;

namespace Octokit.Core.UnitTests.PagingTests.Models
{
    class IssueModel
    {
        public int Number { get; set; }
        public IList<CommentModel> Comments { get; set; }
    }
}
