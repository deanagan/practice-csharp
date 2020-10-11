using System.Linq;
using System.Collections.Generic;

namespace lib
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var brackets = new Dictionary<char,char>
            {
                {'{', '}' },
                {'[', ']' },
                {'(', ')' }
            };

            var entries = new Stack<char>();
            entries.Push('\0');
            foreach(var ch in s)
            {
                if (brackets.ContainsKey(ch))
                {
                    entries.Push(brackets[ch]);
                }
                else if (brackets.ContainsValue(ch) && (ch != entries.Pop()))
                {
                    return false;
                }
            }

            return (entries.Count == 1) && (entries.First() == '\0');
        }
    }
}
