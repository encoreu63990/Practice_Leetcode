using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/binary-search-tree-to-greater-sum-tree/
    /// </summary>
    class _1038_Binary_Search_Tree_to_Greater_Sum_Tree
    {
        int sum = 0;
        public TreeNode BstToGst(TreeNode root)
        {
            if (root == null)
                return root;

            if (root.right != null)
                root.right = BstToGst(root.right);

            int value = root.val;
            root.val += sum;
            sum += value;

            if (root.left != null)
                root.left = BstToGst(root.left);

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
