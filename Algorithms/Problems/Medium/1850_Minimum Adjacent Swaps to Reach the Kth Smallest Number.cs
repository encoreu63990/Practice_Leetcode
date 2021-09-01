using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-adjacent-swaps-to-reach-the-kth-smallest-number/
    /// https://leetcode.com/problems/minimum-adjacent-swaps-to-reach-the-kth-smallest-number/discuss/1437775/C-Solution
    /// </summary>
    class _1850_Minimum_Adjacent_Swaps_to_Reach_the_Kth_Smallest_Number
    {
        public void Run()
        {
            var num = "00123";
            var k = 1;
            var result = GetMinSwaps(num, k);
        }

        public int GetMinSwaps(string num, int k)
        {
            int counter = 0;
            var numArray = num.ToArray().Select(c => c - '0').ToArray();
            var lastArray = num.ToArray().Select(c => c - '0').ToArray();

            for (int i = 0; i < k; i++)
            {
                NextPermutation(lastArray);
            }

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] != lastArray[i])
                {
                    var index = Array.IndexOf(numArray, lastArray[i], i + 1);
                    for (int j = index; j > i; j--)
                    {
                        counter++;
                        Swap(numArray, j, j - 1);
                    }
                }
            }

            return counter;
        }

        public void NextPermutation(int[] array)
        {
            for (int i = array.Length - 2; i >= 0; i--)
            {
                if (array[i] < array[i + 1])
                {
                    var current = array[i];
                    var next = array.Skip(i + 1).Where(c => c > current).Min();
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] == next)
                        {
                            Swap(array, i, j);
                            break;
                        }
                    }
                    Array.Sort(array, i + 1, array.Length - i - 1);
                    return;
                }
            }
        }


        public void Swap(int[] array, int i, int j)
        {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}