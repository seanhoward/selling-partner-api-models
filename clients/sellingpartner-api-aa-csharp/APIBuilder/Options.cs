namespace APIBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;
    using CommandLine;

    [Verb("parse", HelpText = "Traverse the given model directory and generate API clients and models.")]
    class Options
    {
        [Option('m', "modelDirectory", Required = false, HelpText = "Directory to Models")]
        public string? ModelDirectory { get; set; }

        [Option('s', "SchemaDirectory", Required = false, HelpText = "Directory to Schemas")]
        public string? SchemaDirectory { get; set; }

        [Option('j', "SwaggerPath", Required = false, HelpText = "Path to Swagger CodeGen Jar file")]
        public string? SwaggerPath { get; set; }

        [Option('o', "OutputDirectory", Required = false, HelpText = "Output Directory")]
        public string? OutputDirectory { get; set; }

        [Option('r', "ResourcesDirectory", Required = false, HelpText = "Resources Directory")]
        public string? ResourcesDirectory { get; set; }
    }
}
