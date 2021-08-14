using Algorithms.Problems.Easy;
using Algorithms.Problems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new _1769_Minimum_Number_of_Operations_to_Move_All_Balls_to_Each_Box();
            Console.WriteLine(c.MinOperations("001011"));

            Console.ReadKey();
        }
    }
}
