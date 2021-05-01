
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

// This was a programming exercise and does not have a corresponding unit test.
namespace lib
{
    public class ParseFindHTMLTags
    {

        public static void GetTagWithNoMatch()
        {
            String str = "<div><div><em>hello</em></div>";

            var validPairs = new Dictionary<string, string> {
              { "<div>", "</div>" },
              { "<b>", "</b>" },
              { "<i>", "</i>" },
              { "<em>", "</em>" },
              { "<p>", "</p>" }
            };

            var elements = new Stack<string>();
            // This regex returns the tags only including brackets
            var regex = new Regex(@"</?(div|p|b|em|i)+>", RegexOptions.Compiled);

            foreach (var match in regex.Matches(str))
            {
                var key = match.ToString();
                if (validPairs.ContainsKey(key))
                {
                    elements.Push(validPairs[key]);
                }
                else if (validPairs.ContainsValue(key))
                {
                    if (elements.Count > 0 && !String.Equals(key, elements.Peek()))
                    {
                        var result = elements.Peek();

                        Console.WriteLine(result.Remove(result.Length - 1, 1).Substring(2));

                        Console.WriteLine($"Key={key}, Peek={elements.Peek()}");

                        elements.Pop();
                    }
                }
                else
                {
                    Console.WriteLine(key);
                }
            }

        }

    }
}


// For scriptcs only, uncomment below and comment out namespace lib
// ParseFindHTMLTags.GetTagWithNoMatch();