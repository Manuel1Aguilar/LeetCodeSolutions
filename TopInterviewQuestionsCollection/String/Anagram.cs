namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Strings
{
    public static class Anagram
    {
        private static bool IsAnagram(string s, string t)
        {
            if(t.Length < s.Length) return false;
            Dictionary<char, int> charOccurences = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (charOccurences.TryGetValue(s[i], out int value))
                {
                    charOccurences[s[i]] = ++value;
                }
                else
                {
                    charOccurences[s[i]] = 1;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (!charOccurences.ContainsKey(t[i]) || charOccurences[t[i]] < 1)
                {
                    return false;
                }
                charOccurences[t[i]]--;
            }

            var charlist = charOccurences.ToList();

            for (int i = 0; i < charlist.Count; i++)
            {
                if (charlist[i].Value > 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void CallSolution()
        {
            string firstWordInput;
            string scndWordInput;
            bool res;

            Console.WriteLine("Is Valid Anagram Tests");

            firstWordInput = "anagram";
            scndWordInput = "naagarm";
            res = IsAnagram(firstWordInput, scndWordInput);
            Console.WriteLine($"Input: {firstWordInput}, {scndWordInput}; Res: {res}");

            firstWordInput = "manu";
            scndWordInput = "notananagram";
            res = IsAnagram(firstWordInput, scndWordInput);
            Console.WriteLine($"Input: {firstWordInput}, {scndWordInput}; Res: {res}");

            
            firstWordInput = "manu";
            scndWordInput = "m";
            res = IsAnagram(firstWordInput, scndWordInput);
            Console.WriteLine($"Input: {firstWordInput}, {scndWordInput}; Res: {res}");
            
            firstWordInput = "m";
            scndWordInput = "mguillermina";
            res = IsAnagram(firstWordInput, scndWordInput);
            Console.WriteLine($"Input: {firstWordInput}, {scndWordInput}; Res: {res}");
        }
    }
}