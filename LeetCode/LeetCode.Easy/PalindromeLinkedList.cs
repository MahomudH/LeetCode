namespace LeetCode.Easy
{
    public class ListNode
    {
        public int Value;
        public ListNode Next;
        public ListNode(int value)
        {
            Value = value;
        }
    }
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            if(head == null || head.Next == null) return true;

            //Step 1: Find middle of the list 
            ListNode slow = head, fast = head;
            while(fast != null &&  fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            //Step 2: Reverse the second half
            ListNode prev = null, next = null;
            while(slow != null)
            {
                next = slow.Next;
                slow.Next = prev;
                prev = slow;
                slow = next;
            }

            //Step 3: Compare two halves
            ListNode firsthalf = head;
            ListNode secondHalf = prev;
            while(secondHalf != null)
            {
                if(firsthalf.Value != secondHalf.Value)
                    return false;
                
                firsthalf = firsthalf.Next;
                secondHalf = secondHalf.Next;
            }

            return true;

        }
    }
}
