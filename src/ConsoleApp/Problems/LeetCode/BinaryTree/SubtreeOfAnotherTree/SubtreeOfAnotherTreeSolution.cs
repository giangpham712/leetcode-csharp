using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.SubtreeOfAnotherTree;

public class SubtreeOfAnotherTreeSolution
{
    public bool Solve(TreeNode root, TreeNode subRoot)
    {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.TryDequeue(out var node))
        {
            if (node.left != null)
            {
                queue.Enqueue(node.left);
            }

            if (node.right != null)
            {
                queue.Enqueue(node.right);
            }

            if (CompareNodes(node, subRoot))
            {
                return true;
            }
        }
        
        return false;
    }

    private bool CompareNodes(TreeNode node1, TreeNode node2)
    {
        if (node1 == null && node2 == null)
        {
            return true;
        }
        
        return node1 != null && node2 != null &&  
               node1.val == node2.val &&
               CompareNodes(node1.left, node2.left) &&
               CompareNodes(node1.right, node2.right);
    }
}