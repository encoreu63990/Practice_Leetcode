using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Hard
{
    /// <summary>
    /// https://leetcode.com/problems/median-of-two-sorted-arrays/
    /// https://leetcode.com/problems/median-of-two-sorted-arrays/discuss/1875092/C-Solution
    /// </summary>
    public class _4_Median_of_Two_Sorted_Arrays
    {
        public void Run()
        {
            var sample1 = new
            {
                nums1 = new int[] { 1, 3 },
                nums2 = new int[] { 2 },
                expected = 2.00000
            };

            var sample2 = new
            {
                nums1 = new int[] { 1, 2 },
                nums2 = new int[] { 3, 4 },
                expected = 2.50000
            };


            var result = new Solution().FindMedianSortedArrays(sample2.nums1, sample2.nums2);
        }

        public class Solution
        {
            public double FindMedianSortedArrays(int[] nums1, int[] nums2)
            {
                // lengthCount = 3 (0,1,2), take arr[1]
                // lengthCount = 4 (0,1,2,3), take (arr[1]+arr[2])/2
                var lengthCount = nums1.Length + nums2.Length;
                var midIndex = (lengthCount - 1) / 2;
                var takeCount = lengthCount % 2 == 0 ? 2 : 1;
                var takeIndex = Enumerable.Range(midIndex, takeCount).ToList();
                var takeValue = new List<int>();
                var loopIndex = 0;
                var loopNums1Index = 0;
                var loopNums2Index = 0;

                while (takeIndex.Any())
                {
                    var value = 0;
                    if (loopNums1Index >= nums1.Length)
                    {
                        value = nums2[loopNums2Index++];
                    }
                    else if (loopNums2Index >= nums2.Length)
                    {
                        value = nums1[loopNums1Index++];
                    }
                    else
                    {
                        if (nums1[loopNums1Index] > nums2[loopNums2Index])
                        {
                            value = nums2[loopNums2Index++];
                        }
                        else
                        {
                            value = nums1[loopNums1Index++];
                        }
                    }


                    if (loopIndex == takeIndex.First())
                    {
                        takeValue.Add(value);
                        takeIndex.RemoveAt(0);
                    }
                    loopIndex++;
                }

                var res = takeValue.Average();
                return res;
            }
        }
    }
}
