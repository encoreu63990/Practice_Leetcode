using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/bulb-switcher-iv/
    /// https://leetcode.com/problems/bulb-switcher-iv/discuss/1440062/C-Solution
    /// </summary>
    class _1529_Bulb_Switcher_IV
    {
        public void Run()
        {
            var target = "001011101";
            var result = MinFlips(target);
        }

        public int MinFlips(string target)
        {
            var firstOnIndex = target.IndexOf('1');
            if (firstOnIndex < 0)
                return 0;

            List<char> list = new List<char>();
            list.Add(target.Last());
            for (int i = target.Length - 2; i >= firstOnIndex; i--)
            {
                if (target[i] != list.Last())
                {
                    list.Add(target[i]);
                }
            }

            return list.Count();
        }
    }
}

