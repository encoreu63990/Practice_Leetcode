using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/decode-xored-array/
    /// </summary>
    class _1720_Decode_XORed_Array
    {
        public int[] Decode(int[] encoded, int first)
        {
            var result = new int[encoded.Length + 1];
            result[0] = first;
            for (int i = 0; i < encoded.Length; i++)
            {
                result[i + 1] = result[i] ^ encoded[i];
            }
            return result;
        }
    }
}
