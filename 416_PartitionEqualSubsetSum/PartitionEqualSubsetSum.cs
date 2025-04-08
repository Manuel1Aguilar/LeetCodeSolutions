namespace LeetCodeSolutions;

/*
 * Given an integer array nums, return true if you can partition the array into two subsets such that the sum of the elements in both subsets is equal or false otherwise.
 */

public class PartitionEqualSubsetSum {

    public static bool Solve(int[] nums) {
        if (nums.Length < 2) {
            return false;
        }

        int sum = 0;
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
        }
        if (sum % 2 != 0) {
            return false;
        }
        int target = sum / 2;

        bool[] sumPaths = new bool[target + 1];
        sumPaths[0] = true;
        foreach (var num in nums) {
            for (int i = target; i >= num; i--) {
                sumPaths[i] = sumPaths[i] || sumPaths[i - num];
            }
        }
        return sumPaths[target];
    }
    public static void CallSolution() {
        int[] input;

        Console.WriteLine("Partition Equal Subset Sum solution:");

        input = [1, 5, 11, 5];
        Console.WriteLine($"For input: {string.Join(',', input)} output is: {Solve(input)}");

        input = [1, 2, 3, 5];
        Console.WriteLine($"for input: {string.Join(',', input)} output is: {Solve(input)}");
    }

}
