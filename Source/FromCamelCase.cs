using System;
using System.Linq;
using System.Threading;
using System.Text.RegularExpressions;

namespace lib
{
    public class FromCamelCase
    {
        public string Convert(string input)
        {
            // Regex split pattern enclosed in '()' will include delimiter in the result.
            // This is so we have something to replace with "_"
            var splitWords = Regex.Split(input, "([A-Z])").Skip(1);

            var re = splitWords.Where(sw => !string.IsNullOrEmpty(sw))
                               .Select(word => Char.IsUpper(word.First()) ? $"_{word.ToLower()}" : word);

            return string.Join("", re).Substring(1);
        }
    }
}