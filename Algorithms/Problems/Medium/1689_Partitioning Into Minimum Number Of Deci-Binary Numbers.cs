using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/partitioning-into-minimum-number-of-deci-binary-numbers/
    /// 
    /// Case 1:
    /// Input: n = "32"
    /// Output: 3
    /// Explanation: 10 + 11 + 11 = 32
    /// 
    /// Case 2:
    /// Input: n = "82734"
    /// Output: 8
    /// 
    /// </summary>
    class _1689_Partitioning_Into_Minimum_Number_Of_Deci_Binary_Numbers
    {
        public int MinPartitions(string n)
        {
            return n.ToCharArray().Select(c => Convert.ToInt32(c.ToString())).Max();
        }
    }
}
