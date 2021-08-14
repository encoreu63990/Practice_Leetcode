using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/decompress-run-length-encoded-list/
    /// </summary>
    class _1313_Decompress_Run_Length_Encoded_List
    {
        public int[] DecompressRLElist(int[] nums)
        {
            List<int> result = new List<int>();

            for (int i = 1; i < nums.Length; i += 2)
            {
                for (int j = 0; j < nums[i - 1]; j++)
                {
                    result.Add(nums[i]);
                }
            }

            return result.ToArray();
        }
    }
}
