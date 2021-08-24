using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/arithmetic-subarrays/
    /// </summary>
    class _1630_Arithmetic_Subarrays
    {
        public void Run()
        {
            var nums = new int[] { 4, 6, 5, 9, 3, 7 };
            var l = new int[] { 0, 0, 2 };
            var r = new int[] { 2, 3, 5 };
            CheckArithmeticSubarrays(nums, l, r);
        }

        public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
        {
            var result = new bool[l.Length];

            for (int i = 0; i < l.Length; i++)
            {
                var tmpNums = new int[r[i] - l[i] + 1];
                Array.Copy(nums, l[i], tmpNums, 0, tmpNums.Length);
                Array.Sort(tmpNums);

                var isArithmeticSequences = true;
                for (int j = 2; j < tmpNums.Length; j++)
                {
                    if (tmpNums[1] - tmpNums[0] != tmpNums[j] - tmpNums[j - 1])
                        isArithmeticSequences = false;
                }
                result[i] = isArithmeticSequences;
            }

            return result;
        }

    }
}
