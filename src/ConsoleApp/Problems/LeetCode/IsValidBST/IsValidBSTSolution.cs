using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.IsValidBST;

public class IsValidBSTSolution
{
    public object Solve(TreeNode root)
    {
        return IsValid(root, long.MinValue, long.MaxValue);
    }
    
    private bool IsValid(TreeNode? node, long smallest, long largest) 
    {
        if (node == null) {
            return true;
        }

        return node.val > smallest && 
               node.val < largest &&
               IsValid(node.left, smallest, node.val) &&
               IsValid(node.right, node.val, largest);
    }
}