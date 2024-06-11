using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Easy
{
    public class IntersectedArrays
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> countMap = new();

            for (int i = 0; i < nums2.Length; i++)
            {
                if (countMap.ContainsKey(nums2[i]))
                {
                    countMap[nums2[i]]++;
                }
                else
                {
                    countMap.Add(nums2[i], 1);
                }
            }
            List<int> result = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (countMap.TryGetValue(nums1[i], out int value) && value > 0)
                {
                    result.Add(nums1[i]);
                    countMap[nums1[i]] = --value;
                }
            }
            return [.. result];
        }
    }
}
