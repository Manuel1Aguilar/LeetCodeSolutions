namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Strings
{
    public static class FirstUniqChar
    {
        public static int FirstUniqCharIndex(string s)
        {
            Dictionary<char, int> charAppearances = new();

            for (int i = 0; i < s.Length; i++)
            {
                if (charAppearances.ContainsKey(s[i]))
                {
                    charAppearances[s[i]]++;
                }
                else
                {
                    charAppearances.Add(s[i], 1);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charAppearances[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void CallSolution()
        {
            string input;
            int result;

            Console.WriteLine("First Unique Char tests");

            input = "leetcode";
            result = FirstUniqCharIndex(input);
            Console.WriteLine($"Input: {input}; Result: {result}");


            input = "manuelmaguilar";
            result = FirstUniqCharIndex(input);
            Console.WriteLine($"Input: {input}; Result: {result}");
        }
    }
}