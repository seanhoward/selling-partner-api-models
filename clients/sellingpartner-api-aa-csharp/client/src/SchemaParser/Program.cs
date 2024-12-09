using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using NJsonSchema;
using NJsonSchema.CodeGeneration.CSharp;

public class Program
{
    static string output = "Output";

    static void Main(string[] args)
    {
        output = args[1];
        if (!Directory.Exists(output))
            Directory.CreateDirectory(output);

        var schemaFiles = Directory
            .EnumerateFiles(args[0], "*.json", SearchOption.AllDirectories)
            .Where(file => !Path.GetFileNameWithoutExtension(file).Contains("Example", StringComparison.InvariantCultureIgnoreCase))
            .ToList();

        switch (args[2])
        {
            case "-t":
                WriteTemplate(schemaFiles);
                break;
            case "-c":
                WriteCode(schemaFiles);
                break;
            default:
                break;
        }
    }

    static void WriteTemplate(List<string> schemaFiles)
    {
        // Load the template.json file
        string templatePath = "template.nswag";
        string templateJson = File.ReadAllText(templatePath);
        JObject templateObj = JObject.Parse(templateJson);

        foreach (var schemaFile in schemaFiles)
        {
            var config = new ParserConfig(schemaFile);
            string outputFile = $"{output}/{config.ClassName}.nswag";

            // Update the property in the template JSON
            templateObj["documentGenerator"]["jsonSchemaToOpenApi"]["schema"] = config.SchemaJson;
            templateObj["codeGenerators"]["openApiToCSharpClient"]["output"] = outputFile;
            templateObj["codeGenerators"]["openApiToCSharpClient"]["namespace"] = config.NameSpace;

            // Save the updated JSON
            File.WriteAllText(outputFile, templateObj.ToString(Newtonsoft.Json.Formatting.Indented));
        }
    }

    static void WriteCode(List<string> schemaFiles)
    {
        foreach (var schemaFile in schemaFiles)
        {
            try
            {
                var config = new ParserConfig(schemaFile);
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
    class ParserConfig
    {
        public ParserConfig(string schemaFile)
        {
            ClassName = Path.GetFileNameWithoutExtension(schemaFile)
                .Replace("-", "")
                .ToCamelCase()
                .Capitalize();
            Folder = Directory.GetParent(schemaFile)?.Name.ToTitleCase() ?? "";
            NameSpace = $"Amazon.SellingPartnerAPIAA.Clients.Schemas.{Folder}.{ClassName.Replace(Folder.ToSingular(), "")}";
            SchemaJson = File.ReadAllText(schemaFile);
            OutputFile = $"{output}/Schemas.{Folder}/{ClassName}.cs";
            EnsureDirectoryExists(OutputFile);
        }
        public string ClassName { get; set; }
        public string Folder { get; set; }
        public string NameSpace { get; set; }
        public string SchemaJson { get; set; }
        public string OutputFile { get; set; }
    }
    static void EnsureDirectoryExists(string filePath)
    { 
        string directoryPath = Path.GetDirectoryName(filePath) ?? ""; 
        if (!Directory.Exists(directoryPath)) { 
            Directory.CreateDirectory(directoryPath); } 
    }
}

public static class StringExtensions
{
    public static string ToTitleCase(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(str.ToLower());
    }

    public static string ToSnakeCase(this string str)
    {
        if (string.IsNullOrEmpty(str)) return str;
        // Convert to lower case and replace spaces with underscores
        string snakeCase = Regex.Replace(str, @"\s+", "_").ToLower();

        // Handle camel case to snake case conversion
        snakeCase = Regex.Replace(snakeCase, @"([a-z0-9])([A-Z])", "$1_$2").ToLower();
        return snakeCase;
    }

    public static string Capitalize(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;
        return char.ToUpper(str[0]) + str.Substring(1);
    }

    public static string ToCamelCase(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        if (Regex.IsMatch(str, @"(?!^)[A-Z]"))
            return str;

        // Convert the string to title case
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string titleCase = textInfo.ToTitleCase(str.ToLower());

        // Remove spaces and capitalize the first letter of each word
        StringBuilder camelCase = new StringBuilder();
        bool nextUpper = false;
        foreach (char c in titleCase)
        {
            if (char.IsWhiteSpace(c) || c == '-' || c == '_')
            {
                nextUpper = true;
            }
            else
            {
                camelCase.Append(nextUpper ? char.ToUpper(c) : char.ToLower(c));
                nextUpper = false;
            }
        }

        // Lowercase the first character
        if (camelCase.Length > 0)
        {
            camelCase[0] = char.ToLower(camelCase[0]);
        }

        return camelCase.ToString();
    }

    public static string ToSingular(this string plural)
    {
        if (string.IsNullOrEmpty(plural))
            return plural;

        // Irregular plurals
        if (plural.EndsWith("men"))
            return Regex.Replace(plural, "men$", "man");
        if (plural.EndsWith("women"))
            return Regex.Replace(plural, "women$", "woman");
        if (plural.EndsWith("children"))
            return Regex.Replace(plural, "children$", "child");
        if (plural.EndsWith("mice"))
            return Regex.Replace(plural, "mice$", "mouse");
        if (plural.EndsWith("geese"))
            return Regex.Replace(plural, "geese$", "goose");

        // Regular plurals
        if (plural.EndsWith("ies"))
            return Regex.Replace(plural, "ies$", "y");
        if (plural.EndsWith("es"))
            return Regex.Replace(plural, "es$", "");
        if (plural.EndsWith("s"))
            return Regex.Replace(plural, "s$", "");

        return plural;
    }
}