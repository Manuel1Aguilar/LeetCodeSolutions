using LeetCodeSolutions.Shared;

namespace LeetCodeSolutions.AddTwoReversedLinkedListNumbers
{
    public class SumOfTwoReversedLinkedListNumbers
    {
        public ListNode? AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return AddNodes(l1, l2, false);
        }
        public ListNode? AddNodes(ListNode? l1, ListNode? l2, bool overflows)
        {
            if (l1 is null && l2 is null)
            {
                if (overflows)
                {
                    return new ListNode() { next = null, val = 1 };
                }
                return null;
            }
            ListNode response = new ListNode();
            int l1Val = 0;
            int l2Val = 0;
            if(l1 is not null)
            {
                l1Val = l1.val;
            }
            if (l2 is not null)
            {
                l2Val = l2.val;
            }
            int val = l1Val + l2Val;
            if (overflows) { val += 1; }
            if (val >= 10)
            {
                overflows = true;
                response.val = val - 10;
            }
            else
            {
                overflows = false;
                response.val = val;
            }
            response.next = AddNodes(l1?.next, l2?.next, overflows);
            return response;
        }

        public ListNode? CreateNodes(int[] l1Ints)
        {
            if(l1Ints.Length == 0) { return null; }
            ListNode response = new ListNode();
            response.val = l1Ints[0];
            response.next = CreateNodes(l1Ints.Skip(1).ToArray());
            return response;
        }

    }
}
