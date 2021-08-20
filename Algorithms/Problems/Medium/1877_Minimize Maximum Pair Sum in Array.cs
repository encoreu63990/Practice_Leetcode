using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/minimize-maximum-pair-sum-in-array/
    /// </summary>
    class _1877_Minimize_Maximum_Pair_Sum_in_Array
    {
        public int MinPairSum(int[] nums)
        {
            nums = nums.OrderBy(c => c).ToArray();
            var max = nums[0] + nums[nums.Length - 1];
            for (int i = 1, j = nums.Length - 2; j > i; i++, j--)
            {
                max = Math.Max(nums[i] + nums[j], max);
            }
            return max;
        }
    }
}
