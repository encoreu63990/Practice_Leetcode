using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/partition-labels/
    /// https://leetcode.com/problems/partition-labels/discuss/1420699/C-Solution
    /// </summary>
    class _763_Partition_Labels
    {
        public void Run()
        {
            var s = "caedbdedda";
            // Expected [1,9]
            var result = PartitionLabels(s);
        }

        public IList<int> PartitionLabels(string s)
        {
            var result = new List<int>();
            var lastIndex = 0;
            var startIndex = 0;

            for (int i = 0; i < s.Length; i++)
            {
                lastIndex = Math.Max(lastIndex, s.LastIndexOf(s[i]));
                if (i == lastIndex)
                {
                    result.Add(lastIndex - startIndex + 1);
                    startIndex = i + 1;
                }
            }

            return result;
        }
    }
}
