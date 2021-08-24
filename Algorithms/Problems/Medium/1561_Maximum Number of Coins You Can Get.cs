using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-number-of-coins-you-can-get/
    /// </summary>
    class _1561_Maximum_Number_of_Coins_You_Can_Get
    {
        public int MaxCoins(int[] piles)
        {
            Array.Sort(piles);
            Array.Reverse(piles);

            var result = 0;

            for (int i = 0; i < piles.Length / 3; i++)
            {
                result += piles[1 + i * 2];
            }

            return result;
        }
    }
}
