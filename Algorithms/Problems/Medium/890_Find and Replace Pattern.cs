using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/find-and-replace-pattern/
    /// 890_Find and Replace Pattern
    /// </summary>
    class _890_Find_and_Replace_Pattern
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var result = new List<string>();
            var replacedPattern = Replace(pattern);

            foreach (var word in words)
            {
                var replacedWord = Replace(word);
                if (Enumerable.SequenceEqual(replacedPattern, replacedWord))
                    result.Add(word);
            }

            return result;
        }

        public List<int> Replace(string word)
        {
            List<int> list = new List<int>();
            List<char> map = new List<char>();

            foreach (var c in word)
            {
                if (!map.Contains(c))
                    map.Add(c);

                list.Add(map.IndexOf(c));
            }

            return list;
        }
    }
}
