using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.TrimBinarySearchTree;

public class TrimBinarySearchTreeSolution
{
    public TreeNode Solve(TreeNode root, int low, int high)
    {
        return Trim(root, low, high);
    }

    private TreeNode Trim(TreeNode? node, int low, int high)
    {
        if (node == null) 
            return null;
        
        if (node.val < low)
        {
            return Trim(node.right, low, high);
        }
        else if (node.val > high)
        {
            return Trim(node.left, low, high);
        }
        else
        {
            node.left = Trim(node.left, low, node.val);
            node.right = Trim(node.right, node.val, high);
            return node;
        }
    }
}