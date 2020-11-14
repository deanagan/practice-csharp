using System.Collections.Generic;
using System;

namespace lib
{
    public class SubstringUtility
    {

        public int GetLengthOfLongestSubstring(string text)
        {
            var slen = text.Length;
            if (slen == 0) { return 0; }
            var charEntryCount = new Dictionary<char, int>();
            var startIndex = 0;
            var length = 0;

            for(var index = 0; index < slen; index++)
            {
                if (charEntryCount.ContainsKey(text[index]))
                {
                    startIndex = Math.Max(charEntryCount[text[index]] + 1, startIndex);
                }
                length = Math.Max(index - startIndex + 1, length);
                charEntryCount[text[index]] = index;
            }

            return length;
        }

    }
}
