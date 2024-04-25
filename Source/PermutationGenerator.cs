using System.Linq;
using System.Collections.Generic;

namespace lib
{
    public class PermutationGenerator
    {
        public IList<IList<int>> GetPermutations(int[] nums)
        {
            return Permutations(nums).ToList<IList<int>>();
        }

        private IEnumerable<List<int>> Permutations(int[] nums)
        {
            var result = new List<List<int>>();
            var permutation = new List<int>();
            var usedMap = new List<bool>(nums.Select(v => false));

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
                result.Add(new List<int>(permutation));
                return;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (!usedMap[i])
                {
                    usedMap[i] = true;
                    permutation.Add(nums[i]);
                    PermutateWithBacktracking(result, nums, permutation, usedMap);
                    usedMap[i] = false;
                    permutation.RemoveAt(permutation.Count - 1);
                }
            }

        }
    }
}
