using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Hard
{
    /// <summary>
    /// https://leetcode.com/problems/reducing-dishes/
    /// https://leetcode.com/problems/reducing-dishes/discuss/1439928/C-Solution
    /// </summary>
    class _1402_Reducing_Dishes
    {
        public void Run()
        {
            var satisfaction = new int[] { -1, -8, 0, 5, -9 };
            var result = MaxSatisfaction(satisfaction);
        }

        public int MaxSatisfaction(int[] satisfaction)
        {
            Array.Sort(satisfaction);
            int rowsCount = satisfaction.Length;
            int[][] table = new int[rowsCount][];

            table[0] = satisfaction.ToArray();
            for (int i = 1; i < rowsCount; i++)
            {
                table[0][i] = Math.Max(table[0][i], table[0][i - 1]);
            }

            for (int i = 1; i < rowsCount; i++)
            {
                table[i] = new int[rowsCount];
                table[i][i] = table[i - 1][i - 1] + satisfaction[i] * (i + 1);
                for (int j = i + 1; j < rowsCount; j++)
                {
                    table[i][j] = Math.Max(table[i][j - 1], table[i - 1][j - 1] + satisfaction[j] * (i + 1));
                }
            }

            return table.Select(c => c.Max()).Max();
        }
    }
}


