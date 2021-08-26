using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/insert-into-a-binary-search-tree/
    /// </summary>
    class _701_Insert_into_a_Binary_Search_Tree
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null)
                return new TreeNode(val);

            if (val < root.val)
                root.left = InsertIntoBST(root.left, val);
            else
                root.right = InsertIntoBST(root.right, val);

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
