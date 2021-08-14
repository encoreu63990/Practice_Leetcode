using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/subtract-the-product-and-sum-of-digits-of-an-integer/
    /// </summary>
    class _1281_Subtract_the_Product_and_Sum_of_Digits_of_an_Integer
    {
        public int SubtractProductAndSum(int n)
        {
            var product = 1;
            var sum = 0;
            while (n != 0)
            {
                var remainder = n % 10;
                product *= remainder;
                sum += remainder;
                n /= 10;
            }
            return product - sum;
        }
    }
}
