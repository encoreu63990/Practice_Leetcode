using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/subdomain-visit-count/
    /// https://leetcode.com/problems/subdomain-visit-count/discuss/1439806/C-Solution
    /// </summary>
    class _811_Subdomain_Visit_Count
    {
        public void Run()
        {
            var cpdomains = new string[] { "900 google.mail.com" };
            var result = SubdomainVisits(cpdomains);
        }

        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            IList<string> result = new List<string>();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var cpdomain in cpdomains)
            {
                var msg = cpdomain.Split(' ');
                int counter = int.Parse(msg[0]);
                var domain = msg[1];

                while (true)
                {
                    if (!dict.ContainsKey(domain))
                        dict.Add(domain, 0);
                    dict[domain] += counter;

                    var nextIndex = domain.IndexOf('.');
                    if (nextIndex < 0)
                        break;

                    domain = domain.Substring(nextIndex + 1);
                }
            }

            foreach (var key in dict.Keys)
            {
                result.Add($"{dict[key]} {key}");
            }

            return result;
        }


    }
}