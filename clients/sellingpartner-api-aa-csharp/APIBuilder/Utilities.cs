namespace APIBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    internal static class Utilities
    {
        internal static int EnsureDirectoryExists(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            return 0;
        }
    }

    internal static class StringExtensions
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

        public static string RemoveDateFromFilename(this string input)
        {
            // Regex pattern to match the date in the format YYYY-MM-DD
            string pattern = @"[-_]\d{4}-\d{2}-\d{2}";
            return Regex.Replace(input, pattern, string.Empty);
        }
    }
}
