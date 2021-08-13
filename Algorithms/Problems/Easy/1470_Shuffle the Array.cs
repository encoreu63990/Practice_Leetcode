using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/shuffle-the-array/
    /// 
    /// Case 1:
    /// Input: nums = [2,5,1,3,4,7], n = 3
    /// Output: [2,3,5,4,1,7]
    ///
    /// Case 2:
    /// Input: nums = [1,2,3,4,4,3,2,1], n = 4
    /// Output: [1,4,2,3,3,2,4,1]
    /// </summary>
    class _1470_Shuffle_the_Array
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] result = new int[n * 2];
            for (int i = 0; i < n; i++)
            {
                result[i * 2] = nums[i];
                result[i * 2 + 1] = nums[i + n];
            }
            return result;
        }
    }
}
