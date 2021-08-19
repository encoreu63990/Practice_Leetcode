using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-operations-to-make-array-equal/
    /// https://leetcode.com/problems/minimum-operations-to-make-array-equal/discuss/1413735/C-Simple-Soulutin
    /// </summary>
    class _1551_Minimum_Operations_to_Make_Array_Equal
    {
        public int MinOperations(int n)
        {
            /*
                n = 4
                (1, 3), 5, 7
                result = (4 * 2) - (1 + 3) = 4

                n = 7
                (1, 3, 5, 7), 9, 11, 13
                result = (7 * 4) - (1 + 3 + 5 + 7) = 12 

                1 + 3 + 5 + 7... 
                    = (lower + upper) * hight / 2  
                1 + 3 = (1 + 3) * 2 / 2 = 4
                1 + 3 + 5 + 7 = (1 + 7) * 4 / 2 = 16 
            */

            var lastN = (n % 2 == 0) ? n - 1 : n;
            var lastI = (lastN - 1) / 2;
            var result = n * (lastI + 1) - (1 + lastN) * (lastI + 1) / 2;

            return result;
        }
    }
}
