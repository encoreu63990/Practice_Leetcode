using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/find-center-of-star-graph/
    /// </summary>
    class _1791_Find_Center_of_Star_Graph
    {
        public int FindCenter(int[][] edges)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var pair in edges)
            {
                var point1 = pair[0];
                var point2 = pair[1];

                if (!dict.ContainsKey(point1))
                    dict.Add(point1, 0);
                if (!dict.ContainsKey(point2))
                    dict.Add(point2, 0);

                dict[point1]++;
                dict[point2]++;

                if( dict[point1] != dict[point2])
                {
                    return dict[point1] > dict[point2] ? point1 : point2;
                }
            }

            return 0;
        }
    }
}
