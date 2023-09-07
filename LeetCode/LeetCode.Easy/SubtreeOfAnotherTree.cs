using LeetCode.Core;
using System.Net.Http.Headers;

namespace LeetCode.Easy
{
    public class SubtreeOfAnotherTree
    {
        public static bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if(subRoot == null) return true;
            if(root == null) return false;

            if(IsSameTree(root,subRoot))
                return true;

            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }

        private static bool IsSameTree(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return true;

            if(root1!=null && root2!= null && root1.val == root2.val)
            {
                return IsSameTree(root1.left, root2.left) && IsSameTree(root1.right, root2.right);
            }
            return false;
        }
    }
}
