using System;
using System.Collections.Generic;

namespace lib
{
    public class RomanToInteger
    {
        private static readonly IDictionary<char, int> lookup = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        public static int GetNumericValue(string s)
        {
            var prev = '\0';
            var total = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var currentChar = s[i];
                var chNum = lookup[currentChar];


                if (i < (s.Length - 1) && lookup[s[i + 1]] > chNum)
                {
                    prev = s[i];
                    continue;
                }


                if (prev != '\0' && lookup[prev] < chNum)
                {
                    total += chNum - lookup[prev];
                    prev = '\0';
                }
                else
                {
                    total += chNum;
                }


            }

            return total;
        }
    }
}
