using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/find-a-corresponding-node-of-a-binary-tree-in-a-clone-of-that-tree/
    /// </summary>
    class _1379_Find_a_Corresponding_Node_of_a_Binary_Tree_in_a_Clone_of_That_Tree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            if (original == null)
                return null;

            if (original == target)
                return cloned;

            return GetTargetCopy(original.left, cloned.left, target) 
                   ?? GetTargetCopy(original.right, cloned.right, target);
        }
    }
}
