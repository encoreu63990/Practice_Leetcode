using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/next-permutation/
    /// https://leetcode.com/problems/next-permutation/discuss/1437791/C-Solution
    /// </summary>
    class _31_Next_Permutation
    {
        public void Run()
        {
            var nums = new int[] { 3, 2, 1 };
            NextPermutation(nums);
            Console.WriteLine(string.Join(", ", nums));
        }

        public void NextPermutation(int[] nums)
        {
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] < nums[i + 1])
                {
                    var current = nums[i];
                    var next = nums.Skip(i + 1).Where(c => c > current).Min();
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] == next)
                        {
                            Swap(nums, i, j);
                            break;
                        }
                    }
                    Array.Sort(nums, i + 1, nums.Length - i - 1);
                    return;
                }
            }

            Array.Sort(nums);
        }

        public void Swap(int[] array, int i, int j)
        {
            int tmp = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }
    }
}