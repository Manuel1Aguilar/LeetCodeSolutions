namespace LeetCodeSolutions;

/* 
 * Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.
 *
 * We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.
 *
 * You must solve this problem without using the library's sort function.
*/

public static class SortColors {
    public static void Sort(int[] nums) {
        int sortIndex = 0;
        int sortVal = 0;

        for (int i = 0; i  < nums.Length; i++) {
            if (nums[i] == sortVal) {
                sortIndex++;
            } else {
                for (int j = i; j < nums.Length; j++) {
                    if (nums[j] == sortVal) {
                        
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                        sortIndex++;
                        break;
                    } else if (j == nums.Length - 1) {
                        sortVal++;
                        i--;
                        break;
                    }
                }
            }
        }
    }

    private static void CountSort(int[] nums) {
        int[] counts = new int[3];
        for (int i = 0; i < nums.Length; i++) {
            counts[nums[i]]++;
        }
        int index = 0;
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < counts[i]; j++) {
                nums[index] = i;
                index++;
            }
        }
    }

    public static void CallSolution() {
        int[] input;
        Console.WriteLine("75. Sort Colors Solution:");

        input = [2, 0, 2, 1, 1, 0];
        Console.Write($"Input: {string.Join(',', input)}\n");
        CountSort(input);
        Console.Write($"; Output: {string.Join(',', input)}\n");
    }
}
