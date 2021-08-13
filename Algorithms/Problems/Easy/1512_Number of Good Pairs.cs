using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-good-pairs/
    /// 
    /// Case 1:
    /// Input: nums = [1,2,3,1,1,3]
    /// Output: 4
    /// Explanation: There are 4 good pairs(0,3), (0,4), (3,4), (2,5) 0-indexed.
    /// 
    /// Case 2:
    /// Input: nums = [1,1,1,1]
    /// Output: 6
    /// Explanation: Each pair in the array are good.
    /// 
    /// Case 3:
    /// Input: nums = [1,2,3]
    /// Output: 0
    /// 
    /// </summary>
    class _1512_Number_of_Good_Pairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            var keys = dict.Keys ;
            var pairs = 0;

            foreach(var num in nums)
            {
                if( dict.ContainsKey(num))
                {
                    dict[num]++;
                    continue;
                }
                dict.Add(num, 1);
            }
            foreach(var key in keys)
            {
                int count = dict[key];
                pairs += count * (count - 1) / 2;
            }

            return pairs;
        }
    }
}
