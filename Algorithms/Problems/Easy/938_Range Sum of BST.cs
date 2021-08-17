using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/range-sum-of-bst/
    /// </summary>
    class _938_Range_Sum_of_BST
    {
        public int RangeSumBST(TreeNode current, int low, int high)
        {
            if (current == null)
                return 0;

            bool inclusiveRange = current.val >= low && current.val <= high;
            return (inclusiveRange ? current.val : 0) 
                   + RangeSumBST(current.left, low, high) + RangeSumBST(current.right, low, high);
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
