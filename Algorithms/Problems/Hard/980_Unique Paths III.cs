using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Hard
{
    /// <summary>
    /// https://leetcode.com/problemset/algorithms/?page=3&sorting=W3sic29ydE9yZGVyIjoiREVTQ0VORElORyIsIm9yZGVyQnkiOiJBQ19SQVRFIn1d
    /// https://leetcode.com/problems/unique-paths-iii/discuss/1422377/C
    /// </summary>
    class _980_Unique_Paths_III
    {
        public void Run()
        {
            // Expect 2
            //var grid = new int[3][] {
            //    new int[] { 1, 0, 0, 0 },
            //    new int[] { 0, 0, 0, 0 },
            //    new int[] { 0, 0, 2, -1 },
            //};

            // Expect 4
            var grid = new int[3][] {
                new int[] { 1, 0, 0, 0 },
                new int[] { 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 2 },
            };
            var result = UniquePathsIII(grid);
        }

        public int UniquePathsIII(int[][] grid)
        {
            var squareInfo = GetSquareInfo(grid);
            var startCoordinate = squareInfo.Item1;
            var emptySquaresCount = squareInfo.Item2 + 1;
            grid[startCoordinate.Item1][startCoordinate.Item2] = 0;

            int result = Search(grid, startCoordinate.Item1, startCoordinate.Item2, 0, emptySquaresCount);
            return result;
        }

        public Tuple<Tuple<int, int>, int> GetSquareInfo(int[][] grid)
        {
            Tuple<int, int> startCoordinate = null;
            int emptySquaresCount = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        emptySquaresCount++;
                    }
                    else if (grid[i][j] == 1)
                    {
                        startCoordinate = new Tuple<int, int>(i, j);
                    }
                }
            }

            return new Tuple<Tuple<int, int>, int>(startCoordinate, emptySquaresCount);
        }

        public int Search(int[][] grid, int i, int j, int counter, int emptySquaresCount)
        {
            if (i == grid.Length || j == grid[0].Length || i < 0 || j < 0)
                return 0;

            if (grid[i][j] == -1)
                return 0;

            if (grid[i][j] == 2)
            {
                if (emptySquaresCount == counter)
                    return 1;
                else
                    return 0;
            }

            grid[i][j] = -1;
            var left = Search(grid, i, j - 1, counter + 1, emptySquaresCount);
            var right = Search(grid, i, j + 1, counter + 1, emptySquaresCount);
            var up = Search(grid, i - 1, j, counter + 1, emptySquaresCount);
            var down = Search(grid, i + 1, j, counter + 1, emptySquaresCount);
            grid[i][j] = 0;

            return left + right + up + down;
        }
    }
}
