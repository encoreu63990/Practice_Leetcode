using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/path-in-zigzag-labelled-binary-tree/
    /// https://leetcode.com/problems/path-in-zigzag-labelled-binary-tree/discuss/1428683/C-The-Simplest-Solution
    /// </summary>
    class _1104_Path_In_Zigzag_Labelled_Binary_Tree
    {
        public void Run()
        {
            var result = PathInZigZagTree(26);
        }

        public IList<int> PathInZigZagTree(int label)
        {
            Stack<int> stack = new Stack<int>();

            while (label > 0)
            {
                stack.Push(label);

                var level = (int)(Math.Log(label, 2) + 1);

                var currentLevelMinimumNumber = (int)(Math.Pow(2, level - 1));
                var currentLevelDistance = label - currentLevelMinimumNumber;
                var parentLevelMaximumNumber = currentLevelMinimumNumber - 1;
                var parentLevelDistance = currentLevelDistance / 2;
                var parentNumber = parentLevelMaximumNumber - parentLevelDistance;

                label = parentNumber;

                // label = 2^layerNumber - 2 * (ANS - 2^(layerNumber-2)) - 1
                // ANS = (2^layerNumber - 1 - label) / 2 + 2^(layerNumber-2)
                // label = (int)((Math.Pow(2, layerNumber) - 1 - label) / 2 + Math.Pow(2, layerNumber - 2));
            }

            return stack.ToList();
        }
    }
}
