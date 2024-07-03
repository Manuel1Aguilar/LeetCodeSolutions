using LeetCodeSolutions.Shared;

namespace LeetCodeSolutions.TopInterviewQuestionsCollection.LinkedList
{
    public static class DeleteNthFromEnd
    {
        private static ListNode? DeleteNthNodeFromEnd(ListNode? head, int n)
        {
            if(head is null)
            {
                return null;
            }
            int length = 0;
            ListNode? countNode = head;
            while(countNode != null)
            {
                countNode = countNode.next;
                length++;
            }
            if(length == 1)
            {
                return null;
            }
            if(n == length)
            {
                return head.next;
            }
            int index = length - n;
            ListNode? pos = head.next;
            ListNode? prev = head;
            for(int i = 1; i < index; i++)
            {
                pos = pos!.next;
                prev = prev!.next;
            }
            prev!.next = pos!.next;
            
            return head;
        }

        private static int[] CallDeleteNthFromEnd(int[] valList, int n)
        {
            ListNode? head = ListNodeUtils.CreateFromArray(valList);
            ListNode? res = DeleteNthNodeFromEnd(head, n);
            return ListNodeUtils.ToList(res!).ToArray();
        }
        public static void CallSolution()
        {
            int[] valList;
            int nodeToDelete;
            int [] res;

            Console.WriteLine("Delete Nth Node From End Tests");

            valList = [1,2,3,4,5];
            nodeToDelete = 2;
            res = CallDeleteNthFromEnd(valList, nodeToDelete);
            Console.WriteLine($"Input: {string.Join(", ", valList)}; Res: {string.Join(", ", res)}"); 

        }
    }
}