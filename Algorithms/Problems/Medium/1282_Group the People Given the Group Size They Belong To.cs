using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/group-the-people-given-the-group-size-they-belong-to/
    /// </summary>
    class _1282_Group_the_People_Given_the_Group_Size_They_Belong_To
    {
        public void Run()
        {
            var groupSizes = new int[] { 3, 3, 3, 3, 3, 1, 3 };
            var result = GroupThePeople(groupSizes);
        }

        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            IList<IList<int>> result = new List<IList<int>>();

            var dict = new Dictionary<int, List<int>>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                if (!dict.ContainsKey(groupSizes[i]))
                {
                    dict.Add(groupSizes[i], new List<int>());
                }
                var list = dict[groupSizes[i]];
                list.Add(i);

                if (groupSizes[i] == list.Count())
                {
                    result.Add(list);
                    dict[groupSizes[i]] = new List<int>();
                }
            }

            return result;
        }
    }
}
