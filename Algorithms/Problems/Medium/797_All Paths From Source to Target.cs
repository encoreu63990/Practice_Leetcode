using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/all-paths-from-source-to-target/
    /// https://leetcode.com/problems/all-paths-from-source-to-target/discuss/1414803/C-Simple-Solution
    /// </summary>
    class _797_All_Paths_From_Source_to_Target
    {

        public void Run()
        {
            dict = new Dictionary<int, List<IList<int>>>();

            int[][] graph = new int[4][] {
                new int[] { 1, 2 },
                new int[] { 3 },
                new int[] { 3 },
                new int[] { },
            };

            var result = AllPathsSourceTarget(graph);
        }

        Dictionary<int, List<IList<int>>> dict = new Dictionary<int, List<IList<int>>>();
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph, int start = 0)
        {
            if (dict.ContainsKey(start))
                return dict[start];

            var result = new List<IList<int>>() { };

            if (start + 1 == graph.Length)
            {
                result.Add(new List<int>() { start });
                dict[start] = result;
                return result;
            }

            foreach (var item in graph[start])
            {
                var subResult = AllPathsSourceTarget(graph, item).Select(c => c.ToList()).ToList();
                subResult.ForEach(list => list.Insert(0, start));
                result.AddRange(subResult);
            }

            dict[start] = result;
            return result;
        }
    }
}
