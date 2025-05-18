namespace LeetCodeSolutions;

public static class Find3DigitEvenNums {
    private static int[] FindEvenNumbers(int[] digits) {
        int[] freq = new int[10];
        foreach(var digit in digits) { freq[digit]++; }

        List<int> answer = [];

        for (int d1 = 1; d1 <= 9; d1++) {
            if (freq[d1] == 0) {
                continue;
            }
            freq[d1]--;
            for (int d2 = 0; d2 <= 9; d2++) {
                if (freq[d2] == 0) {
                    continue;
                }
                freq[d2]--;
                for (int d3 = 0; d3 < 9 ; d3 += 2) {
                    if (freq[d3] != 0) {
                        answer.Add(d1 * 100 + d2 * 10 + d3);
                    }
                }
                freq[d2]++;
            }
            freq[d1]++;
        }
        return answer.ToArray();
    }

    public static void CallSolution() {
        int[] input;

        Console.WriteLine("2094. Finding 3-Digit Even Numbers");
        
        input = [2, 1, 3, 0];
        Console.WriteLine($"Input: {string.Join(',', input)};");
        Console.WriteLine($"Output: {string.Join(',', FindEvenNumbers(input))}");
        
        
        input = [2, 2, 8, 8, 2];
        Console.WriteLine($"Input: {string.Join(',', input)};");
        Console.WriteLine($"Output: {string.Join(',', FindEvenNumbers(input))}");

        input = [3, 7, 5];
        Console.WriteLine($"Input: {string.Join(',', input)};");
        Console.WriteLine($"Output: {string.Join(',', FindEvenNumbers(input))}");

    }

}
