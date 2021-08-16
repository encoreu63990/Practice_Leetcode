using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/goal-parser-interpretation/
    /// </summary>
    class _1678_Goal_Parser_Interpretation
    {
        public string Interpret(string command)
        {
            var result = command.Replace("()", "o");
            result = result.Replace("(al)", "al");
            return result;
        }
    }
}
