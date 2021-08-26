using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/score-after-flipping-matrix/
    /// https://leetcode.com/problems/score-after-flipping-matrix/discuss/1427078/C-Solution
    /// </summary>
    class _861_Score_After_Flipping_Matrix
    {
        public void Run()
        {
            var grid = new int[3][] {
                new int[]{ 0, 0, 1, 1 },
                new int[]{ 1, 0, 1, 0 },
                new int[]{ 1, 1, 0, 0 },
            };

            var result = MatrixScore(grid);
        }

        public int MatrixScore(int[][] grid)
        {
            int result = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                if (grid[i][0] == 0)
                {
                    for (int j = 0; j < grid[0].Length; j++)
                    {
                        grid[i][j] = 1 - grid[i][j];
                    }
                }
            }

            for (int j = 0; j < grid[0].Length; j++)
            {
                result *= 2;

                int counter = 0;
                for (int i = 0; i < grid.Length; i++)
                {
                    counter += grid[i][j] == 0 ? 1 : 0;
                }

                result += Math.Max(counter, grid.Length - counter);
            }

            return result;
        }
    }
}
