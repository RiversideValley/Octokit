# 🐱 `Octokit`

#### Riverside's specialised GitHub API wrapper for .NET 

<p align="center">
  <a title="NuGet" target="_blank" href="https://www.nuget.org/packages/Riverside.Octokit">
    <img align="left" src="http://img.shields.io/nuget/v/Riverside.Octokit.svg" alt="Release" />
  </a>
  <a title="GitHub Releases" target="_blank" href="https://github.com/RiversideValley/{repo name}">
    <img align="left" src="https://img.shields.io/github/v/release/RiversideValley/{repo name}?include_prereleases" alt="Release" />
  </a>
  <a title="Repository Size" target="_blank" href="https://github.com/RiversideValley/{repo name}/activity">
    <img align="left" src="https://img.shields.io/github/repo-size/RiversideValley/{repo name}?color=%23cc0000" alt="Size" />
  </a>
  <a title="Platform" target="_blank" href="https://github.com/topics/{repo platform}">
    <img align="left" src="https://img.shields.io/badge/platform-{repo platform}-{repo platform colour}" alt="Platform" />
  </a>
  <a title="Language" target="_blank" href="https://github.com/RiversideValley/{repo name}/search?l=c%23">
    <img align="left" src="https://img.shields.io/badge/language-{repo lang}-{repo lang colour}" alt="Language" />
  </a>
</p>

<br/>

---

> [!IMPORTANT]
>  This software is currently beta. There are few things left, and there might be bugs - be warned!

Octokit gives you access to the GitHub GraphQL API from .NET. It exposes the GitHub GraphQL API as a strongly-typed LINQ-like API, aiming to follow the GraphQL query syntax as closely as possible, which giving the benefits of strong typing in your favorite .NET language.

## 📝 Documentation

You can find our documentation [here](docs/readme.md).

## 🎁 Installation

<p>
  <a title="GitHub" href="https://github.com/RiversideValley/Octokit/releases/latest">
    <img src="https://user-images.githubusercontent.com/74561130/160255105-5e32f911-574f-4cc4-b90b-8769099086e4.png" width="157" alt="Get it from GitHub" />
  </a>
  <a title="NuGet" href="https://www.nuget.org/packages/Riverside.Octokit">
    <img src="https://github.com/user-attachments/assets/712408b1-4f3b-4de7-bb3d-ac90803d978a" width="180" alt="Get it from NuGet" />
  </a>
<p/>

To install the package from the command line, run the following command:

```ps1
Install-Package Riverside.Octokit -IncludePrerelease
```

## 👥 Usage scenarios

```csharp
using Octokit;
using static Octokit.Variable;

var productInformation = new ProductHeaderValue("YOUR_PRODUCT_NAME", "YOUR_PRODUCT_VERSION");
var connection = new Connection(productInformation, YOUR_OAUTH_TOKEN);

var query = new Query()
    .RepositoryOwner(Var("owner"))
    .Repository(Var("name"))
    .Select(repo => new
    {
        repo.Id,
        repo.Name,
        repo.Owner.Login,
        repo.IsFork,
        repo.IsPrivate,
    }).Compile();

var vars = new Dictionary<string, object>
{
    { "owner", "octokit" },
    { "name", "Octokit.net" },
};

var result =  await connection.Run(query, vars);

Console.WriteLine(result.Login + " & " + result.Name + " Rocks!");
```

```csharp
using Octokit;
using Octokit.Model;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Octokit
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var productInformation = new ProductHeaderValue("ExampleCode", "1.0");

            // Personal Access Token - needs a scope of 'read:user'
            var connection = new Connection(productInformation, "LOGGED_IN_GITHUB_USER_TOKEN");

            // A query to list out who you are actively sponsoring
            // That auto pages through all sponsors
            var query = new Query()
                .Viewer
                .SponsorshipsAsSponsor()
                .AllPages()
                .Select(sponsoring => new
                {
                    User = sponsoring.Sponsorable
                            .Cast<User>()
                            .Select(x => new {
                                x.Login,
                                x.Name,
                                x.Id
                            })
                            .Single()
                })
                .Compile();

            var result = await connection.Run(query);

            // Sponsoring 'warrenbuckley' ?
            var activeSponsor = result.SingleOrDefault(x => x.User.Login.ToLowerInvariant() == "warrenbuckley");
            if(activeSponsor != null)
            {
                Console.WriteLine("Thanks for sponsoring Warren");
            }
        }
    }
}
```

## 🦜 Contributing & Feedback

There are multiple ways to participate in the community:

- Upvote popular feature requests
- [Submit a new feature](https://github.com/RiversideValley/Octokit/pulls)
- [File bugs and feature requests](https://github.com/RiversideValley/Octokit/issues/new/choose).
- Review source [code changes](https://github.com/RiversideValley/Octokit/commits)

<!--### 🏗️ Codebase Structure

```
.
├──Emerald.App                       // Emerald app code and packager
|  ├──Emerald.App                    // Emerald app code (such as code related to UI but not Minecraft)
|  └──Emerald.App.Package            // Package code for generating an uploadable MSIX bundle.
├──Emerald.Core                      // Emerald core code (such as code related to launching and modifying Minecraft
└──Emerald.CoreX                     // Emerald core code for the ability to run different Minecraft installation profiles and mods.
```-->

## 🧪 Running tests/building the code

### 1️⃣ Prerequisites

Ensure you have following components:

<!-- Change as appropriate to the app -->

- [Git](https://git-scm.com/)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- [Windows 11 or Windows 10](https://www.microsoft.com/en-us/windows) (version 1809+)

### 2️⃣ Git

Clone the repository:

```git
git clone https://github.com/RiversideValley/Octokit
```

### 3️⃣ Test the project

- Open `Octokit.sln`.
- Set the Startup Project to the appropriate `Octokit.*.Tests` project
- Build with `DEBUG|x64` (or `DEBUG|Any CPU`)

## ⚖️ License

Copyright (c) 2018 - present GitHub Inc.

Licensed under the MIT license as stated in the [LICENSE](LICENSE.md).
