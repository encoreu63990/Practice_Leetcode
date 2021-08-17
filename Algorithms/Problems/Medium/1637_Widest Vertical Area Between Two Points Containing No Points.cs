using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/widest-vertical-area-between-two-points-containing-no-points/
    /// </summary>
    class _1637_Widest_Vertical_Area_Between_Two_Points_Containing_No_Points
    {
        public void Run()
        {
            int[][] points = new int[4][] {
                new int[] { 8, 7 },
                new int[] { 9, 9 },
                new int[] { 7, 4 },
                new int[] { 9, 7 },
            };

            MaxWidthOfVerticalArea(points);
        }

        public int MaxWidthOfVerticalArea(int[][] points)
        {
            var array = points.OrderBy(c => c[0]).ToArray();
            var max = 0;

            for(int i=1; i<array.Count(); i++)
            {
                max = Math.Max(max, array[i][0] - array[i - 1][0]);
            }
            
            return max;
        }
    }
}
