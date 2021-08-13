using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/running-sum-of-1d-array/
    /// 
    /// Case 1:
    /// Input: nums = [1,2,3,4]
    /// Output: [1,3,6,10]
    /// 
    /// Case 2:
    /// Input: nums = [1,1,1,1,1]
    /// Output: [1,2,3,4,5]
    /// 
    /// </summary>
    class _1480_Running_Sum_of_1d_Array
    {
        public int[] RunningSum(int[] nums)
        {
            for(int i=1; i<nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }

            return nums;
        }
    }
}
