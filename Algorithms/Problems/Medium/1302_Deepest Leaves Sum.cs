using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/deepest-leaves-sum/
    /// </summary>
    class _1302_Deepest_Leaves_Sum
    {
        public void Run()
        {
            // left
            TreeNode l_l_l = new TreeNode(7, null, null);
            TreeNode l_l = new TreeNode(4, l_l_l, null);
            TreeNode l_r = new TreeNode(5, null, null);
            TreeNode l = new TreeNode(2, l_l, l_r);
            // right
            TreeNode r_r_r = new TreeNode(8, null, null);
            TreeNode r_r = new TreeNode(6, null, r_r_r);
            TreeNode r = new TreeNode(3, null, r_r);
            // root
            TreeNode root = new TreeNode(1, l, r);

            Console.WriteLine(DeepestLeavesSum(root));
        }

        public int DeepestLeavesSum(TreeNode root)
        {
            var deepestNumber = FindDeepestNumber(root);
            var deepestSum = FindDeepestSum(root, 0, deepestNumber);
            return deepestSum;
        }

        public int FindDeepestNumber(TreeNode node)
        {
            if ((node == null) || (node.left == null && node.right == null))
                return 0;

            int leftMax = FindDeepestNumber(node.left);
            int rightMax = FindDeepestNumber(node.right);

            return 1 + (leftMax > rightMax ? leftMax : rightMax);
        }

        public int FindDeepestSum(TreeNode node, int currentNumber, int targetNumber)
        {
            if (node == null)
                return 0;

            if (currentNumber == targetNumber)
                return node.val;

            return FindDeepestSum(node.left, currentNumber + 1, targetNumber)
                   + FindDeepestSum(node.right, currentNumber + 1, targetNumber);
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
