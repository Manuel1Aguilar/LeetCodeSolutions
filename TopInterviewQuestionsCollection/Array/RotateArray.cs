using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Array
{
    public static class RotateArray
    {
        public static int[] Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k %= n;
            Reverse(nums, 0, n - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, n - 1);
            return nums;
        }
        private static void Reverse(int[] array, int start, int end)
        {
            while (start < end)
            {
                int aux = array[start];
                array[start] = array[end];
                array[end] = aux;
                start++;
                end--;
            }
        }
    }
}
