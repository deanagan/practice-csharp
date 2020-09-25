using System;
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

            // Parentheses always come in pairs.
            if (s.Length % 2 != 0)
            {
                return false;
            }
            var entries = new Stack<char>();


            foreach(var ch in s)
            {
                char key;
                if (brackets.ContainsKey(ch))
                {
                    entries.Push(ch);
                }
                else if (entries.Any() && (brackets.TryGetValue(entries.Peek(), out key) && (key == ch)))
                {
                    entries.Pop();
                }
            }

            return !entries.Any();
        }
    }
}
