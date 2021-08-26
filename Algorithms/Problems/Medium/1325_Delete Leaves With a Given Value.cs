using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/delete-leaves-with-a-given-value/
    /// </summary>
    class _1325_Delete_Leaves_With_a_Given_Value
    {
        public TreeNode RemoveLeafNodes(TreeNode root, int target)
        {
            if (root == null)
                return null;

            root.left = RemoveLeafNodes(root.left, target);
            root.right = RemoveLeafNodes(root.right, target);

            if (root.val == target && root.left == null && root.right == null)
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
