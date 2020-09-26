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

            var entries = new Stack<char>();


            foreach(var ch in s)
            {
                if (brackets.ContainsKey(ch))
                {
                    entries.Push(ch);
                }
                else if (brackets.ContainsValue(ch))
                {
                    char key;
                    if (entries.Any() && (brackets.TryGetValue(entries.Peek(), out key) && (key == ch)))
                    {
                        entries.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return !entries.Any();
        }
    }
}
