using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
    /// </summary>
    class _1431_Kids_With_the_Greatest_Number_of_Candies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            List<bool> result = new List<bool>();
            int max = candies.Max();
            foreach(int candy in candies)
            {
                result.Add(candy + extraCandies >= max ? true : false);
            }
            return result;
        }
    }
}
