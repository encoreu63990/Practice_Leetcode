using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problemset/algorithms/?page=3&sorting=W3sic29ydE9yZGVyIjoiREVTQ0VORElORyIsIm9yZGVyQnkiOiJBQ19SQVRFIn1d
    /// </summary>
    class _1557_Minimum_Number_of_Vertices_to_Reach_All_Nodes
    {
        public void Run()
        {
            // Expect [0, 3]
            //var n = 6;
            //var edges = new List<IList<int>> {
            //    new List<int>{ 0, 1 },
            //    new List<int>{ 0, 2 },
            //    new List<int>{ 2, 5 },
            //    new List<int>{ 3, 4 },
            //    new List<int>{ 4, 2 },
            //};

            var n = 5;
            var edges = new List<IList<int>> {
                new List<int>{ 1, 3 },
                new List<int>{ 2, 0 },
                new List<int>{ 2, 3 },
                new List<int>{ 1, 0 },
                new List<int>{ 4, 1 },
                new List<int>{ 0, 3 },
            };

            var result = FindSmallestSetOfVertices(n, edges);
        }

        public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
        {
            List<int> result = new List<int>();
            bool[] array = new bool[n];

            foreach (var edge in edges)
            {
                array[edge[1]] = true;
            }

            for (int i = 0; i < n; i++)
            {
                if (array[i] == false)
                    result.Add(i);
            }

            return result;
        }
    }
}
