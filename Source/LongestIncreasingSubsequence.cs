
using System.Collections.Generic;
using System;
using System.Linq;

namespace lib
{
    public static class ListExtension
    {
        public static void Populate(this int[] distanceScale, int distance)
        {
            for (var i = 0; i < distanceScale.Length; i++)
            {
                distanceScale[i] = distance;
            }
        }
    }

    public class LISFinder
    {

        public static int LongestIncreasingSubsequence(List<int> arr)
        {
            var arrSize = arr.Count;
            var distanceScale = new int[arrSize];

            // We populate a distance scale. Our space complexity has O(n) as we are storing our
            // distances here.
            distanceScale.Populate(1);

            for (var lookback = 1; lookback < arrSize; lookback++)
            {
                for (var runner = 0; runner < lookback; runner++)
                {
                    if (arr[lookback] > arr[runner])
                    {
                        distanceScale[lookback] = Math.Max(distanceScale[runner] + 1, distanceScale[lookback]);
                    }
                }
            }
            return distanceScale.Max();
        }
    }
}