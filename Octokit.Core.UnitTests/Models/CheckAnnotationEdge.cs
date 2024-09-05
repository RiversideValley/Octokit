using System.Linq.Expressions;
using Octokit.Core.Builders;

namespace Octokit.Core.UnitTests.Models
{
    public class CheckAnnotationEdge : QueryableValue<CheckAnnotationEdge>
    {
        public CheckAnnotationEdge(Expression expression) : base(expression)
        {
        }

        public string Cursor { get; }

        public CheckAnnotation Node => this.CreateProperty(x => x.Node, CheckAnnotation.Create);

        internal static CheckAnnotationEdge Create(Expression expression)
        {
            return new CheckAnnotationEdge(expression);
        }
    }
}