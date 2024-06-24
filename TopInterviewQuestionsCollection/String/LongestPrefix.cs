namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Strings
{
    public static class LongestPrefix
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            string prefix = strs[0];
            for(int i = 1; i < strs.Length; i++) 
            {
                string word = strs[i];
                int wordSize =  Math.Min(prefix.Length - 1, word.Length - 1);
                int index = 0;
                do 
                {
                    if(word[index] == prefix[index])
                    {
                        index++;
                    }
                } while(index < wordSize && word[index] == prefix[index]);
                if(index == 0) {
                    return "";
                }
                prefix = prefix[..index];
            }

            return prefix;
        }

        public static void CallSolution()
        {
            string[] input;
            string res;

            Console.WriteLine("Longest Commmon Prefix Tests");

            input = ["flower", "flow", "flight"];
            res = LongestCommonPrefix(input);
            Console.WriteLine($"Input: {string.Join(", ", input)}; Result: {res}");

            input = ["dog", "racecar", "car"];
            res = LongestCommonPrefix(input);
            Console.WriteLine($"Input: {string.Join(", ", input)}; Result: {res}");
        }
    }
}