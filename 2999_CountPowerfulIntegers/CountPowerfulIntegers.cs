namespace LeetCodeSolutions;
/*
 You are given three integers start, finish, and limit. You are also given a 0-indexed string s representing a positive integer.

A positive integer x is called powerful if it ends with s (in other words, s is a suffix of x) and each digit in x is at most limit.

Return the total number of powerful integers in the range [start..finish].

A string x is a suffix of a string y if and only if x is a substring of y that starts from some index (including 0) in y and extends to the index y.length - 1. For example, 25 is a suffix of 5125 whereas 512 is not.
*/

public static class CountPowerfulIntegers {
    public static long NumberOfPowerfulInt(long start, long finish, int limit, string s) {
        if (!int.TryParse(s, out int sInt)) {
            return -1;
        }
        if (sInt > finish) {
            return 0;
        }
        for (int i = 0; i < s.Length; i++) {
            if (!int.TryParse(s[i].ToString(), out int charInt)) {
                return -1;
            }
            if (charInt > limit) {
                return 0;
            }
        }
        
        long count = 0;
        // If finish.Length == s.Length then check if s >= start && <= finish and that's 1
        if (finish.ToString().Length >= s.Length && sInt >= start) {
            count = 1;
        }
        // for every n = finish.Length - s.Length then check that every number 1..limit > start and add it up
        for (int i = start.ToString().Length; i <= finish.ToString().Length; i++)
        {
            if (i > s.Length) {
                if (int.TryParse(finish.ToString()[^(i)].ToString(), out int finishInt)) {
                    Console.WriteLine($"Limit: {limit}; FinishInt: {finishInt}");
                    count += limit < finishInt ? limit : finishInt ;
                } else {
                    count += limit;
                }
            }
        }

        return count;
    }

    public static void CallSolution() {
        
        long inputStart, inputFinish;
        int inputLimit;
        string inputS;

        Console.WriteLine("Count Powerful Integers solution:");

        inputStart = 141;
        inputFinish = 148;
        inputLimit = 9;
        inputS = "9";
        Console.WriteLine($"Inputs: {inputStart}, {inputFinish}, {inputLimit}, {inputS}; Output: {NumberOfPowerfulInt(inputStart, inputFinish, inputLimit, inputS)}");
        
        inputStart = 15;
        inputFinish = 215;
        inputLimit = 6;
        inputS = "10";
        Console.WriteLine($"Inputs: {inputStart}, {inputFinish}, {inputLimit}, {inputS}; Output: {NumberOfPowerfulInt(inputStart, inputFinish, inputLimit, inputS)}");
        
        inputStart = 1000;
        inputFinish = 2000;
        inputLimit = 4;
        inputS = "3000";
        Console.WriteLine($"Inputs: {inputStart}, {inputFinish}, {inputLimit}, {inputS}; Output: {NumberOfPowerfulInt(inputStart, inputFinish, inputLimit, inputS)}");
        
        inputStart = 1;
        inputFinish = 6000;
        inputLimit = 4;
        inputS = "124";
        Console.WriteLine($"Inputs: {inputStart}, {inputFinish}, {inputLimit}, {inputS}; Output: {NumberOfPowerfulInt(inputStart, inputFinish, inputLimit, inputS)}");
    }
}
