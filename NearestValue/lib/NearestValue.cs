using System;
using System.Collections.Generic;
using System.Linq;

namespace lib
{
    class SearchDistanceComparer : IComparer<int>
    {
        private readonly int _search;
        public SearchDistanceComparer(int search)
        {
            _search = search;
        }
        public int Compare(int a, int b)
        {
            var result = Math.Abs(_search - a) - Math.Abs(_search - b);
            if (result == 0)
            {
                return Math.Min(a,b);
            }
            return result;
        }
    }
    public class NearestValue
    {
        public int Result(int[] values, int search)
        {
            var res = values.OrderBy(v => v, new SearchDistanceComparer(search));
            return res.First();
        }
    }
}
