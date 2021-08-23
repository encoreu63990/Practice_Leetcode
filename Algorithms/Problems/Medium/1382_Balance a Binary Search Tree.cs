using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/balance-a-binary-search-tree/
    /// https://leetcode.com/problems/balance-a-binary-search-tree/discuss/1420936/C-Simple-Solution
    /// </summary>
    class _1382_Balance_a_Binary_Search_Tree
    {
        public void Run()
        {
            var root = new TreeNode(2, new TreeNode(1), new TreeNode(3));
            var result = BalanceBST(root);
        }

        public TreeNode BalanceBST(TreeNode root)
        {
            var list = new List<int>();

            Traverse(root, list);
            TreeNode result = Construct(list, 0, list.Count - 1);

            return result;
        }

        public void Traverse(TreeNode node, List<int> list)
        {
            if (node == null)
                return;

            Traverse(node.left, list);
            list.Add(node.val);
            Traverse(node.right, list);
        }

        public TreeNode Construct(List<int> list, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
                return null;

            if (startIndex == endIndex)
                return new TreeNode(list[startIndex]);

            var node = new TreeNode();
            var medianIndex = (endIndex + startIndex) / 2;

            node.val = list[medianIndex];
            node.left = Construct(list, startIndex, medianIndex - 1);
            node.right = Construct(list, medianIndex + 1, endIndex);

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
