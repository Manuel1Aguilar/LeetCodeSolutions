using LeetCodeSolutions.AddTwoReversedLinkedListNumbers;
using LeetCodeSolutions.Shared;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.LinkedList
{
    public static class DeleteNode
    {
        private static void DeleteNodeFromLinkedList(ListNode? node)
        {
            if(node is null)
            {
                return;
            }
            node.val = node.next!.val;
            node.next = node.next.next;
        }

        public static void CallSolution()
        {
            int[] input;
            int[] res;
            ListNode? nodeList;
            ListNode? nodeInput;

            Console.WriteLine("Delete List Node Tests");

            input = [1, 2, 3, 4, 5];
            nodeList = ListNodeUtils.CreateFromArray(input);
            nodeInput = ListNodeUtils.GetNthChild(nodeList, 2);
            DeleteNodeFromLinkedList(nodeInput);
            res = [.. ListNodeUtils.ToList(nodeList)];
            Console.WriteLine($"Input: {string.Join(", ", input)}; Res: {string.Join(", ", res)}");

            
            input = [4, 1, 9];
            nodeList = ListNodeUtils.CreateFromArray(input);
            nodeInput = ListNodeUtils.GetNthChild(nodeList, 1);
            DeleteNodeFromLinkedList(nodeInput);
            res = [.. ListNodeUtils.ToList(nodeList)];
            Console.WriteLine($"Input: {string.Join(", ", input)}; Res: {string.Join(", ", res)}");

            
            input = [7, 3, 4, 5, 6, 8];
            nodeList = ListNodeUtils.CreateFromArray(input);
            nodeInput = ListNodeUtils.GetNthChild(nodeList, 4);
            Console.WriteLine($"NodeInput Val: {nodeInput!.val}");
            DeleteNodeFromLinkedList(nodeInput);
            res = [.. ListNodeUtils.ToList(nodeList)];
            Console.WriteLine($"Input: {string.Join(", ", input)}; Res: {string.Join(", ", res)}");

        }
    }
}