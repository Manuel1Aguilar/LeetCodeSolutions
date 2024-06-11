
using System.ComponentModel;
using System.Text;

namespace LeetCodeSolutions.LongestSubstWoutRepeatingChars
{
    public class LongestSubstWithoutRepeatingChars
    {

        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            List<CharList> chars = new List<CharList>();
            for (int i = 0; i < s.Length; i++)
            {
                chars.ForEach(x =>
                {
                    if (x.Chars!.Contains(s[i]))
                    {
                        x.IsClosed = true;
                    }
                    else
                    {
                        if (!x.IsClosed)
                        {
                            x.Chars.Add(s[i]);
                        }
                    }
                });
                chars.Add(new CharList() { Chars = new List<char>() { s[i] } });
            }
            return chars.MaxBy(x => x.Chars!.Count)!.Chars!.Count;
        }
        public int AltSol(string s)
        {
            if (string.IsNullOrEmpty(s)) { return 0; }
            int maxLen = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                int nextFind = s.IndexOf(c, i + 1);
                Console.WriteLine($"Char : {c} Next find on index {nextFind}");

                if (nextFind == -1)
                {
                    if (maxLen < s.Length - i)
                    {
                        Console.WriteLine($"s.Length - i: {s.Length - i}");
                        maxLen = s.Length - i;
                    }
                }
                if (maxLen < nextFind - i)
                {
                    Console.WriteLine($"nextFind - i: {nextFind - i}");
                    maxLen = nextFind - i;
                }
            }
            return maxLen;
        }

        public int FinalSolution(string s)
        {
            if (string.IsNullOrEmpty(s)) { return 0; }
            int maxLen = 0;
            for (int i = 0; i < s.Length; i++)
            {
                StringBuilder currString = new();
                currString.Append(s[i]);
                HashSet<char> set = [];
                set.Add(s[i]);
                int currIndex = i;
                while(set.Count == currString.Length && currIndex < s.Length - 1)
                {
                    currIndex++;
                    set.Add(s[currIndex]);
                    currString.Append(s[currIndex]);
                }
                if(maxLen < set.Count)
                {
                    maxLen = set.Count;
                }

            }

            return maxLen;
        }
    }
}
