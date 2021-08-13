using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/build-array-from-permutation/
    /// 
    /// Case 1:
    /// Input: nums = [0,2,1,5,3,4]
    /// Output: [0,1,2,4,5,3]
    /// Case 2:
    /// Input: nums = [5,0,1,2,3,4]
    /// Output: [4,5,0,1,2,3]
    /// 
    /// </summary>
    public class _1920_Build_Array_from_Permutation
    {
        public int[] BuildArray(int[] nums)
        {
            int[] result = new int[nums.Length];
            for(int index = 0; index<nums.Length; index++)
            {
                result[index] = nums[nums[index]];
            }
            return result;
        }
    }
}
