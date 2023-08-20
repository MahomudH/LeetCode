namespace LeetCode.Core
{
    public class ListNode
    {
        public int Value;
        public ListNode Next;
        public ListNode(int value)
        {
            Value = value;
        }
        public ListNode()
        {
            
        }

        public static void PrintList(ListNode list)
        {
            while (list != null)
            {
                Console.Write(list.Value + " ");
                list = list.Next;
            }
        }
    }
}
