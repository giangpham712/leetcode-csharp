using Common;

namespace ConsoleApp.Problems.LeetCode;

public class LowestCommonAncestor
{
    public TreeNode? Solve(TreeNode? root, TreeNode p, TreeNode q)
    {
        if (root == null || root == p || root == q) return root;
        
        var left = Solve(root.Left, p, q);
        var right = Solve(root.Right, p, q);
        
        if (left == null) return right;
        if (right == null) return left;
        
        return root;
    }
}