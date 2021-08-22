using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/find-valid-matrix-given-row-and-column-sums/
    /// https://leetcode.com/problems/find-valid-matrix-given-row-and-column-sums/discuss/1419724/C-Solution
    /// </summary>
    class _1605_Find_Valid_Matrix_Given_Row_and_Column_Sums
    {
        public void Run()
        {
            var rowSum = new int[] { 5, 7, 10 };
            var colSum = new int[] { 8, 6, 8 };
            var result = RestoreMatrix(rowSum, colSum);
        }

        public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
        {
            var result = new int[rowSum.Length][];
            result[0] = colSum.ToArray();

            for (int i = 0; i < rowSum.Length - 1; i++)
            {
                result[i + 1] = new int[colSum.Length];
                int backwardsCounter = rowSum[i];

                for (int j = 0; j < colSum.Length; j++)
                {
                    if (result[i][j] >= backwardsCounter)
                    {
                        var offsetValue = result[i][j] - backwardsCounter;
                        backwardsCounter = 0;
                        result[i][j] -= offsetValue;
                        result[i + 1][j] += offsetValue;
                    }
                    else
                    {
                        var offsetValue = result[i][j];
                        backwardsCounter -= offsetValue;
                    }
                }
            }

            return result;
        }
    }
}
