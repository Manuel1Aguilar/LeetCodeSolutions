namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Strings
{
    public static class ReverseString
    {
        public static void ReverseStringInPlace(char[] s)
        {
            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                (s[start], s[end]) = (s[end], s[start]);
                start++;
                end--;
            }
        }

        public static void CallSolution()
        {
            char[] input;

            Console.WriteLine("Reverse String Tests");

            input = ['H', 'e', 'l', 'l', 'o'];
            Console.Write($"Input: {String.Join(",", input)}; ");
            ReverseStringInPlace(input);
            Console.WriteLine($"Res: {String.Join(", ", input)}");
        }
    }
}