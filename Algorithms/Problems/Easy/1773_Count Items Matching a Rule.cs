using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/count-items-matching-a-rule/
    /// </summary>
    class _1773_Count_Items_Matching_a_Rule
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            var keys = new List<string> { "type", "color", "name" };
            var index = keys.IndexOf(ruleKey);
            return items.Where(list => list[index] == ruleValue).Count();
        }
    }
}
