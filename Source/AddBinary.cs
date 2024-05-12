using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System;
using System.Text;

namespace lib
{
    public class AddBinarySolution
    {
        public static string AddBinary(string a, string b)
        {
            var longerNumber = Math.Max(a.Length, b.Length);
            var carry = 0;
            var aIndex = a.Length - 1;
            var bIndex = b.Length - 1;
            var rIndex = longerNumber;
            var result = new char[longerNumber + 1];

            for (var index = longerNumber; index > 0 || carry == 1; index--)
            {
                var aVal = aIndex >= 0 ? int.Parse(a[aIndex].ToString()) : 0;
                var bVal = bIndex >= 0 ? int.Parse(b[bIndex].ToString()) : 0;

                var sum = (aVal ^ bVal);
                sum ^= carry;
                carry = aVal + bVal + carry > 1 ? 1 : 0;

                result[rIndex] = (char)(sum + '0');

                rIndex--;
                aIndex--;
                bIndex--;
            }

            var hasCarry = result[0] != '\0';
            var start = hasCarry ? 0 : 1;
            var totalLength = longerNumber + (hasCarry ? 1 : 0);
            return new string(result, start, totalLength);
        }
    }
}
