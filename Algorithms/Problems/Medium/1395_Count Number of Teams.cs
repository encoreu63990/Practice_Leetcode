using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/count-number-of-teams/
    /// https://leetcode.com/problems/count-number-of-teams/discuss/1447198/C-Solution
    /// </summary>
    class _1395_Count_Number_of_Teams
    {
        public void Run()
        {
            var rating = new int[] { 2, 5, 3, 4, 1 };
            var result = NumTeams(rating);
        }

        public int NumTeams(int[] rating)
        {
            var left = rating.Take(1).ToList();
            var right = rating.Skip(1).ToList();
            var counter = 0;

            while (right.Count > 1)
            {
                var current = right.First();
                right.RemoveAt(0);

                var increasingNumber = left.Where(c => c < current).Count() * right.Where(c => c > current).Count();
                var decreasingNumber = left.Where(c => c > current).Count() * right.Where(c => c < current).Count();

                counter += increasingNumber + decreasingNumber;
                left.Add(current);
            }

            return counter;
        }
    }
}