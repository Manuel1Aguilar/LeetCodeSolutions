namespace LeetCodeSolutions;

public static class MinimumOperationsToMakeArrayValuesK {
    public static int MinOperations(int[] nums, int k) {
        HashSet<int> distinct = new();
        int min = nums[0];
        distinct.Add(nums[0]);
        
        for (int i = 1; i < nums.Length; i++) {
            if (min > nums[i]) {
                min = nums[i];
            }
            distinct.Add(nums[i]);
        }
        if (k > min) {
            return -1;
        }
        return distinct.Count - (min == k ? 1 : 0);
    }

    public static void CallSolution() {
        int[] input;
        int inputTarget;

        Console.WriteLine("3375. Minimum Operations to Make Array Values Equal to K solution:");

        input = [5, 2, 5, 4, 5];
        inputTarget = 2;
        Console.WriteLine($"Input: {string.Join(',', input)}; Input Target: {inputTarget}; Output: {MinOperations(input, inputTarget)}");

        input = [2, 1, 2];
        inputTarget = 2;
        Console.WriteLine($"Input: {string.Join(',', input)}; Input Target: {inputTarget}; Output: {MinOperations(input, inputTarget)}");

        input = [9, 7, 5, 3];
        inputTarget = 1;
        Console.WriteLine($"Input: {string.Join(',', input)}; Input Target: {inputTarget}; Output: {MinOperations(input, inputTarget)}");
    }
}
