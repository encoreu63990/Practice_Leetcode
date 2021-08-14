using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-operations-to-move-all-balls-to-each-box/
    /// </summary>
    class _1769_Minimum_Number_of_Operations_to_Move_All_Balls_to_Each_Box
    {
        public int[] MinOperations(string boxes)
        {
            var length = boxes.Length;
            var array = boxes.ToCharArray();
            int leftCount = 0;
            int rightCount = 0;
            var fromLeft = new int[length];
            var fromRight = new int[length];
            var result = new int[length];

            for (int i = 1, j = length - 2; i < length; i++, j--)
            {
                if (array[i - 1] == '1')
                {
                    leftCount++;
                }
                if (array[j + 1] == '1')
                {
                    rightCount++;
                }

                fromLeft[i] = fromLeft[i - 1] + leftCount;
                fromRight[j] = fromRight[j + 1] + rightCount;
            }

            for (int i = 0; i < length; i++)
            {
                result[i] = fromLeft[i] + fromRight[i];
            }

            return result;
        }
    }
}
