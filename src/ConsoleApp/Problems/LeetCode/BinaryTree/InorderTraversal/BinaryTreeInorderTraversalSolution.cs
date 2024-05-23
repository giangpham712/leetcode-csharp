using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.InorderTraversal;

/*
 * Recursive solution

 */
public class BinaryTreeInorderTraversalSolution
{
    public IList<int> Solve(TreeNode? root)
    {
        var traversal = new List<int>();

        if (root == null)
        {
            return traversal;
        }

        Traverse(root, traversal);
        
        return traversal;
    }

    public void Traverse(TreeNode node, List<int> traversal)
    {
        if (node.left != null)
        {
            Traverse(node.left, traversal);
        }
        
        traversal.Add(node.val);
        
        if (node.right != null)
        {
            Traverse(node.right, traversal);
        }
    }
}