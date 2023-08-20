namespace LeetCode.Core
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        public static void PrintTree(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            Console.Write(node.val + " ");
            PrintTree(node.left);
            PrintTree(node.right);
        }
    }
 
}
