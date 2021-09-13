using LeetCode.DataStructure;

namespace LeetCode
{
    public class RemoveNthFromLinkedList
    {
        public ListNode Solve(ListNode head, int n)
        {
            if (head.next == null)
            {
                if (n == 1)
                    return null;
                return head;
            }
            ListNode currentNode = head, targetNode;
            int counter = n;
            while (currentNode.next != null && counter > 0)
            {
                currentNode = currentNode.next;
                counter--;
            }

            if (counter == 1)
                return head.next;

            targetNode = currentNode;
            currentNode = head;
            while (targetNode != null)
            {
                targetNode = targetNode.next;
                if (targetNode == null)
                {
                    currentNode.next = currentNode.next.next;
                }
                else
                {
                    currentNode = currentNode.next;
                }
            }

            return head;
        }
    }
}
