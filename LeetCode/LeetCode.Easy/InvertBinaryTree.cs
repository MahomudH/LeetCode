using LeetCode.Easy.commonClasses;

namespace LeetCode.Easy
{

    public  class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }

        public void PrintTree(TreeNode node)
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
