using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/construct-binary-search-tree-from-preorder-traversal/
    /// https://leetcode.com/problems/construct-binary-search-tree-from-preorder-traversal/discuss/1415071/C-Simple-Solution
    /// </summary>
    class _1008_Construct_Binary_Search_Tree_from_Preorder_Traversal
    {
        public void Run()
        {
            var preorder = new int[] { 8, 5, 1, 7, 10, 12 };
            var tree = BstFromPreorder(preorder);
        }

        public TreeNode BstFromPreorder(int[] preorder)
        {
            TreeNode root = new TreeNode(preorder[0]);
            foreach (int value in preorder)
                InsertValue(root, value);
            return root;
        }

        public TreeNode InsertValue(TreeNode node, int value)
        {
            if (node == null)
                return new TreeNode(value);

            if (value < node.val)
                node.left = InsertValue(node.left, value);

            if (value > node.val)
                node.right = InsertValue(node.right, value);

            return node;
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
