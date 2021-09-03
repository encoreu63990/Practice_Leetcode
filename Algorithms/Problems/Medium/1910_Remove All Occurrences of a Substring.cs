using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/remove-all-occurrences-of-a-substring/
    /// https://leetcode.com/problems/remove-all-occurrences-of-a-substring/discuss/1441651/C-Simple-Solution
    /// </summary>
    class _1910_Remove_All_Occurrences_of_a_Substring
    {
        public void Run()
        {
            var s = "eemckxmckx";
            var part = "emckx";
            var result = RemoveOccurrences(s, part);
        }

        public string RemoveOccurrences(string s, string part)
        {
            var index = s.IndexOf(part);

            while (index >= 0)
            {
                s = s.Remove(index, part.Length);
                index = index - part.Length - 1;
                if (index < 0)
                    index = 0;
                index = s.IndexOf(part, index);
            }

            //while (s.Contains(part))
            //{
            //    s.Remove(s.IndexOf(part), part.Length);
            //}

            return s;
        }
    }
}

