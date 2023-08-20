﻿using LeetCode.Easy;
using LeetCode.Core;
using LeetCode.Medium;

void printTitle(string title)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{title} :-");
    Console.ResetColor();
}

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

#region Reverse Integer

printTitle("Reverse Integer");
Console.WriteLine(ReverseInterger.RevirseIntger(2147483641));

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