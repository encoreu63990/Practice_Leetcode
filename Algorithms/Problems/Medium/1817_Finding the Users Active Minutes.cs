using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/finding-the-users-active-minutes/
    /// </summary>
    class _1817_Finding_the_Users_Active_Minutes
    {
        public void Run()
        {
            var logs = new int[][] {
                new int[] { 0, 5 },
                new int[] { 1, 2 },
                new int[] { 0, 2 },
                new int[] { 0, 5 },
                new int[] { 1, 3 },
            };

            var result = FindingUsersActiveMinutes(logs, 5);
        }

        public int[] FindingUsersActiveMinutes(int[][] logs, int k)
        {
            var result = new int[k];
            var dict = new Dictionary<int, List<int>>();

            foreach (var log in logs)
            {
                var userId = log[0];
                var minutes = log[1];

                if (!dict.ContainsKey(userId))
                    dict.Add(userId, new List<int>());

                var list = dict[userId];
                if (!list.Exists(c => c == minutes))
                    list.Add(minutes);
            }

            foreach (var list in dict.Values)
            {
                result[list.Count - 1]++;
            }

            return result;
        }
    }
}
