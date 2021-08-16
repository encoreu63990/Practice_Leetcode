using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/create-target-array-in-the-given-order/
    /// </summary>
    class _1389_Create_Target_Array_in_the_Given_Order
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < index.Length; i++)
            {
                result.Insert(index[i], nums[i]);
            }
            return result.ToArray();
        }
    }
}
