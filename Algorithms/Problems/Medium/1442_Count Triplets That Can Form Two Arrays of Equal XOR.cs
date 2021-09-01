using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/count-triplets-that-can-form-two-arrays-of-equal-xor/
    /// 1442_Count Triplets That Can Form Two Arrays of Equal XOR
    /// </summary>
    class _1442_Count_Triplets_That_Can_Form_Two_Arrays_of_Equal_XOR
    {
        public void Run()
        {
            var arr = new int[] { 2, 3, 1, 6, 7 };
            var result = CountTriplets(arr);
        }

        public int CountTriplets(int[] arr)
        {
            int count = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] ^ arr[i];
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j; k < arr.Length; k++)
                    {
                        var a = arr[j - 1] ^ (i > 0 ? arr[i - 1] : 0);
                        var b = arr[k] ^ arr[j - 1];

                        if (a == b)
                            count++;
                    }
                }
            }
            return count;
        }
    }
}


