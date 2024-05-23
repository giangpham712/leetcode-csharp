using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.CountGoodNodes;

public class CountGoodNodesSolution
{
    public int Solve(TreeNode root)
    {
        return CountGoodNodes(root, int.MinValue);
    }

    private int CountGoodNodes(TreeNode node, int max)
    {
        if (node == null)
        {
            return 0;
        }

        return (node.val >= max ? 1 : 0) +
               CountGoodNodes(node.left, node.val > max ? node.val : max) +
               CountGoodNodes(node.right, node.val > max ? node.val : max);
    }
}