namespace LeetCodeSolutions;

public static class TypeOfTriangle {
    private static string TriangleType (int[] nums) {
        int sum1 = 0, sum2 = 0, sum3 = 0;

        if (nums[0] == nums[1] && nums[1] == nums[2]) {
            return "equilateral";
        }
        for (int i = 0; i < 3; i++) {
            if (i == 0) {
                sum1 += nums[i];
                sum2 += nums[i];
            } else if (i == 1) {
                sum1 += nums[i];
                sum3 += nums[i];
            } else {
                sum2 += nums[i];
                sum3 += nums[i];
            }
        }
        if (sum1 <= nums[2] || sum2 <= nums[1] || sum3 <= nums[0]) {
            return "none";
        }

        if(nums[0] == nums[1] || nums[1] == nums[2] || nums[0] == nums[2]) {
            return "isosceles";
        }
        return "scalene";
    }

    public static void CallSolution() {
        int[] input;

        Console.WriteLine("3024. Type of Triangle Solution:");

        input = [1, 2, 3];
        Console.WriteLine($"Input: {string.Join(',', input)}; Output: {TriangleType(input)}");
    }
}
