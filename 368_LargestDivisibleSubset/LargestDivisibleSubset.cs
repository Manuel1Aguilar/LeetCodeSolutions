namespace LeetCodeSolutions;
/*
    Given a set of distinct positive integers nums, return the largest subset answer such that every pair (answer[i], answer[j]) of elements in this subset satisfies:

    answer[i] % answer[j] == 0, or
    answer[j] % answer[i] == 0
    If there are multiple solutions, return any of them.
*/
public class LargestDivisibleSubset {

    public static int[] Solve(int[] input) {
        if (input.Length == 0) {
            return [];
        }
        Quicksort(input);
        Console.WriteLine(string.Join(',',input));
        int[] dp = new int[input.Length];
        int[] prev = new int[input.Length];

        for (int i = 0; i < dp.Length; i++) {
            dp[i] = 1;
            prev[i] = -1;
        }

        int maxIndex = 0;
        for (int i = 0; i < input.Length; i++) {
            for (int j = 0; j < i; j++) {
                if ( input[i] % input[j] == 0) {
                    if(dp[j] + 1 > dp[i]) {
                        dp[i] = dp[j] + 1;
                        prev[i] = j;
                    }
                }
            }
            if (dp[i] > dp[maxIndex]) {
                maxIndex = i;
            }
        }

        int[] solution = new int[dp[maxIndex]];
        int currSolSpot = dp[maxIndex] - 1;
        while (maxIndex > -1) {
            solution[currSolSpot--] = input[maxIndex];
            maxIndex = prev[maxIndex];
        }
        return solution;
    }

    private static void Quicksort(int[] nums) {
        if (nums.Length < 2) {
            return;
        }

        int pivot = (nums[0] + nums[nums.Length / 2] + nums[nums.Length - 1]) / 3;
        List<int> left = [];
        List<int> right = [];
        List<int> equal = [];
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < pivot) {
                left.Add(nums[i]);
            } else if (nums[i] > pivot) {
                right.Add(nums[i]);
            } else {
                equal.Add(nums[i]);
            }
        }
        Quicksort(left.ToArray());
        Quicksort(right.ToArray());
        left.AddRange(equal);
        left.AddRange(right);
        int[] sorted = left.ToArray(); 

        for (int i = 0; i < sorted.Length; i++) {
            nums[i] = sorted[i];
        }
    }

    public static void CallSolution() {
        int[] input;
        
        Console.WriteLine("Get Largest Divisible Subset from int array");

        input = [1, 2, 3];
        Console.WriteLine($"Input: {string.Join(',', input)}; Output : {string.Join(',', Solve(input))}");

        input = [1, 2, 4, 8];
        Console.WriteLine($"Input: {string.Join(',', input)}; Output : {string.Join(',', Solve(input))}");
        
        
        input = [1, 2, 5, 6, 7, 8, 11, 4];
        Console.WriteLine($"Input: {string.Join(',', input)}; Output : {string.Join(',', Solve(input))}");
        
        input = [343,49,8,4,2,1];
        Console.WriteLine($"Input: {string.Join(',', input)}; Output : {string.Join(',', Solve(input))}");
    }
}
