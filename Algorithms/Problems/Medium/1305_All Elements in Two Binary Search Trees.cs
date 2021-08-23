using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/all-elements-in-two-binary-search-trees/
    /// https://leetcode.com/problems/all-elements-in-two-binary-search-trees/discuss/1420797/C-Simple-Solution
    /// </summary>
    class _1305_All_Elements_in_Two_Binary_Search_Trees
    {
        public void Run()
        {
            TreeNode root1 = new TreeNode(2, new TreeNode(1), new TreeNode(4));
            TreeNode root2 = new TreeNode(1, new TreeNode(0), new TreeNode(3));
            var result = GetAllElements(root1, root2);
        }

        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            var result = new List<int>();
            var queue1 = new Queue<int>();
            var queue2 = new Queue<int>();

            Traverse(root1, queue1);
            Traverse(root2, queue2);

            while (queue1.Any() || queue2.Any())
            {
                if (!queue1.Any())
                {
                    result.Add(queue2.Dequeue());
                }
                else if (!queue2.Any())
                {
                    result.Add(queue1.Dequeue());
                }
                else
                {
                    var item = queue1.Peek() < queue2.Peek() ? queue1.Dequeue() : queue2.Dequeue();
                    result.Add(item);
                }
            }

            return result;
        }

        public void Traverse(TreeNode node, Queue<int> queue)
        {
            if (node == null)
                return;

            Traverse(node.left, queue);
            queue.Enqueue(node.val);
            Traverse(node.right, queue);
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
