using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    class _1486_XOR_Operation_in_an_Array
    {
        public int XorOperation(int n, int start)
        {
            int result = 0;

            for (int i=0; i<n; i++)
            {
                result ^= start + 2 * i;
            }

            return result;
        }
    }
}
