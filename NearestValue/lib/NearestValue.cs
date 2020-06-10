using System;
using System.Linq;

namespace lib
{
    public class NearestValue
    {
        public int Result(int[] values, int search)
        {
            var res = values.Select(value => Tuple.Create(value, Math.Abs(value-search))).OrderBy(p => Math.Abs(p.Item1 - search) + p.Item1);
            return res.First().Item1;
        }
    }
}
