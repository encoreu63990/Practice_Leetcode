using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/split-a-string-in-balanced-strings/
    /// </summary>
    class _1221_Split_a_String_in_Balanced_Strings
    {
        public int BalancedStringSplit(string s)
        {
            var count = 0;
            var balancedNumber = 0;

            foreach (char c in s)
            {
                if (c == 'L')
                    balancedNumber++;
                else
                    balancedNumber--;

                if (balancedNumber == 0)
                    count++;
            }

            return count;
        }
    }
}
