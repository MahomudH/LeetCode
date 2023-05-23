using MergeTwoSortedLists;

ListNode list1 = new ListNode(1)
{
    next = new ListNode(3)
    {
        next = new ListNode(5)
    }
};

ListNode list2 = new ListNode(2)
{
    next = new ListNode(4)
    {
        next = new ListNode(6)
    }
};

ListNode mergedList = MergeTwoSortedList.MergeTwoLists(list1, list2);

Console.WriteLine("Merged List:");
while (mergedList != null)
{
    Console.Write(mergedList.val + " ");
    mergedList = mergedList.next;
}