using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/design-browser-history/
    /// https://leetcode.com/problems/design-browser-history/discuss/1439700/C-Solution
    /// </summary>
    class _1472_Design_Browser_History
    {
        public class BrowserHistory
        {
            List<string> history = null;
            int current;
            int last;

            public BrowserHistory(string homepage)
            {
                current = 0;
                last = 0;
                history = new List<string>() { homepage };
            }

            public void Visit(string url)
            {
                current++;
                last = current;

                if (current >= history.Count)
                {
                    history.Add(url);
                }
                else
                {
                    history[current] = url;
                }
            }

            public string Back(int steps)
            {
                current = current - steps;
                current = current > 0 ? current : 0;
                return history[current];
            }

            public string Forward(int steps)
            {
                current = current + steps;
                current = current > last ? last : current;
                return history[current];
            }
        }
    }
}
