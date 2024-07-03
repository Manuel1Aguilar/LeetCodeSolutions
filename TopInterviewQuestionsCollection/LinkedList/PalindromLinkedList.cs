using LeetCodeSolutions.Shared;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.LinkedList;

public static class PalindromeLinkedList
{
    private static bool IsPalindrome(ListNode? head)
    {
        List<int> values = new();
        
        while(head != null)
        {
            values.Add(head.val);
            head = head.next;
        }
        if(values.Count == 1)
        {
            return false;
        }

        int start = 0;
        int end = values.Count - 1;
        while(start < end)
        {
            if(values[start] != values[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
    public static void CallSolution()
    {
        int[] input;
        bool res;

        Console.WriteLine("Linked List IsPalindrome tests");

        input = [1, 2, 2, 1];
        res = IsPalindrome(ListNodeUtils.CreateFromArray(input));
        Console.WriteLine($"Input: {string.Join(", ", input)}; Result: {res}");
  
        input = [1, 2];
        res = IsPalindrome(ListNodeUtils.CreateFromArray(input));
        Console.WriteLine($"Input: {string.Join(", ", input)}; Result: {res}");
   
        input = [1];
        res = IsPalindrome(ListNodeUtils.CreateFromArray(input));
        Console.WriteLine($"Input: {string.Join(", ", input)}; Result: {res}");
 }
}