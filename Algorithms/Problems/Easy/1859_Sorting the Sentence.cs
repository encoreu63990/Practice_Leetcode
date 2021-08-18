using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/sorting-the-sentence/
    /// </summary>
    class _1859_Sorting_the_Sentence
    {
        public string SortSentence(string s)
        {
            var sortedSentence = s.Split(' ').Select(st =>
            new
            {
                word = st.Substring(0, st.Length - 1),
                number = Convert.ToInt32(st.Substring(st.Length - 1, 1))
            }).OrderBy(c => c.number).Select(c => c.word).Aggregate((l, r) => l + " " + r);

            return sortedSentence;
        }
    }
}
