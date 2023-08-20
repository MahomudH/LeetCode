using LeetCode.Core;

namespace LeetCode.Easy
{
    public class MergeTwoSortedList
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode mergedList = new ListNode();
            ListNode current = mergedList;

            while (list1 != null && list2 != null)
            {
                if (list1.Value <= list2.Value)
                {
                    current.Next = list1;
                    list1 = list1.Next;
                }
                else
                {
                    current.Next = list2;
                    list2 = list2.Next;
                }
                current = current.Next;
            }

            if (list1 != null)
            {
                current.Next = list1;
            }

            if (list2 != null)
            {
                current.Next = list2;
            }

            return mergedList.Next;
        }
    }
}
