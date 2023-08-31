using LeetCode.Easy;
using LeetCode.Core;
using LeetCode.Medium;

void printTitle(string title)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{title} :-");
    Console.ResetColor();
}
#region Easy Example

#region Diameter Of A Binary Tree

TreeNode root = new TreeNode(1);
root.left = new TreeNode(2);
root.left.left = new TreeNode(3);
root.left.right = new TreeNode(4);
root.left.right.right = new TreeNode(6);
root.left.left.left = new TreeNode(5);

int result = DiameterOfABinaryTree.DiameterOfBinaryTree(root);
printTitle("Diameter Of A Binary Tree");
Console.WriteLine($"the result must be 4  ==> the result is {result}");

#endregion

#region Valid Parantathese

string test1 = "(({[]}{}))";
string test2 = "(({[]}]{}))";

printTitle("Valid Parantathese");
Console.WriteLine($"the result must be true  ==> the result is {ValidParentheses.IsValid(test1)}");
Console.WriteLine($"the result must be false  ==> the result is {ValidParentheses.IsValid(test2)}");

#endregion

#region Palindrome Linked List

ListNode node1 = new ListNode(1);
ListNode node2 = new ListNode(2);
ListNode node3 = new ListNode(2);
ListNode node4 = new ListNode(1);
node1.Next = node2;
node2.Next = node3;
node3.Next = node4;

printTitle("Palindrome Linked List");
Console.WriteLine($"the result must be true  ==> the result is {PalindromeLinkedList.IsPalindrome(node1)}");

#endregion

#region Invert Binary Tree

TreeNode rootBeforeReverse = new TreeNode(1);
rootBeforeReverse.left = new TreeNode(2);
rootBeforeReverse.right = new TreeNode(3);
rootBeforeReverse.left.left = new TreeNode(4);
rootBeforeReverse.left.right = new TreeNode(5);
rootBeforeReverse.right.left = new TreeNode(6);
rootBeforeReverse.right.right = new TreeNode(7);

printTitle("Invert Binary Tree");
Console.WriteLine("Original Tree (pre-order traversal):");
TreeNode.PrintTree(rootBeforeReverse);
Console.WriteLine();

TreeNode invertedRoot = InvertBinaryTree.InvertTree(rootBeforeReverse);

Console.WriteLine("Inverted Tree (pre-order traversal):");
TreeNode.PrintTree(invertedRoot);
Console.WriteLine();

#endregion

#region Replace Elements with Greatest Element on Right Side

var arr = new int[] { 17, 18, 5, 4, 6, 1 };
var result5 = ReplaceElementsWithGreatestElementOnRightSide.ReplaceElements(arr);
printTitle("Replace Elements with Greatest Element on Right Side");
Console.WriteLine(string.Join(", ", result5));

#endregion

#region Merge Two Binary Tree

TreeNode tree1 = new TreeNode(1);
tree1.left = new TreeNode(2);
tree1.right = new TreeNode(3);
tree1.right.left = new TreeNode(2);
TreeNode tree2 = new TreeNode(3);
tree2.left = new TreeNode(3);
tree2.right = new TreeNode(2);
tree2.right.left = new TreeNode(5);
tree2.right.right = new TreeNode(1);

printTitle("Merge Two Binary Tree");
TreeNode.PrintTree(MergingTwoBinary.MergeTrees(tree1, tree2));

#endregion

#region Anagram

string t = "abs";
string s = "sba";
printTitle("Reverse Integer");
Console.WriteLine(Anagram.IsAnagram(s, t));

#endregion

#region Climbing Stairs

printTitle("Climbing Stairs");
Console.WriteLine(ClimbingStairs.GetClimbStairs(7));// result must equal 21

#endregion

#region Merge Two Sorted List

ListNode list1 = new ListNode(1)
{
    Next = new ListNode(3)
    {
        Next = new ListNode(5)
    }
};

ListNode list2 = new ListNode(2)
{
    Next = new ListNode(4)
    {
        Next = new ListNode(6)
    }
};

ListNode mergedList = MergeTwoSortedList.MergeTwoLists(list1, list2);

printTitle("Merged List:");
ListNode.PrintList(mergedList);
#endregion

#region Happy Number

printTitle("Happy Number:");
Console.WriteLine($"Is 19 happy number => {HappyNumber.IsHappyNumber(19)}");
Console.WriteLine($"Is 2  happy number => {HappyNumber.IsHappyNumber(2)}");

#endregion

#region Remove Linked List Elements

ListNode head = new ListNode(1);
head.Next = new ListNode(2);
head.Next.Next = new ListNode(6);
head.Next.Next.Next = new ListNode(3);
head.Next.Next.Next.Next = new ListNode(4);
head.Next.Next.Next.Next.Next = new ListNode(5);
head.Next.Next.Next.Next.Next.Next = new ListNode(6);

int val = 6;

printTitle("Remove Linked List Elements :");
Console.Write("The list before remove elements => ");
ListNode.PrintList(head);
Console.WriteLine();
ListNode newHead = RemoveLinkedListElements.RemoveElements(head, val);
Console.Write("The list after  remove elements => ");
ListNode.PrintList(newHead);

#endregion

#region Search Insert Position
int[] numbers = new int[] { 1,2,7,12,15};
printTitle("Search Insert Position :");
Console.WriteLine(SearchInsertPosition.SearchInsert(numbers , 10));
#endregion

#region Remove Duplicates From Sorted Array
int[] arrWithDuplicated = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
printTitle("Remove Duplicates From Sorted Array :");
Console.WriteLine(RemoveDuplicatesFromSortedArray.RemoveDuplicates(arrWithDuplicated));
#endregion

#region Ugly number
printTitle("Ugly number :");
Console.WriteLine(UglyNumber.IsUglyNumber(20));
Console.WriteLine(UglyNumber.IsUglyNumber(14));
#endregion

#region Length Of Last Word
printTitle("Length Of Last Word :");
Console.WriteLine(LengthOfLastWord.GetLength("Hello World "));
Console.WriteLine(LengthOfLastWord.GetLength(" "));
#endregion

#endregion

#region Medium Example


#region House Robber

var test = new int[] { 1, 5, 6, 4, 3, 2 };

printTitle("House Robber");
Console.WriteLine(HouseRobber.Rob(test));

#endregion

#region Maximum Subarray

var nums = new List<int> { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

printTitle("Maximum Subarray");
Console.WriteLine(MaximumSubarray.GetMaxSubArray(nums));

#endregion

#region Sum TwoII 

int[] sum = new int[] {1,5,6,8,10 };
printTitle("Sum TwoII");
Console.Write("[");
var result2 = SumTwoII.GetSumTwo(sum, 9);
foreach (var item in result2)
{
    Console.Write(item);
    if (item == result2[1])
        continue;
    Console.Write(", ");
}
Console.Write("]");

#endregion

#region Reverse Integer

printTitle("Reverse Integer");
Console.WriteLine(ReverseInterger.RevirseIntger(2147483641));

#endregion

#region Min Stack
printTitle("Min Stack");
MinStack minStack = new MinStack();
minStack.Push(-2);
minStack.Push(0);
minStack.Push(-3);

Console.WriteLine("Minimum element: " + minStack.GetMin()); // Output: -3

minStack.Pop();

Console.WriteLine("Top element: " + minStack.Top());       // Output: 0
Console.WriteLine("Minimum element: " + minStack.GetMin()); // Output: -2

#endregion

#endregion