using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/find-elements-in-a-contaminated-binary-tree/
    /// https://leetcode.com/problems/find-elements-in-a-contaminated-binary-tree/discuss/1424886/C-Routing-Solution
    /// </summary>
    class _1261_Find_Elements_in_a_Contaminated_Binary_Tree
    {
        public class FindElements
        {
            TreeNode _root = null;
            Func<TreeNode, TreeNode> RouteLeft = (node) => node.left;
            Func<TreeNode, TreeNode> RouteRight = (node) => node.right;

            public FindElements(TreeNode root)
            {
                this._root = root;
            }

            public bool Find(int target)
            {
                var routingStack = new Stack<Func<TreeNode, TreeNode>>();

                while (target != 0)
                {
                    if (target % 2 == 1)
                        routingStack.Push(RouteLeft);
                    else
                        routingStack.Push(RouteRight);

                    target = (target + 1) / 2 - 1;
                }


                var node = _root;

                while (node != null)
                {
                    if (!routingStack.Any())
                        return true;

                    var routingDirection = routingStack.Pop();
                    node = routingDirection(node);
                }

                return false;
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
}
