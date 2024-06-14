using System.Text.RegularExpressions;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Strings
{
    public static class ValidPalindrome
    {
        private static bool IsValidPalindrome(string s)
        {
            s = RemoveNonAlphanumeric(s);

            int start = 0;
            int end = s.Length - 1;
            char[] charArray = s.ToLower().ToCharArray();
            
            while(start < end)
            {
                if(charArray[start] != charArray[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }

        private static string RemoveNonAlphanumeric(string s)
        {
            return Regex.Replace(s, "[^a-zA-Z0-9]", "");
        }

        public static void CallSolution()
        {
            string input;
            bool res;

            Console.WriteLine("Is Valid Palindrome Tests");

            input = "A man, a plan, a canal: Panama";
            res = IsValidPalindrome(input);
            Console.WriteLine($"Input: {input}; Result: {res}");


            input = "race a car";
            res = IsValidPalindrome(input);
            Console.WriteLine($"Input: {input}; Result: {res}");


            input = " ";
            res = IsValidPalindrome(input);
            Console.WriteLine($"Input: {input}; Result: {res}");
        }
    }
}