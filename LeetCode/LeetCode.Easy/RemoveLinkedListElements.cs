using LeetCode.Core;

namespace LeetCode.Easy
{
    public class RemoveLinkedListElements
    {
        public static ListNode RemoveElements(ListNode head, int val)
        {
            ListNode dummy = new ListNode(-1);
            dummy.Next = head;

            ListNode current = dummy;

            while (current.Next != null)
            {
                if (current.Next.Value == val)
                    current.Next = current.Next.Next;
                else
                    current = current.Next;        
            }

            return dummy.Next;
        }
    }
}
