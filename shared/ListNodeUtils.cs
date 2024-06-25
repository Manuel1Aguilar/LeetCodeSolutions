namespace LeetCodeSolutions.Shared
{
    public static class ListNodeUtils
    {

        public static ListNode CreateFromArray(int[] arr)
        {
            ListNode? node = null;
            ListNode firstNode = new();
            for(int i = 0; i < arr.Length; i++)
            {
                if(node == null)
                {
                    node = new ListNode(arr[i]);
                    firstNode = node;
                }
                else
                {
                    node.next = new ListNode(arr[i]);
                    node = node.next;
                }
            }
            return firstNode;
        }

        public static List<int> ToList(ListNode listNode)
        {
            
            List<int> nodeList = [listNode.val];
            while (listNode.next != null)
            {
                listNode = listNode.next;
                nodeList.Add(listNode.val);
            }
            return nodeList;
        }

        public static ListNode GetNthChild(ListNode node, int n)
        {
            int i = 0;
            while(node.next != null && i < n)
            {
                node = node.next;
                i++;
            }
            return node;
        }
    }
}