using System.Text;
using LeetCodeSolutions.TopInterviewQuestionsCollection.Trees;

namespace LeetCodeSolutions.Shared;

public class TreeNode
{
    private const int SPACES = 4;
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public int Height()
    {
        return TreeHeight(this);
    }

    internal static int TreeHeight(TreeNode? root)
    {
        if (root is null)
        {
            return 0;
        }

        return Math.Max(TreeHeight(root.left), TreeHeight(root.right)) + 1;
    }

    public void Write()
    {
        List<int> vals = BreadthList();

        Console.WriteLine($"Tree values: {string.Join(", ", vals)}");
    }

public void WriteVertical()
{
    List<int> vals = BreadthList();
    int height = Height();
    int valCount = 0;
    int valsLevel = 1;
    int currLevel = 1;
    StringBuilder treeString = new();
    while (currLevel <= height)
    {
        int lvlSpace = (int)(Math.Pow(2, height - currLevel) - 1);
        int betweenSpace = (int)(Math.Pow(2, height - currLevel + 1) - 1);

        treeString.Append(new string(' ', lvlSpace));

        for (int i = 0; i < valsLevel; i++)
        {
            if (valCount > vals.Count - 1)
            {
                break;
            }
            
            treeString.Append(vals[valCount].ToString());
            
            if (i < valsLevel - 1)
            {
                treeString.Append(new string(' ', betweenSpace));
            }
            
            valCount++;
        }

        treeString.Append('\n');
        valsLevel *= 2;
        currLevel++;
    }

    Console.Write(treeString.ToString());
}

    private List<int> BreadthList()
    {
        Queue<TreeNode> queue = [];
        queue.Enqueue(this);
        List<int> vals = [];
        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();

            if (node.left is not null) { queue.Enqueue(node.left); }
            if (node.right is not null) { queue.Enqueue(node.right); }
            vals.Add(node.val);
        }

        return vals;
    }

    public void WriteComplete()
    {
        Queue<TreeNode> queue = [];
        queue.Enqueue(this);
        int height = Height();
        List<int> vals = [];
        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();

            if (node.left is not null) { queue.Enqueue(node.left); }
            if (node.right is not null) { queue.Enqueue(node.right); }
            vals.Add(node.val);
        }

        // If the last level is incomplete, continue adding -1 to fill it out
        while (vals.Count < Math.Pow(2, height) - 1)
        {
            vals.Add(-1);
        }
        Console.WriteLine($"Tree values: {string.Join(", ", vals)}");
    }

    public void WriteLtoR()
    {
        //          7
        //      3
        //          6
        //  1
        //          5
        //      2
        //          4
        WriteLtoR(this, 0);
    }

    private static void WriteLtoR(TreeNode? root, int space)
    {
        if (root is null)
        {
            return;
        }

        space += SPACES;

        WriteLtoR(root.right, space);

        Console.WriteLine($"{new string(' ', space)}{root.val}");

        WriteLtoR(root.left, space);
    }
    public static TreeNode? FromList(int?[] values)
    {
        // To do this we do a Breadth Traversal algorithm using a Queue
        TreeNode root = new();
        if (values[0] is null)
        {
            return null;
        }
        root.val = values[0]!.Value;
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int i = 1;
        while (i < values.Length)
        {
            TreeNode currNode = queue.Dequeue();

            if (i < values.Length && values[i] != null)
            {
                TreeNode left = new()
                {
                    val = values[i]!.Value
                };
                currNode.left = left;
                queue.Enqueue(left);
            }
            i++;

            if (i < values.Length && values[i] != null)
            {
                TreeNode right = new()
                {
                    val = values[i]!.Value
                };
                currNode.right = right;
                queue.Enqueue(right);
            }
            i++;
        }
        return root;
    }
}