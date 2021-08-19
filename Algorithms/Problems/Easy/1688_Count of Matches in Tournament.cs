using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/count-of-matches-in-tournament/
    /// </summary>
    class _1688_Count_of_Matches_in_Tournament
    {
        public int NumberOfMatches(int n)
        {
            var result = 0;

            while (n > 1)
            {
                var team1 = n / 2;
                var team2 = n - team1;
                n = Math.Max(team1, team2);
                result +=Math.Min(team1, team2);
            }

            return result;
        }
    }
}
