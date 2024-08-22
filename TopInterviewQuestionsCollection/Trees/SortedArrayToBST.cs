using LeetCodeSolutions.Shared;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Trees;

public static class SortedArrayToBST
{
    private static TreeNode? CreateBST(int[] input)
    {
        if (input.Length == 0) { return null; }
        int half = input.Length / 2;
        TreeNode root = new()
        {
            val = input[half]
        };

        int[] leftArray = new int[half];
        System.Array.Copy(input, 0, leftArray, 0, half);
        root.left =  CreateBST(leftArray);


        int[] rightArray = new int[input.Length - half - 1];

        if(rightArray.Length > 0) {
            System.Array.Copy(input, half + 1, rightArray, 0, rightArray.Length);
            root.right = CreateBST(rightArray);
        }

        return root;
    }
    public static void CallSolution()
    {
        int[] input;
        TreeNode res;

        Console.WriteLine("Create Binary Tree from sorted array solution");

        input = [-10, -3, 0, 5, 9];
        res = CreateBST(input)!;
        Console.WriteLine($"Input: {string.Join(", ", input)}");
        Console.WriteLine("Res:");
        res.WriteLtoR();

        
        input = [1, 3];
        res = CreateBST(input)!;
        Console.WriteLine($"Input: {string.Join(", ", input)}");
        Console.WriteLine("Res:");
        res.WriteLtoR();

        input = [-1,0,1,2];
        res = CreateBST(input)!;
        Console.WriteLine($"Input: {string.Join(", ", input)}");
        Console.WriteLine("Res:");
        res.WriteLtoR();
        
    }
}