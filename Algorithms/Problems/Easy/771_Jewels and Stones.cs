using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/jewels-and-stones/
    /// 
    /// Case 1:
    /// Input: jewels = "aA", stones = "aAAbbbb"
    /// Output: 3
    ///  
    /// Case 2:
    /// Input: jewels = "z", stones = "ZZ"
    /// Output: 0
    /// 
    /// </summary>
    class _771_Jewels_and_Stones
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            return stones.Where(c => jewels.Contains(c)).Count();
        }
    }
}
