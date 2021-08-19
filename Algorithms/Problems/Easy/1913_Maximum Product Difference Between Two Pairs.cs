using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-product-difference-between-two-pairs/
    /// </summary>
    class _1913_Maximum_Product_Difference_Between_Two_Pairs
    {
        public int MaxProductDifference(int[] nums)
        {
            var array = nums.OrderBy(c => c).ToArray();
            var max = array[array.Length - 1] * array[array.Length - 2];
            var min = array[0] * array[1];
            return max - min;
        }
    }
}
