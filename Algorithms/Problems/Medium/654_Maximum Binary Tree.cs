using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-binary-tree/
    /// https://leetcode.com/problems/maximum-binary-tree/discuss/1412421/C-Easy-Solution
    /// </summary>
    class _654_Maximum_Binary_Tree
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            if (nums.Length == 0)
                return null;

            var index = 0;
            var max = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    index = i;
                    max = nums[i];
                }
            }

            var node = new TreeNode(max);
            node.left = ConstructMaximumBinaryTree(nums.Take(index).ToArray());
            node.right = ConstructMaximumBinaryTree(nums.Skip(index + 1).ToArray());

            return node;
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
