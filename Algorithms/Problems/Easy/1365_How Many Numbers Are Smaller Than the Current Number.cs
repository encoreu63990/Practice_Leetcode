using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// /https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
    /// </summary>
    class _1365_How_Many_Numbers_Are_Smaller_Than_the_Current_Number
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            return nums.Select(c => nums.Where(v => c > v).Count()).ToArray();
        }
    }
}
