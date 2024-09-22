using Common;
using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode;

public class LowestCommonAncestor
{
    public TreeNode? Solve(TreeNode? root, TreeNode p, TreeNode q)
    {
        if (root == null || root == p || root == q) return root;
        
        var left = Solve(root.left, p, q);
        var right = Solve(root.right, p, q);
        
        if (left == null) return right;
        if (right == null) return left;
        
        return root;
    }
}