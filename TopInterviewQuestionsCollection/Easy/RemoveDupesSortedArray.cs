using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Easy
{
    public static class RemoveDupesSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int uniqueElementsPointer = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[uniqueElementsPointer] = nums[i];
                    uniqueElementsPointer++;
                }
            }
            return uniqueElementsPointer;
        }
    }

}
