using LeetCodeSolutions.Shared;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Trees;

public static class PalindromeTree
{
    private static bool IsSymmetric(TreeNode? root)
    {
        if (root is null) { return true; }
        return IsMirror(root.left, root.right);
    }
    public static bool IsMirror(TreeNode? right, TreeNode? left)
    {
        if(right is null && left is null)
        {
            return true;
        }
        if(right is null || left is null)
        {
            return false;
        }
        return (right.val == left.val) &&
                IsMirror(right.left, left.right) &&
                IsMirror(right.right, left.left);
    }
    public static void CallSolution()
    {
        int?[] inputVals;
        bool res;

        Console.WriteLine("Symmetric binary tree tests");

        inputVals = [5,4,1,null,1,null,4,2,null,2,null];
        TreeNode root = TreeNode.FromList(inputVals)!;
        res = IsSymmetric(root);
        Console.WriteLine($"Input:");
        root.WriteLtoR();
        Console.WriteLine($"Res: {res}");


        inputVals = [1, 2, 2, 2, null, 2];
        root = TreeNode.FromList(inputVals)!;
        res = IsSymmetric(root);
        Console.WriteLine($"Input:");
        root.WriteLtoR();
        Console.WriteLine($"Res: {res}");

        inputVals = [1, 2, 2, 3, 4, 4, 3];
        root = TreeNode.FromList(inputVals)!;
        res = IsSymmetric(root);
        Console.WriteLine($"Input:");
        root.WriteLtoR();
        Console.WriteLine($"Res: {res}");

        inputVals = [1, 2, 2, null, 3, null, 3];
        root = TreeNode.FromList(inputVals)!;
        res = IsSymmetric(root);
        Console.WriteLine($"Input:");
        root.WriteLtoR();
        Console.WriteLine($"Res: {res}");
    }
}