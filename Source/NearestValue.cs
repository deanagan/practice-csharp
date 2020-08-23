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
            var diff = Math.Abs(_search - a) - Math.Abs(_search - b);
            return (diff == 0) ? Math.Min(a,b) : diff;
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
