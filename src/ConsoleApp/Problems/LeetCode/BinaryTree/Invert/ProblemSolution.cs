using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.Invert;

public class InvertBinaryTreeSolution
{
    public TreeNode Solve(TreeNode root)
    {
        Invert(root);
        return root;
    }

    private void Invert(TreeNode node)
    {
        if (node == null || (node.left == null && node.right == null))
        {
            return;
        }
        
        (node.left, node.right) = (node.right, node.left);
        Invert(node.left);
        Invert(node.right);
    }
}