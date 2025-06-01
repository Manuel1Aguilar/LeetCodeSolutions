namespace LeetCodeSolutions;

public static class LongestUnequalAdjacentGroupSubsII {
    
    private static IList<string> GetWordsInLongestSubsequence (string[] words, int[] groups) {
        int[] dp = new int[words.Length];
        int[] prev = new int[words.Length];
        int maxDp = 1, maxDpIndex = 0;
        Array.Fill(dp, 1);
        Array.Fill(prev, -1);

        for (int i = 0; i < words.Length; i++) {
            for (int j = 0; j < i; j++) {
                if (dp[j] >= dp[i]) {
                    // Check if words[j] valid with words[i] then dp[i] = dp[j] + 1
                    if (groups[j] != groups[i] && IsStringValid(words[j], words[i])) {
                        dp[i] = dp[j] + 1;
                        prev[i] = j;
                        if (dp[i] > maxDp) {
                            maxDp = dp[i];
                            maxDpIndex = i;
                        }
                    }
                }
            }
        }
        List<string> res = [];
        while (maxDpIndex != -1) {
            res.Add(words[maxDpIndex]);
            maxDpIndex = prev[maxDpIndex];
        }
        res.Reverse();
        return res;
    }

    private static bool IsStringValid (string s, string s2) {
        if (s.Length != s2.Length) {
            return false;
        }

        int distance = 0;

        for (int i = 0;  i < s.Length; i++) {
            if (s[i] != s2[i]) {
                distance++;
            }
            if (distance > 1) {
                return false;
            }
        }
        return true;
    }

    public static void CallSolution() {
        string[] wordsInput;
        int[] gInput;

        Console.WriteLine("2900. Longest Unequal Adjacent Groups Subsequence I Solution:");

        wordsInput = ["e", "a", "b"];
        gInput = [0, 0, 1];
        Console.WriteLine($"wordsInput: {string.Join(',', wordsInput)}; gInput: {string.Join(',', gInput)}");
        Console.WriteLine($"Output: {string.Join(',', GetWordsInLongestSubsequence(wordsInput, gInput))}");
    }
}
