using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/queries-on-a-permutation-with-key/
    /// </summary>
    class _1409_Queries_on_a_Permutation_With_Key
    {
        public int[] ProcessQueries(int[] queries, int m)
        {
            var result = new int[queries.Length];
            var list = new List<int>();

            for (int i = 1; i <= m; i++)
                list.Add(i);

            for(int i=0; i < queries.Length; i++)
            {
                var item = queries[i];
                var index = list.IndexOf(item);
                result[i] = index;
                list.RemoveAt(index);
                list.Insert(0, item);
            }

            return result;
        }
    }
}
