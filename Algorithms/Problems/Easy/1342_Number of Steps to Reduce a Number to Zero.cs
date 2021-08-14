using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/
    /// </summary>
    class _1342_Number_of_Steps_to_Reduce_a_Number_to_Zero
    {
        public int NumberOfSteps(int num)
        {
            var count = 0;

            while (num != 0)
            {
                count++;
                num = num % 2 == 0 ? num / 2 : num - 1;
            }

            return count;
        }
    }
}
