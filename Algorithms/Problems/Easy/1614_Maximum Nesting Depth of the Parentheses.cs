using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses/
    /// </summary>
    class _1614_Maximum_Nesting_Depth_of_the_Parentheses
    {
        public int MaxDepth(string s)
        {
            var counter = 0;
            var max = 0;

            foreach (var c in s)
            {
                if ( c=='(' )
                {
                    counter++;
                    max = Math.Max(max, counter);
                }
                else if (c == ')')
                {
                    counter--;
                }
            }

            return max;
        }
    }
}
