using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/concatenation-of-array/
    /// 
    /// Case 1:
    /// Input: nums = [1,2,1]
    /// Output: [1,2,1,1,2,1]
    /// 
    /// Case 2:
    /// Input: nums = [1,3,2,1]
    /// Output: [1,3,2,1,1,3,2,1]
    /// 
    /// </summary>
    public class _1929_Concatenation_of_Array
    {
        public int[] GetConcatenation(int[] nums)
        {
            var result = new int[nums.Length * 2];
            Array.Copy(nums, result, nums.Length);
            Array.Copy(nums, 0, result, nums.Length, nums.Length);
            return result;
        }
    }
}
