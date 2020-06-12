using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace lib
{
    public class FirstWord
    {
        public string Retrieve(string input)
        {
            var rx = new Regex(@"[a-zA-z\']+");
            var match = rx.Match(input);
            return match.Value;
        }
    }
}
