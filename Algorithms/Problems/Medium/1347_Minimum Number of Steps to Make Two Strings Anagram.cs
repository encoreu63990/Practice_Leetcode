using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-number-of-steps-to-make-two-strings-anagram/
    /// </summary>
    class _1347_Minimum_Number_of_Steps_to_Make_Two_Strings_Anagram
    {
        public int MinSteps(string s, string t)
        {
            int[] frequency = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                frequency[t[i] - 'a']++;
                frequency[s[i] - 'a']--;
            }

            var result = frequency.Where(c => c > 0).Sum();
            return result;
        }
    }
}
