using LeetCodeSolutions.Shared;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.LinkedList;

public static class Reverse
{
    private static ListNode? ReverseIterative(ListNode? head)
    {
        // To reverse a linked list we need to go through the nodes in order and
        // point each node to the one that was pointing to it
        ListNode? pointer = null;
        while(head is not null)
        {
            ListNode? next = head.next;
            head.next = pointer;
            pointer = head;
            head = next;
        }
        return pointer;
    }

    private static ListNode? ReverseRecursive(ListNode head)
    {
        return ReverseRecursive(head, null);
    }

    private static ListNode? ReverseRecursive(ListNode node, ListNode? prev)
    {
        ListNode? next = node.next;
        node.next = prev;
        if(next is not null)
        {
            return ReverseRecursive(next, node);
        }
        return node;
    }
    
    private static int[] CallReverse(int[] valList)
    {
        ListNode head = ListNodeUtils.CreateFromArray(valList);
        ListNode? res = ReverseRecursive(head);
        return [.. ListNodeUtils.ToList(res!)];
    }

    public static void CallSolution()
    {
        int[] inputArray;
        int[] outputArray;

        Console.WriteLine("Reverse Linked List Tests");

        inputArray = [1, 2, 3, 4, 5];
        outputArray = CallReverse(inputArray);
        Console.WriteLine($"Input: {string.Join(", ", inputArray)}; Result: {string.Join(", ", outputArray)}");
        
        inputArray = [1, 2];
        outputArray = CallReverse(inputArray);
        Console.WriteLine($"Input: {string.Join(", ", inputArray)}; Result: {string.Join(", ", outputArray)}");
  
        inputArray = [1];
        outputArray = CallReverse(inputArray);
        Console.WriteLine($"Input: {string.Join(", ", inputArray)}; Result: {string.Join(", ", outputArray)}");
        
    }
}