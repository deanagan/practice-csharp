using System;
using System.Collections.Generic;
using System.Linq;


namespace lib
{
    public class SubstringUtility
    {
        public int GetLengthOfLongestSubstring(string text)
        {
            var charIndices = new Dictionary<char, int>();
            var startIndex = 0;
            var length = 0;

            foreach (var item in text.Select((ch, i) => new { value = ch, index = i }) )
            {
                if(charIndices.ContainsKey(item.value))
                {
                    startIndex = Math.Max(charIndices[item.value] + 1, startIndex);
                }
                length = Math.Max(item.index - startIndex + 1, length);
                charIndices[item.value] = item.index;
            }

            return length;
        }

    }
}
