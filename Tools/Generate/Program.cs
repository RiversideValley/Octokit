﻿using System;
using System.Threading.Tasks;
using Octokit;
using Octokit.Core.Generation;
using System.IO;
using System.Linq;

namespace Generate
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("GitHub GraphQL .NET entity generator");
                Console.WriteLine("usage: Generate.exe [apitoken] [path]");
                return;
            }

            GenerateEntities(args[0], args[1]).Wait();
        }

        private static async Task GenerateEntities(string token, string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var modelPath = Path.Combine(path, "Model");
            if (!Directory.Exists(modelPath))
            {
                Directory.CreateDirectory(modelPath);
            }

            var csFiles = Directory.EnumerateFiles(path, "*.cs")
                .Union(Directory.EnumerateFiles(modelPath, "*.cs"));

            foreach (var csFile in csFiles)
            {
                File.Delete(csFile);
            }

            var header = new ProductHeaderValue("Octokit", "0.1");
            var connection = new Connection(header, token);

            Console.WriteLine("Reading from " + connection.Uri);
            var schema = await SchemaReader.ReadSchema(connection);

            foreach (var file in CodeGenerator.Generate(schema, "Octokit", "Octokit.Model"))
            {
                // fix for int32 overflow, see https://github.com/octokit/Octokit.net/issues/311
                if (file.Content.Contains("int? DatabaseId { get; }"))
                {
                    file.Content = file.Content.Replace("int? DatabaseId { get; }", "long? DatabaseId { get; }");
                }
                Console.WriteLine("Writing " + file.Path);
                File.WriteAllText(Path.Combine(path, file.Path), file.Content);
            }
        }
    }
}
