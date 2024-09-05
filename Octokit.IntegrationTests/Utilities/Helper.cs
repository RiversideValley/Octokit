using System;

namespace Octokit.IntegrationTests.Utilities
{
    public static class Helper
    {
        public static string Username => Environment.GetEnvironmentVariable("OCTOKIT_GQL_GITHUBUSERNAME");

        public static string OAuthToken => Environment.GetEnvironmentVariable("OCTOKIT_GQL_OAUTHTOKEN");

        public static bool HasCredentials => !String.IsNullOrWhiteSpace(Username) && !String.IsNullOrWhiteSpace(OAuthToken);
    }
}
