using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.MedianOfTwoSortedArr
{
    public class MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int nums1Index = 0;
            int nums2Index = 0;
            List<int> finalArray = new List<int>();
            for (int i = 0; i < nums1.Length + nums2.Length; i++)
            {
                if (nums1Index > nums1.Length - 1)
                {
                    finalArray.Add(nums2[nums2Index]);
                    nums2Index++;
                }
                else if (nums2Index > nums2.Length - 1)
                {
                    finalArray.Add(nums1[nums1Index]);
                    nums1Index++;
                }
                else
                {
                    if (nums1[nums1Index] < nums2[nums2Index])
                    {
                        finalArray.Add(nums1[nums1Index]);
                        nums1Index++;
                    }
                    else
                    {
                        finalArray.Add(nums2[nums2Index]);
                        nums2Index++;
                    }
                }
            }
            Console.WriteLine($"Final array is {string.Join(',', finalArray)}");
            if(finalArray.Count % 2 == 0)
            {
                int firstMiddle = finalArray.Count / 2;
                int secondMiddle = firstMiddle + 1;
                return (double)(finalArray[firstMiddle - 1] + finalArray[secondMiddle - 1]) / 2;
            }
            else
            {
                decimal middle = finalArray.Count / 2;
                int middleIndex = (int)Math.Ceiling(middle);
                return finalArray[middleIndex];
            }
        }
    }
}
