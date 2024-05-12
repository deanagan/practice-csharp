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
            var result = new StringBuilder();
            var carry = 0;
            var aIndex = a.Length - 1;
            var bIndex = b.Length - 1;

            for (var index = longerNumber; index > 0 || carry == 1; index--)
            {
                var aVal = aIndex >= 0 ? int.Parse(a[aIndex].ToString()) : 0;
                var bVal = bIndex >= 0 ? int.Parse(b[bIndex].ToString()) : 0;

                var sum = (aVal ^ bVal);
                sum ^= carry;
                carry = aVal + bVal + carry > 1 ? 1 : 0;

                result.Append($"{sum}");

                aIndex--;
                bIndex--;
            }

            return new string(result.ToString().Reverse().ToArray());
        }

    }
}
