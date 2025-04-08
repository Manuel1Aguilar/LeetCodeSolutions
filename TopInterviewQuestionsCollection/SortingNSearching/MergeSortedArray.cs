namespace LeetCodeSolutions.TopInterviewQuestionsCollection.SortingNSearching;

public static class MergeSortedArray
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if(n == 0)
        {
            return;
        }
        int nums1Index = 0;
        int nums2Index = 0;

        for (int i = 0; i < n + m; i++)
        {
            if(i >= m)
            {
                nums1[nums1Index] = nums2[nums2Index];
                nums2Index++;
            }
            else if (nums1[nums1Index] > nums2[nums2Index])
            {
                (nums2[nums2Index], nums1[nums1Index]) = (nums1[nums1Index], nums2[nums2Index]);
                LiteSort(nums2);
            }
            nums1Index++;
        }
    }

    private static void LiteSort(int[] nums)
    {
        int length = nums.Length;
        for(int i = 0; i < length - 1; i++)
        {
            if(nums[i] > nums[i + 1])
            {
                (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
            }
        }
    }
    public static void CallSolution()
    {
        int[] nums1;
        int[] nums2;

        Console.WriteLine("Merge Two Sorted Arrays solution");

        nums1 = [1, 2, 3, 0, 0, 0];
        nums2 = [2, 5, 6];
        Console.WriteLine($"Input: Nums1 {string.Join(", ", nums1)}, Nums2 {string.Join(", ", nums2)}");
        Merge(nums1, 3, nums2, 3);
        Console.WriteLine($"Res: {string.Join(", ", nums1)}");

        nums1 = [2, 3, 4, 0, 0, 0];
        nums2 = [1, 5, 6];
        Console.WriteLine($"Input: Nums1 {string.Join(", ", nums1)}, Nums2 {string.Join(", ", nums2)}");
        Merge(nums1, 3, nums2, 3);
        Console.WriteLine($"Res: {string.Join(", ", nums1)}");

        nums1 = [4, 5, 6, 0, 0, 0];
        nums2 = [1, 2, 3];
        Console.WriteLine($"Input: Nums1 {string.Join(", ", nums1)}, Nums2 {string.Join(", ", nums2)}");
        Merge(nums1, 3, nums2, 3);
        Console.WriteLine($"Res: {string.Join(", ", nums1)}");
        
        nums1 = [0, 0, 0, 0, 0];
        nums2 = [1, 2, 3, 4, 5];
        Console.WriteLine($"Input: Nums1 {string.Join(", ", nums1)}, Nums2 {string.Join(", ", nums2)}");
        Merge(nums1, 0, nums2, 5);
        Console.WriteLine($"Res: {string.Join(", ", nums1)}");
        
        nums1 = [-1,0,0,3,3,3,0,0,0];
        nums2 = [1, 2, 2];
        Console.WriteLine($"Input: Nums1 {string.Join(", ", nums1)}, Nums2 {string.Join(", ", nums2)}");
        Merge(nums1, 6, nums2, 3);
        Console.WriteLine($"Res: {string.Join(", ", nums1)}");

        nums1 = [1];
        nums2 = [];
        Console.WriteLine($"Input: Nums1 {string.Join(", ", nums1)}, Nums2 {string.Join(", ", nums2)}");
        Merge(nums1, 1, nums2, 0);
        Console.WriteLine($"Res: {string.Join(", ", nums1)}");

        nums1 = [0];
        nums2 = [1];
        Console.WriteLine($"Input: Nums1 {string.Join(", ", nums1)}, Nums2 {string.Join(", ", nums2)}");
        Merge(nums1, 0, nums2, 1);
        Console.WriteLine($"Res: {string.Join(", ", nums1)}");
    }
}