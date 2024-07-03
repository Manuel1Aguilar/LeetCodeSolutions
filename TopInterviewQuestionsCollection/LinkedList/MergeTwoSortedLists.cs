using LeetCodeSolutions.Shared;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.LinkedList;

public static class MergeTwoSortedLists
{

    private static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        //Decide the first node
        //And advance the corresponding list

        if (list1 is null && list2 is null)
        {
            return null;
        }

        if (list1 is null)
        {
            return list2;
        }
        if (list2 is null)
        {
            return list1;
        }

        ListNode firstNode;
        if (list1.val <= list2.val)
        {
            firstNode = list1;
            list1 = list1.next;
        }
        else
        {
            firstNode = list2;
            list2 = list2.next;
        }
        ListNode list = firstNode;
        //Decide the next node advancing the corresponding list
        //until both lists are null
        while (list1 is not null || list2 is not null)
        {
            if (list1 is null)
            {
                list.next = list2;
                return firstNode;
            }
            else if (list2 is null)
            {
                list.next = list1;
                return firstNode;
            }
            if (list1.val <= list2.val)
            {
                list.next = list1;
                list = list1;
                list1 = list1.next;
            }
            else
            {
                list.next = list2;
                list = list2;
                list2 = list2.next;
            }
        }
        return firstNode;
    }
    private static int[] CallMerge(int[] valList1, int[] valList2)
    {
        ListNode? list1 = ListNodeUtils.CreateFromArray(valList1);
        ListNode? list2 = ListNodeUtils.CreateFromArray(valList2);
        ListNode? res = MergeTwoLists(list1, list2);
        return [.. ListNodeUtils.ToList(res!)];
    }

    public static void CallSolution()
    {
        int[] input1;
        int[] input2;
        int[] res;

        Console.WriteLine("Merge Two Sorted Lists tests");

        input1 = [1, 2, 3];
        input2 = [1, 3, 4];
        res = CallMerge(input1, input2);
        Console.WriteLine("Inputs:");
        Console.WriteLine($"1st. {string.Join(", ", input1)}");
        Console.WriteLine($"2nd. {string.Join(", ", input2)}");
        Console.WriteLine($"Output: {string.Join(", ", res)}");


        input1 = [];
        input2 = [];
        res = CallMerge(input1, input2);
        Console.WriteLine("Inputs:");
        Console.WriteLine($"1st. {string.Join(", ", input1)}");
        Console.WriteLine($"2nd. {string.Join(", ", input2)}");
        Console.WriteLine($"Output: {string.Join(", ", res)}");


        input1 = [];
        input2 = [0];
        res = CallMerge(input1, input2);
        Console.WriteLine("Inputs:");
        Console.WriteLine($"1st. {string.Join(", ", input1)}");
        Console.WriteLine($"2nd. {string.Join(", ", input2)}");
        Console.WriteLine($"Output: {string.Join(", ", res)}");

    }

}