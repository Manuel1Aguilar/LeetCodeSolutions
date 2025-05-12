namespace LeetCodeSolutions;
/*
 You are given two arrays nums1 and nums2 consisting of positive integers.

You have to replace all the 0's in both arrays with strictly positive integers such that the sum of elements of both arrays becomes equal.

Return the minimum equal sum you can obtain, or -1 if it is impossible.
 */
public static class MinEqTwoArrayReplacingZeros {
    private static long MinSum(int[] nums1, int[] nums2) {
        long sum1 = 0, sum2 = 0, z1 = 0, z2 = 0;

        for (int i = 0; i < nums1.Length; i++) {
            sum1 += nums1[i];
            if (nums1[i] == 0) 
                z1++;
        }

        for (int i = 0; i < nums2.Length; i++) {
            sum2 += nums2[i];
            if (nums2[i] == 0) 
                z2++;
        }

        if ((z1 == 0 && sum1 < sum2 + z2) || (z2 == 0 && sum2 < sum1 + z1)) {
            return -1;
        }

        return Math.Max(sum1 + z1, sum2 + z2);
    }

    public static void CallSolution() {
        int[] input1, input2;

        Console.WriteLine("2918. Minimum Equal Sum of Two Arrays After Replacing Zeros Solution:");

        input1 = [2, 0, 2, 0];
        input2 = [1, 4];
        Console.WriteLine($"Inputs: 1. {string.Join(',', input1)}\n; 2. {string.Join(',', input2)}");
        Console.WriteLine($"Output: {MinSum(input1, input2)}");

        input1 = [3, 2, 0, 1, 0];
        input2 = [6, 5, 0];
        Console.WriteLine($"Inputs: 1. {string.Join(',', input1)}\n; 2. {string.Join(',', input2)}");
        Console.WriteLine($"Output: {MinSum(input1, input2)}");
    }
}
