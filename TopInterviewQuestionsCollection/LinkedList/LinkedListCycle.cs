using LeetCodeSolutions.Shared;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.LinkedList;

public static class LinkedListCycle
{
    private static bool HasCycle(ListNode? head)
    {
        HashSet<ListNode> nodes = new();

        while (head != null)
        {
            if (!nodes.Add(head.next!))
            {
                return true;
            }
            head = head.next;
        }
        return false;
    }

    private static bool HasCycleConstantMem(ListNode? head)
    {
        ListNode? slow = head!;
        ListNode? fast = head!;
        while(fast != null && fast.next != null)
        {
            slow = slow.next!;
            fast = fast.next.next!;
            if(slow == fast)
            {
                return true;
            }
        }
        return false;
    }

    public static void CallSolution()
    {
        int[] input;
        bool res;

        Console.WriteLine("LinkedList Has Cycle Tests");

        input = [1, 2, 3, 4];
        var nodeInput = ListNodeUtils.CreateFromArray(input);
        var head = nodeInput;
        while (head!.next != null)
        {
            head = head.next;
        }
        head.next = nodeInput;
        res = HasCycleConstantMem(nodeInput);
        Console.WriteLine($"Input: {string.Join(", ", input)} (has cycle at the end); Result: {res}");


        input = [1, 2, 3, 4];
        nodeInput = ListNodeUtils.CreateFromArray(input);
        res = HasCycleConstantMem(nodeInput);
        Console.WriteLine($"Input: {string.Join(", ", input)}; Result: {res}");
    }
}