using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/shuffle-string/
    /// </summary>
    class _1528_Shuffle_String
    {
        public string RestoreString(string s, int[] indices)
        {
            var length = indices.Length;
            var array = new char[s.Length];
            for (int i = 0; i < length; i++)
            {
                array[indices[i]] = s[i];
            }
            return string.Join("", array);
        }
    }
}
