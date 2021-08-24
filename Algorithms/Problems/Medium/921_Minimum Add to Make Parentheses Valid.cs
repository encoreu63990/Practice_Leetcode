using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-add-to-make-parentheses-valid/
    /// https://leetcode.com/problems/minimum-add-to-make-parentheses-valid/discuss/1423023/C-Solution
    /// </summary>
    class _921_Minimum_Add_to_Make_Parentheses_Valid
    {
        public int MinAddToMakeValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (var c in s)
            {
                if (c == ')' && stack.Any() && stack.Peek() == '(')
                    stack.Pop();
                else
                    stack.Push(c);
            }

            return stack.Count;
        }
    }
}
