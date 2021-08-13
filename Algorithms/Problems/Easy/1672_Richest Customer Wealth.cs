using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/richest-customer-wealth/
    /// 
    /// Case 1:
    /// Input: accounts = [[1,2,3],[3,2,1]]
    /// Output: 6
    /// 
    /// Case 2:
    /// Input: accounts = [[1,5],[7,3],[3,5]]
    /// Output: 10
    /// 
    /// </summary>
    class _1672_Richest_Customer_Wealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            int maxWealth = 0;
            for(int i=0;i<accounts.Length; i++)
            {
                var wealth = accounts[i].Sum();
                maxWealth = Math.Max(wealth, maxWealth);
            }
            return maxWealth;
        }
    }
}
