namespace LeetCodeSolutions;

public static class ThreeConsecutiveOdds {
    private static bool ThreeConsOdds(int[] arr) {
        int oddN = 0;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] % 2 > 0) {
                oddN++;
                if (oddN == 3) {
                   return true;
                }
            } else {
                oddN = 0;
            }
        }
        return false;
    }

    public static void CallSolution() {
        int[] input;
        
        Console.WriteLine("1550. Three Consecutive Odds Solution:");

        input = [2, 6, 4, 1];
        Console.WriteLine($"Input: {string.Join(',', input)}; Output: {ThreeConsOdds(input)}");
        
        input = [1, 2, 34, 3, 4, 5, 7, 23, 12];
        Console.WriteLine($"Input: {string.Join(',', input)}; Output: {ThreeConsOdds(input)}");
    }
}
