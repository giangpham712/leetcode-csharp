using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.PreorderTraversal;

public class BinaryTreePreorderTraversalSolution2
{
    public IList<int> Solve(TreeNode? root)
    {
        var traversal = new List<int>();

        if (root == null)
        {
            return traversal;
        }
        
        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.TryPop(out var node))
        {
            traversal.Add(node.val);

            if (node.right != null)
            {
                stack.Push(node.right);
            }

            if (node.left != null)
            {
                stack.Push(node.left);
            }
        }
        
        return traversal;
    }
}