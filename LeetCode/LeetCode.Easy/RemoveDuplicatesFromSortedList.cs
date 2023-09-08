using LeetCode.Core;

namespace LeetCode.Easy
{
    public class RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.Next == null) return head;

            ListNode current = head;

            while (current.Next != null)
            {
                if (current.Value == current.Next.Value)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    current = current.Next;
                }
            }

            return head;
        }
    }
}
