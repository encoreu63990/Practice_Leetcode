using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/count-sorted-vowel-strings/
    /// https://leetcode.com/problems/count-sorted-vowel-strings/discuss/1426572/C-Solution
    /// </summary>
    class _1641_Count_Sorted_Vowel_Strings
    {
        public void Run()
        {
            var result = CountVowelStrings(2);
            Console.WriteLine(result);
        }

        Dictionary<int, int[]> cache = new Dictionary<int, int[]>() { { 1, new int[] { 5, 1, 1, 1, 1, 1 } } };

        public int CountVowelStrings(int n)
        {
            if (cache.ContainsKey(n))
                return cache[n][0];

            if (!cache.ContainsKey(n - 1))
                CountVowelStrings(n - 1);

            int[] prev = cache[n - 1];
            int[] array = new int[5];
            int sum = 1;

            array[4] = prev[4] + 1;
            sum += array[4];

            for (int i = 3; i >= 1; i--)
            {
                array[i] = prev[i] + array[i + 1];
                sum += array[i];
            }

            array[0] = sum;
            cache.Add(n, array);

            return sum;
        }
    }
}
