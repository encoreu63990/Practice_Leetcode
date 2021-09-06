using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-pruning/
    /// </summary>
    class _814_Binary_Tree_Pruning
    {
        public TreeNode PruneTree(TreeNode root)
        {
            if (root == null)
                return null;

            root.left = PruneTree(root.left);
            root.right = PruneTree(root.right);

            if (root.val == 0 && root.left == null && root.right == null)
                return null;

            return root;
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
