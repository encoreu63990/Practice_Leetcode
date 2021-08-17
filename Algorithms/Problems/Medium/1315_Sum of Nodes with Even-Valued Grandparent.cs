using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/sum-of-nodes-with-even-valued-grandparent/
    /// https://leetcode.com/problems/sum-of-nodes-with-even-valued-grandparent/discuss/1408167/C
    /// </summary>
    class _1315_Sum_of_Nodes_with_Even_Valued_Grandparent
    {
        public int SumEvenGrandparent(TreeNode current, TreeNode parent = null, TreeNode grandparent = null)
        {
            if (current == null)
                return 0;

            var currentValue = 0;
            if (grandparent != null && grandparent.val % 2 == 0)
                currentValue = current.val;

            return currentValue + SumEvenGrandparent(current.left, current, parent) + SumEvenGrandparent(current.right, current, parent);
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

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
