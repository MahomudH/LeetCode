using LeetCode.Core;

namespace LeetCode.Easy
{
    public class DiameterOfABinaryTree
    {
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            int diameter = 0;
            Height(root, ref diameter);
            return diameter;
        }

        private static int Height(TreeNode node, ref int diameter)
        {
            if (node == null)
            {
                return 0;
            }

            int leftHeight = Height(node.left, ref diameter);
            int rightHeight = Height(node.right, ref diameter);

            // Update diameter
            diameter = Math.Max(diameter, leftHeight + rightHeight);

            // Return height of the current node
            return 1 + Math.Max(leftHeight, rightHeight);
        }
    }

}
