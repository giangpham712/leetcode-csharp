using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.PostorderTraversal;

/*
 * Iterative solution
 */
public class BinaryTreePostorderTraversalSolution2
{
    public IList<int> Solve(TreeNode root)
    {
        var traversal = new List<int>();

        var stack = new Stack<TreeNode>();

        var current = root;

        while (current != null)
        {
            if (current.right != null)
            {
                
            }            
        }
        
        return traversal;
    }
}