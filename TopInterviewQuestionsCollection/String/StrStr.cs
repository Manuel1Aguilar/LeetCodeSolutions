namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Strings
{
    public static class StrStr
    {
        public static int IndexOfString(string haystack, string needle)
        {
            if(string.IsNullOrWhiteSpace(haystack))
            {
                return -1;
            }
            int needleIndex = 0;
            int start;
            for (int i = 0; i < haystack.Length; i++)
            {
                start = i;
                int index = i;
                while (index < haystack.Length && haystack[index] == needle[needleIndex])
                {
                    needleIndex++;
                    if (needleIndex == needle.Length)
                    {
                        return start;
                    }
                    index++;
                }
                needleIndex = 0;
            }
            return -1;
        }

        public static void CallSolution()
        {
            string needle;
            string haystack;
            int res;

            Console.WriteLine("StrStr tests");

            needle = "sad";
            haystack = "sadbutsad";
            res = IndexOfString(haystack, needle);
            Console.WriteLine($"Needle: {needle}; Haystack: {haystack}; Res: {res}");


            needle = "sad";
            haystack = "sidbutsad";
            res = IndexOfString(haystack, needle);
            Console.WriteLine($"Needle: {needle}; Haystack: {haystack}; Res: {res}");


            needle = "sad";
            haystack = "sidbutsid";
            res = IndexOfString(haystack, needle);
            Console.WriteLine($"Needle: {needle}; Haystack: {haystack}; Res: {res}");

            needle = "but";
            haystack = "sadbutsad";
            res = IndexOfString(haystack, needle);
            Console.WriteLine($"Needle: {needle}; Haystack: {haystack}; Res: {res}");

            needle = "aaaa";
            haystack = "aaa";
            res = IndexOfString(haystack, needle);
            Console.WriteLine($"Needle: {needle}; Haystack: {haystack}; Res: {res}");

            needle = "issip";
            haystack = "mississippi";
            res = IndexOfString(haystack, needle);
            Console.WriteLine($"Needle: {needle}; Haystack: {haystack}; Res: {res}");
        }
    }
}