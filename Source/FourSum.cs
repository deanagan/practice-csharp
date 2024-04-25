using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace lib
{
    public class FourSumFinder
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<List<int>>();


            foreach (var t in Permutations(nums))
            {
                //   if (t.)
                Console.WriteLine(t);
            }

            return result.ToList<IList<int>>();
        }

        private ICollection<List<int>> Permutations(int[] nums)
        {
            var result = new List<List<int>>();
            var permutation = new List<int>();
            var usedMap = new List<bool>();

            PermutateWithBacktracking(result, nums, permutation, usedMap);

            return result;
        }



        private void PermutateWithBacktracking(
            ICollection<List<int>> result,
            int[] nums,
            List<int> permutation,
            List<bool> usedMap)
        {
            if (nums.Length == permutation.Count)
            {
                result.Add(permutation);
                return;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (!usedMap[i])
                {
                    usedMap[i] = true;
                    PermutateWithBacktracking(result, nums, permutation, usedMap);
                    usedMap[i] = false;
                }
            }

        }



    }
}
