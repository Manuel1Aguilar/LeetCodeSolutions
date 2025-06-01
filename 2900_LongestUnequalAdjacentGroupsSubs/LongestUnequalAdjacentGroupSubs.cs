namespace LeetCodeSolutions;

public static class LongestUnequalAdjacentGroupSubs {

    private static IList<string> GetLongestSubsequence(string[] words, int[] groups) {
        List<int> indexes = [];
        int lastVal = groups[0];
        indexes.Add(0);
        
        for (int i = 1; i < groups.Length; i++) {
            if (lastVal != groups[i]) {
                indexes.Add(i);
                lastVal = groups[i];
            }
        }

        string[] res = new string[indexes.Count];
        for (int i = 0; i < indexes.Count; i++) {
            res[i] = words[indexes[i]];
        }
        return res;
    }

    public static void CallSolution() {
        string[] wordsInput;
        int[] gInput;

        Console.WriteLine("2900. Longest Unequal Adjacent Groups Subsequence I Solution:");

        wordsInput = ["e", "a", "b"];
        gInput = [0, 0, 1];
        Console.WriteLine($"wordsInput: {string.Join(',', wordsInput)}; gInput: {string.Join(',', gInput)}");
        Console.WriteLine($"Output: {string.Join(',', GetLongestSubsequence(wordsInput, gInput))}");
    }
}
