using LeetCodeSolutions.Shared;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.Trees;

public static class LevelOrderTraversal
{
    private static List<List<int>> LevelOrder(TreeNode? root)
    {
        List<List<int>> levels = [];
        if (root is null)
        {
            return levels;
        }

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            List<int> currLevel = [];

            for (int i = 0; i < levelSize; i++)
            {
                TreeNode node = queue.Dequeue();
                currLevel.Add(node.val);
                if (node.left is not null) { queue.Enqueue(node.left); }
                if (node.right is not null) { queue.Enqueue(node.right); }

            }
            levels.Add(currLevel);
        }
        return levels;
    }

    public static void CallSolution()
    {
        int?[] input;
        List<List<int>> res;
        TreeNode? tree;

        Console.WriteLine("Binary Tree level order traversal solution");

        input = [3, 9, 20, null, null, 15, 7];
        tree = TreeNode.FromList(input);
        res = LevelOrder(tree);
        Console.WriteLine("Input:");
        tree!.WriteLtoR();
        Console.WriteLine($"Res: [{string.Join(", ", res.Select(x => $"[{string.Join(", ", x)}]"))}]");

    }

}