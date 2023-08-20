using LeetCode.Easy.commonClasses;

namespace LeetCode.Easy
{
    public class MergingTwoBinary
    {
        public TreeNode MergeTrees(TreeNode tree1, TreeNode tree2)
        {
            if (tree1 == null && tree2 == null) return null;

            if(tree1 == null ) return tree2;

            if(tree2 == null ) return tree1;

            TreeNode mergedTree = new TreeNode(tree1.val +  tree2.val);
            mergedTree.left = MergeTrees(tree1.left, tree2.left);
            mergedTree.right = MergeTrees(tree1.right, tree2.right);

            return mergedTree;
        }
    }
}
