using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problemset/algorithms/?page=4&sorting=W3sic29ydE9yZGVyIjoiREVTQ0VORElORyIsIm9yZGVyQnkiOiJBQ19SQVRFIn1d
    /// </summary>
    class _1277_Count_Square_Submatrices_with_All_Ones
    {
        public void Run()
        {
            var matrix = new int[3][] {
                new int[] { 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 1 },
                new int[] { 0, 1, 1, 1 },
            };
            var result = CountSquares(matrix);
        }

        public int CountSquares(int[][] matrix)
        {
            var result = 0;
            var rowsCount = matrix.Length;
            var colsCount = matrix[0].Length;

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    if (i > 0 && j > 0 && matrix[i][j] == 1)
                        matrix[i][j] = 1 + Math.Min(matrix[i - 1][j - 1], Math.Min(matrix[i - 1][j], matrix[i][j - 1]));
                    result += matrix[i][j];
                }
            }

            return result;
        }

    }
}
