using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/matrix-block-sum/
    /// https://leetcode.com/problems/matrix-block-sum/discuss/1428498/C-Solution
    /// </summary>
    class _1314_Matrix_Block_Sum
    {
        public void Run()
        {
            var mat = new int[3][] {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
            };
            MatrixBlockSum(mat, 1);
        }

        public int[][] MatrixBlockSum(int[][] mat, int k)
        {
            Construct(mat);
            return CalculateBlockSum(mat, k);
        }

        public void Construct(int[][] mat)
        {
            int rowsCount = mat.Length;
            var colsCount = mat[0].Length;

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    mat[i][j] = mat[i][j] + GetValue(mat, i - 1, j) + GetValue(mat, i, j - 1) - GetValue(mat, i - 1, j - 1);
                }
            }
        }

        public int[][] CalculateBlockSum(int[][] mat, int k)
        {
            int rowsCount = mat.Length;
            var colsCount = mat[0].Length;
            var result = new int[rowsCount][];

            for (int i = 0; i < rowsCount; i++)
            {
                result[i] = new int[colsCount];
                for (int j = 0; j < colsCount; j++)
                {
                    int left = GetValue(mat, i + k, j - k - 1);
                    var top = GetValue(mat, i - k - 1, j + k);
                    var leftTop = GetValue(mat, i - k - 1, j - k - 1);
                    result[i][j] = GetValue(mat, i + k, j + k) - left - top + leftTop;
                }
            }

            return result;
        }

        public int GetValue(int[][] mat, int i, int j)
        {
            if (i < 0 || j < 0)
                return 0;

            i = i >= mat.Length ? mat.Length - 1 : i;
            j = j >= mat[0].Length ? mat[0].Length - 1 : j;

            return mat[i][j];
        }
    }
}
