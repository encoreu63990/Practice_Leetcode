using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/queries-on-number-of-points-inside-a-circle/
    /// 
    /// Case 1:
    /// Input: points = [[1,3],[3,3],[5,3],[2,2]], queries = [[2,3,1],[4,3,1],[1,1,2]]
    /// Output: [3,2,2]
    /// 
    /// CountPoints(new int[4][] { new int[] { 1, 3 }, new int[] { 3, 3 }, new int[] { 5, 3 }, new int[] { 2, 2 } }, new int[3][] { new int[] { 2, 3, 1 }, new int[] { 4, 3, 1 }, new int[] { 1, 1, 2 } });
    /// </summary>
    public class _1828_Queries_on_Number_of_Points_Inside_a_Circle
    {
        public int[] CountPoints(int[][] points, int[][] queries)
        {
            int index = 0;
            int[] result = new int[queries.Length];
            foreach (var query in queries)
            {
                int x = query[0];
                int y = query[1];
                int r = query[2];

                result[index++] = points.Where(point =>
                    Math.Sqrt(Math.Pow(point[0] - x, 2) + Math.Pow(point[1] - y, 2)) <= r
                ).Count();
            }
            return result;
        }
    }
}
