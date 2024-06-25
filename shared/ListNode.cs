using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Shared
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int x) { val = x; }
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
