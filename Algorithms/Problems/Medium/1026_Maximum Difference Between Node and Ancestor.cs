using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/
    /// https://leetcode.com/problems/maximum-difference-between-node-and-ancestor/discuss/1508116/C-Solution
    /// </summary>
    public class _1026_Maximum_Difference_Between_Node_and_Ancestor
    {
        public void Run()
        {
            TreeNode root = new TreeNode(
                8,
                new TreeNode(3,
                    new TreeNode(1),
                    new TreeNode(6)),
                new TreeNode(10,
                    null,
                    new TreeNode(14))
            );
            var solution = new Solution();
            var result = solution.MaxAncestorDiff(root);
        }

        public class Solution
        {
            public int MaxAncestorDiff(TreeNode root)
            {
                return MaxAncestorDiff(root, root.val, root.val);
            }

            private int MaxAncestorDiff(TreeNode root, int min, int max)
            {
                if (root == null)
                    return max - min;

                var nextMin = Math.Min(min, root.val);
                var nextMax = Math.Max(max, root.val);

                var leftMaxDiff = MaxAncestorDiff(root.left, nextMin, nextMax);
                var rightMaxDiff = MaxAncestorDiff(root.right, nextMin, nextMax);

                var currentMaxDiff = Math.Max(nextMax - nextMin, Math.Max(leftMaxDiff, rightMaxDiff));
                return currentMaxDiff;
            }
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}
