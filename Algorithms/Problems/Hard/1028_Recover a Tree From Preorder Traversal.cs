using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Hard
{
    /// <summary>
    /// https://leetcode.com/problems/recover-a-tree-from-preorder-traversal/
    /// https://leetcode.com/problems/recover-a-tree-from-preorder-traversal/discuss/1447320/C-Solution
    /// </summary>
    class _1028_Recover_a_Tree_From_Preorder_Traversal
    {
        public void Run()
        {
            var traversal = "1-2--3--4-5--6--7";
            var result = RecoverFromPreorder(traversal);
        }

        public TreeNode RecoverFromPreorder(string traversal)
        {
            return Build(traversal.ToArray().ToList());
        }

        public TreeNode Build(List<char> array, int level = 0)
        {
            if (!array.Any())
                return null;

            var currentLevel = 0;
            for (int i = 0; i < array.Count && array[i] == '-'; i++)
            {
                currentLevel++;
            }

            if (level != currentLevel)
                return null;

            TreeNode node = new TreeNode();

            // Remove dash
            array.RemoveRange(0, level);

            // Get value
            var index = array.IndexOf('-');
            index = index < 0 ? array.Count : index;
            var value = Convert.ToInt32(string.Join("", array.Take(index)));

            // Remove value
            array.RemoveRange(0, index);

            node.val = value;
            node.left = Build(array, level + 1);
            node.right = Build(array, level + 1);

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

