using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/count-good-nodes-in-binary-tree/
    /// https://leetcode.com/problems/count-good-nodes-in-binary-tree/discuss/1439738/C-Solution
    /// </summary>
    class _1448_Count_Good_Nodes_in_Binary_Tree
    {
        public int GoodNodes(TreeNode root)
        {
            return GoodNodes(root, root.val);
        }

        public int GoodNodes(TreeNode node ,int max)
        {
            if (node == null)
                return 0;

            var isGoodNode = node.val >= max;
            var nextMax = isGoodNode ? node.val : max;

            return (isGoodNode ? 1 : 0)
                    + GoodNodes(node.left, nextMax)
                    + GoodNodes(node.right, nextMax);
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