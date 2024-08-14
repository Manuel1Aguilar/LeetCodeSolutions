using LeetCodeSolutions.Shared;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Trees;

public static class MaxDepth
{
    public static int GetMaxDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        int leftDepth = GetMaxDepth(root.left);
        int rightDepth = GetMaxDepth(root.right);

        return Math.Max(leftDepth, rightDepth) + 1;
    }

    public static void CallSolution()
    {
        throw new NotImplementedException();
    }
}