using System;
using System.Collections.Generic;

namespace lib
{
    public static class DictCounterExtension
    {
        // Increment value. If it does not exist, assume it is zero, so set to 1.
        public static void IncrementValue(this Dictionary<int,int> counter, int key)
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
                var result = (denom - number) % denom;
                var invMod = result < 0 ? result + denom : result;
                total += counter.ContainsKey(invMod) ? counter[invMod] : 0;
                counter.IncrementValue(number % denom);
            }

            return total;
        }
    }
}
