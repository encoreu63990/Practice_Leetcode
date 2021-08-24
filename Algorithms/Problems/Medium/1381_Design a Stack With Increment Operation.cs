using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/design-a-stack-with-increment-operation/
    /// https://leetcode.com/problems/design-a-stack-with-increment-operation/discuss/1422407/C-Solution
    /// </summary>
    class _1381_Design_a_Stack_With_Increment_Operation
    {
        public class CustomStack
        {
            private int[] _array;
            private int index;


            public CustomStack(int maxSize)
            {
                _array = new int[maxSize];
                index = -1;
            }

            public void Push(int x)
            {
                if (index + 1 < _array.Length)
                    _array[++index] = x;
            }

            public int Pop()
            {
                if (index >= 0)
                    return _array[index--];
                return -1;
            }

            public void Increment(int k, int val)
            {
                for (int i = 0; i < Math.Min(k, _array.Length); i++)
                    _array[i] += val;
            }
        }
    }
}
