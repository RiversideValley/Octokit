using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Octokit.IntegrationTests.Utilities
{
    public class IntegrationTestDiscoverer : IXunitTestCaseDiscoverer
    {
        readonly IMessageSink _diagnosticMessageSink;

        public IntegrationTestDiscoverer(IMessageSink diagnosticMessageSink)
        {
            this._diagnosticMessageSink = diagnosticMessageSink;
        }

        public IEnumerable<IXunitTestCase> Discover(ITestFrameworkDiscoveryOptions discoveryOptions, ITestMethod testMethod, IAttributeInfo factAttribute)
        {
            return Helper.HasCredentials
                ? new[] { new XunitTestCase(_diagnosticMessageSink, discoveryOptions.MethodDisplayOrDefault(), TestMethodDisplayOptions.None, testMethod) }
                : Enumerable.Empty<IXunitTestCase>();
        }
    }

    [XunitTestCaseDiscoverer("Octokit.IntegrationTests.Utilities.IntegrationTestDiscoverer", "Octokit.IntegrationTests")]
    public class IntegrationTestAttribute : FactAttribute
    {
    }
}
