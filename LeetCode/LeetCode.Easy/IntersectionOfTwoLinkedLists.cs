using LeetCode.Core;

namespace LeetCode.Easy;

public class IntersectionOfTwoLinkedLists
{
    public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null) return null;

        int lengthA = getLength(headA);
        int lengthB = getLength(headB);

        while (lengthA > lengthB)
        {
            headA = headA.Next;
            lengthA--;
        }

        while (lengthA < lengthB)
        {
            headB = headB.Next;
            lengthB--;
        }

        while (headA != null && headB != null)
        {
            if(headA.Value == headB.Value) return headA;
            headA = headA.Next;
            headB = headB.Next;
        }

        return null;
    }

    private static int getLength(ListNode head)
    {
        int length = 0;
        while (head != null)
        {
            length++;
            head = head.Next;
        }

        return length;
    }
}

