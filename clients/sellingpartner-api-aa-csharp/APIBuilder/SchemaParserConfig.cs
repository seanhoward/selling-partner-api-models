namespace APIBuilder
{
    internal class SchemaParserConfig
    {
        public SchemaParserConfig(string schemaFile, string outputDirectory)
        {
            ClassName = Path.GetFileNameWithoutExtension(schemaFile)
                .ToCamelCase()
                .Capitalize()
                .Replace("V0", "")
                .Replace("V1", "")
                .Replace("V2", "")
                .RemoveDateFromFilename();
            Folder = Directory.GetParent(schemaFile)?.Name.ToTitleCase() ?? "";
            NameSpace = $"Amazon.SellingPartnerAPIAA.Clients.Schemas.{Folder}.{ClassName.Replace(Folder.ToSingular(), "")}";
            SchemaJson = File.ReadAllText(schemaFile);
            string outputFolder = $"{outputDirectory}\\Schemas.{Folder}";
            OutputFile = $"{outputFolder}\\{ClassName}.cs";
            Utilities.EnsureDirectoryExists(outputFolder);
        }

        public string ClassName { get; set; }
        public string Folder { get; set; }
        public string NameSpace { get; set; }
        public string SchemaJson { get; set; }
        public string OutputFile { get; set; }
    }
}
