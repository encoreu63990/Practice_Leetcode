using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-xor-for-each-query/
    /// </summary>
    class _1829_Maximum_XOR_for_Each_Query
    {
        public void Run()
        {
            var nums = new int[] { 0, 1, 1, 3 };
            var maximumBit = 2;
            var result = GetMaximumXor(nums, maximumBit);
        }

        public int[] GetMaximumXor(int[] nums, int maximumBit)
        {
            int[] result = new int[nums.Length];
            int max = (int)Math.Pow(2, maximumBit) - 1;

            for (int i = 0, current = 0; i < nums.Length; i++)
            {
                current = current ^ nums[i];
                result[nums.Length - 1 - i] = current ^ max;
            }

            return result;
        }
    }
}
