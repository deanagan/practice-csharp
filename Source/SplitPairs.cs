using System.Collections.Generic;
using System.Linq;

namespace lib
{
    public class SplitPairs
    {
        public List<string> SplitString(string input) {
            if (input.Length % 2 != 0) {
                input += '_';
            }
            return input.Where((_, i) => i%2 == 0).Zip(input.Where((_,i) => i % 2 != 0), (a,b) => string.Concat(a,b)).ToList();
        }
    }
}
