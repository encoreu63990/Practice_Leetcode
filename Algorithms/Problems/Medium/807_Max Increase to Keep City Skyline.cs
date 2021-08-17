using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/max-increase-to-keep-city-skyline/
    /// </summary>
    class _807_Max_Increase_to_Keep_City_Skyline
    {
        public void Run()
        {
            int[][] grid = new int[4][] {
                new int[] { 3, 0, 8, 4 },
                new int[] { 2, 4, 5, 7 },
                new int[] { 9, 2, 6, 3 },
                new int[] { 0, 3, 1, 0 },
            };
            var result = MaxIncreaseKeepingSkyline(grid);
        }

        public int MaxIncreaseKeepingSkyline(int[][] grid)
        {
            var result = 0;
            var rowsCount = grid.Count();
            var colsCount = grid[0].Count();
            var rowsMax = new int[rowsCount];
            var colsMax = new int[colsCount];


            for (int i = 0; i < rowsCount; i++)
            {
                rowsMax[i] = grid[i].Max();

                for (int j = 0; j < colsCount; j++)
                {
                    colsMax[j] = Math.Max(colsMax[j], grid[i][j]);
                }
            }

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    result += Math.Min(rowsMax[i], colsMax[j]) - grid[i][j];
                }
            }

            return result;
        }
    }
}
