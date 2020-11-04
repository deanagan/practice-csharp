using System;
using System.Collections.Generic;

namespace lib
{
    public static class DictCounterExtension
    {
        public static void IncrementValueOrDefault(this Dictionary<int,int> counter, int key)
        {
            int value;
            if (counter.TryGetValue(key, out value))
            {
                counter[key]++;
            }
            else
            {
                counter.Add(key, 1);
            }
        }
    }

    public class NumberPairs
    {
        List<int> _numbers;
        public NumberPairs(int[] inputs)
        {
            _numbers = new List<int>(inputs);
        }
        public int CountPairs(int denom)
        {
            var counter = new Dictionary<int, int>();
            var total = 0;
            foreach (var number in _numbers)
            {
                // We want to keep denom larger by adding a factor of 10
                var invMod = (denom*(10*number/denom) - number) % denom;
                total += counter.ContainsKey(invMod) ? counter[invMod] : 0;
                counter.IncrementValueOrDefault(number % denom);
            }

            return total;
        }
    }
}
