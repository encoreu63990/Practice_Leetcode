using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/count-substrings-that-differ-by-one-character/
    /// https://leetcode.com/problems/count-substrings-that-differ-by-one-character/discuss/1441596/C-Simple-Solution
    /// </summary>
    class _1638_Count_Substrings_That_Differ_by_One_Character
    {
        public void Run()
        {
            var s = "abe";
            var t = "bbc";
            var result = CountSubstrings(s, t);
        }

        public int CountSubstrings(string s, string t)
        {
            Dictionary<int, List<string>> dict = new Dictionary<int, List<string>>();
            var counter = 0;

            for (int i = 0; i < t.Length; i++)
            {
                for (int j = i; j < t.Length; j++)
                {
                    var subString = t.Substring(i, j - i + 1);
                    if (!dict.ContainsKey(subString.Length))
                        dict.Add(subString.Length, new List<string>());
                    dict[subString.Length].Add(subString);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    var subStringS = s.Substring(i, j - i + 1);
                    foreach (var subStringT in dict[subStringS.Length])
                    {
                        counter += IsDifferByOne(subStringS, subStringT);
                    }
                }
            }

            return counter;
        }

        public int IsDifferByOne(string s, string t)
        {
            var counter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != t[i])
                {
                    counter++;

                    if (counter > 1)
                        return 0;
                }
            }

            return counter;
        }
    }
}
