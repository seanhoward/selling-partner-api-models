using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using APIBuilder;
using CommandLine;
using Newtonsoft.Json.Linq;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;

class Program
{
    static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(args => Utilities.EnsureDirectoryExists(args.OutputDirectory ?? ""))
            .WithParsed(ProcessModels)
            .WithParsed(ProcessSchemas)
            .WithParsed(GenerateTemplates)
            ;
    }

    static void ProcessModels(Options args)
    {
        foreach (var subdirectory in Directory.GetDirectories(args.ModelDirectory ?? ""))
        {
            try
            {
                var files = Directory.GetFiles(subdirectory, "*.json")
                                         .OrderByDescending(f => f)
                                         .ToList();

                if (files.Count != 0)
                {
                    string firstFile = files.First();
                    var fileName = Path.GetFileNameWithoutExtension(firstFile);
                    if ((fileName.EndsWith("V0")
                        || fileName.EndsWith("V1")
                        || fileName.EndsWith("V2")
                        || fileName.EndsWith("v0")
                        || fileName.EndsWith("v1")
                        || fileName.EndsWith("v2"))
                        && files.Count > 1)
                    {
                        firstFile = files.Skip(1).First();
                        fileName = Path.GetFileNameWithoutExtension(firstFile);
                    }
                    var modelName = fileName
                        .Capitalize()
                        .Replace("V0", "")
                        .Replace("V1", "")
                        .Replace("V2", "")
                        .RemoveDateFromFilename();

                    ProcessStartInfo startInfo = new()
                    {
                        FileName = "java",
                        Arguments =
                        $"-jar \"{args.SwaggerPath}\" generate " +
                        $"-l csharp " +
                        $"-i \"{firstFile}\" " +
                        $"-o \"{args.OutputDirectory}\" " +
                        $"-t \"{args.ResourcesDirectory}\\swagger-codegen\\templates\" " +
                        $"-c \"{args.ResourcesDirectory}\\swagger-codegen\\config.json\" " +
                        $"--ignore-file-override \"{args.ResourcesDirectory}\\swagger-codegen\\.swagger-codegen-ignore\" " +
                        $"--import-mappings ItemAttributes=Newtonsoft.Json.Linq.JObject" +
                        $"--api-package API " +
                        $"--model-package Models.{modelName} " +
                        $"--additional-properties testPackage={modelName} ",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (Process process = Process.Start(startInfo))
                    {
                        process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);
                        process.ErrorDataReceived += (sender, e) => Console.WriteLine("ERROR: " + e.Data);

                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();

                        process.WaitForExit();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{subdirectory}: {ex.Message}");
            }
        }
    }

    static void ProcessSchemas(Options args)
    {
        List<string> schemaFiles = GetSchemaFiles(args.SchemaDirectory ?? "");
        foreach (var schemaFile in schemaFiles)
        {
            try
            {
                var config = new SchemaParserConfig(schemaFile,
                    args.OutputDirectory + "\\src\\Amazon.SellingPartnerAPIAA.Clients" ?? "");
                var document = JsonSchema.FromJsonAsync(config.SchemaJson).Result;
                document.Title = config.ClassName;
                File.WriteAllText(
                    path: config.OutputFile,
                    contents: new CSharpGenerator(
                        rootObject: document,
                        settings: new CSharpGeneratorSettings
                        {
                            GenerateJsonMethods = true,
                            Namespace = config.NameSpace
                        })
                    .GenerateFile());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{schemaFile}: {ex.Message}");
            }
        }
    }

    private static List<string> GetSchemaFiles(string SchemaDirectory)
    {
        return Directory
            .EnumerateFiles(SchemaDirectory ?? "", "*.json", SearchOption.AllDirectories)
            .Where(file => !Path.GetFileNameWithoutExtension(file).Contains("Example", StringComparison.InvariantCultureIgnoreCase))
            .ToList();
    }

    static void GenerateTemplates(Options args)
    {
        var schemaFiles = GetSchemaFiles(args.SchemaDirectory ?? "");

        // Load the template.json file
        string templatePath = "Resources\\template.nswag";
        string templateJson = File.ReadAllText(templatePath);
        JObject templateObj = JObject.Parse(templateJson);

        foreach (var schemaFile in schemaFiles)
        {
            var config = new SchemaParserConfig(schemaFile,
                    args.OutputDirectory + "\\src\\Amazon.SellingPartnerAPIAA.Clients" ?? "");
            string outputFile = $"{args.OutputDirectory}\\Templates\\{config.ClassName}.nswag";

            // Update the property in the template JSON
            templateObj["documentGenerator"]["jsonSchemaToOpenApi"]["schema"] = config.SchemaJson;
            templateObj["codeGenerators"]["openApiToCSharpClient"]["output"] = outputFile;
            templateObj["codeGenerators"]["openApiToCSharpClient"]["namespace"] = config.NameSpace;

            // Save the updated JSON
            File.WriteAllText(outputFile, templateObj.ToString(Newtonsoft.Json.Formatting.Indented));
        }
    }
}
