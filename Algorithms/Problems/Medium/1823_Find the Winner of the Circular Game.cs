using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-winner-of-the-circular-game/
    /// https://leetcode.com/problems/find-the-winner-of-the-circular-game/discuss/1438405/C-Solution
    /// </summary>
    class _1823_Find_the_Winner_of_the_Circular_Game
    {
        public void Run()
        {
            var n = 5;
            var k = 2;
            var result = FindTheWinner(n, k);
        }

        public int FindTheWinner(int n, int k)
        {
            int index = 0;
            List<int> list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                list.Add(i);
            }

            while (list.Count > 1)
            {
                index = index + k - 1;
                index = index % list.Count;
                list.RemoveAt(index);
            }

            return list.First();
        }
    }
}