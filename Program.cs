using LeetCodeSolutions.AddTwoReversedLinkedListNumbers;
using LeetCodeSolutions.LongestPalindromicSubstring;
using LeetCodeSolutions.LongestSubstWoutRepeatingChars;
using LeetCodeSolutions.MedianOfTwoSortedArr;
using LeetCodeSolutions.Shared;

namespace LeetCodeSolutions
{
    internal class Program
    {

        static void Main()
        {
            TotalCharsInStringAfterTransformsII.CallSolution(); 
        }
        
        public static void SumOfRevLinkedListNumsSolutions() {
            SumOfTwoReversedLinkedListNumbers sumClass = new();
            ListNode? firstList = sumClass.CreateNodes([2, 4, 3]);
            ListNode? secondList = sumClass.CreateNodes([5, 6, 4]);
            var res = sumClass.AddTwoNumbers(firstList!, secondList!);
            firstList = sumClass.CreateNodes([0]);
            secondList = sumClass.CreateNodes([0]);
            res = sumClass.AddTwoNumbers(firstList!, secondList!);
            firstList = sumClass.CreateNodes([9,9,9,9,9,9,9]);
            secondList = sumClass.CreateNodes([9,9,9,9]);
            res = sumClass.AddTwoNumbers(firstList!, secondList!);
        }

        public static void MedianOfTwoSortedArraysSolutions()
        {
            MedianOfTwoSortedArrays median = new();
            int[] nums1 = [1, 3];
            int[] nums2 = [2];
            //Console.WriteLine($"For arrays {string.Join(',',nums1)} and {string.Join(',', nums2)} the solution is {median.FindMedianSortedArrays(nums1, nums2)}");
            nums1 = [1, 2];
            nums2 = [3, 4];
            Console.WriteLine($"For arrays {string.Join(',', nums1)} and {string.Join(',', nums2)} the solution is {median.FindMedianSortedArrays(nums1, nums2)}");
            nums1 = [1, 3];
            nums2 = [5, 6, 7, 8];
            Console.WriteLine($"For arrays {string.Join(',', nums1)} and {string.Join(',', nums2)} the solution is {median.FindMedianSortedArrays(nums1, nums2)}");
            nums1 = [1, 11];
            nums2 = [4, 6, 8, 12];
            Console.WriteLine($"For arrays {string.Join(',', nums1)} and {string.Join(',', nums2)} the solution is {median.FindMedianSortedArrays(nums1, nums2)}");
        }

        public static void LongestSubstSolutions()
        {
            LongestSubstWithoutRepeatingChars repeatingChars = new();
            string input = "aab";
            Console.WriteLine($"For string {input} the solution is {repeatingChars.FinalSolution(input)}");
            input = "pwwkew";
            Console.WriteLine($"For string {input} the solution is {repeatingChars.FinalSolution(input)}");
            input = "bbbbb";
            Console.WriteLine($"For string {input} the solution is {repeatingChars.FinalSolution(input)}");
            input = "abcabcbb";
            Console.WriteLine($"For string {input} the solution is {repeatingChars.FinalSolution(input)}");
            input = "sadasfdagsdfg";
            Console.WriteLine($"For string {input} the solution is {repeatingChars.FinalSolution(input)}");
            input = "iehjprtoirhijbv";
            Console.WriteLine($"For string {input} the solution is {repeatingChars.FinalSolution(input)}");
        }

        public static void LongestPalindromicSubstringSolutions()
        {
            LongestPalindromicSubstSolution longestPalindromic = new();

            string input = "a";
            Console.WriteLine($"For string {input} the solution is {longestPalindromic.LongestPalindrome2(input)}");
            input = "bb";
            Console.WriteLine($"For string {input} the solution is {longestPalindromic.LongestPalindrome2(input)}");
            input = "abababa";
            Console.WriteLine($"For string {input} the solution is {longestPalindromic.LongestPalindrome2(input)}");
            input = "afdsgafgh";
            Console.WriteLine($"For string {input} the solution is {longestPalindromic.LongestPalindrome2(input)}");
            input = "afdsgabababaafgh";
            Console.WriteLine($"For string {input} the solution is {longestPalindromic.LongestPalindrome2(input)}");
        }
    }
}
