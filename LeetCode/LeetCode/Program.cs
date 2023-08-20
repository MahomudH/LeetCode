using LeetCode.Easy;
using LeetCode.Easy.commonClasses;
using LeetCode.Medium;

void printTitle(string title)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();
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

DiameterOfABinaryTree solution1 = new DiameterOfABinaryTree();
int result = solution1.DiameterOfBinaryTree(root);
printTitle("Diameter Of A Binary Tree");
Console.WriteLine($"the result must be 4  ==> the result is {result}");

#endregion

#region Valid Parantathese

string test1 = "(({[]}{}))";
string test2 = "(({[]}]{}))";

ValidParentheses solution2 = new ValidParentheses();
printTitle("Valid Parantathese");
Console.WriteLine($"the result must be true  ==> the result is {solution2.IsValid(test1)}");
Console.WriteLine($"the result must be false  ==> the result is {solution2.IsValid(test2)}");

#endregion

#region Palindrome Linked List

ListNode node1 = new ListNode(1);
ListNode node2 = new ListNode(2);
ListNode node3 = new ListNode(2);
ListNode node4 = new ListNode(1);
node1.Next = node2;
node2.Next = node3;
node3.Next = node4;

PalindromeLinkedList solution = new PalindromeLinkedList();
printTitle("Palindrome Linked List");
Console.WriteLine($"the result must be true  ==> the result is {solution.IsPalindrome(node1)}");

#endregion

#region Invert Binary Tree

TreeNode rootBeforeReverse = new TreeNode(1);
rootBeforeReverse.left = new TreeNode(2);
rootBeforeReverse.right = new TreeNode(3);
rootBeforeReverse.left.left = new TreeNode(4);
rootBeforeReverse.left.right = new TreeNode(5);
rootBeforeReverse.right.left = new TreeNode(6);
rootBeforeReverse.right.right = new TreeNode(7);

InvertBinaryTree inversion = new InvertBinaryTree();
printTitle("Invert Binary Tree");
Console.WriteLine("Original Tree (pre-order traversal):");
inversion.PrintTree(rootBeforeReverse);
Console.WriteLine();

TreeNode invertedRoot = inversion.InvertTree(rootBeforeReverse);

Console.WriteLine("Inverted Tree (pre-order traversal):");
inversion.PrintTree(invertedRoot);
Console.WriteLine();

#endregion

#region Replace Elements with Greatest Element on Right Side

var solution5 = new ReplaceElementsWithGreatestElementOnRightSide();
var arr = new int[] { 17, 18, 5, 4, 6, 1 };
var result5 = solution5.ReplaceElements(arr);
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

var solution6 = new MergingTwoBinary();
printTitle("Merge Two Binary Tree");
inversion.PrintTree(solution6.MergeTrees(tree1, tree2));

#endregion

#region Reverse Integer

var solution7 = new ReverseInterger();
printTitle("Reverse Integer");
Console.WriteLine(solution7.RevirseIntger(2147483641));

#endregion
