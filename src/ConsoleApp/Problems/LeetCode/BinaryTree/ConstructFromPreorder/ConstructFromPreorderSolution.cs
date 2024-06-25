using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.ConstructFromPreorder;

public class ConstructFromPreorderSolution
{
    public TreeNode Solve(int[] preorder)
    {
        return ConstructNode(preorder, 0, preorder.Length - 1);
    }

    private TreeNode ConstructNode(int[] preorder, int start, int end)
    {
        if (start > end)
        {
            return null;
        }

        var node = new TreeNode()
        {
            val = preorder[start]
        };

        var mid = end;
        for (int i = start + 1; i <= end; i++)
        {
            if (preorder[i] > preorder[start])
            {
                mid = i - 1;
                break;
            }
        }

        node.left = ConstructNode(preorder, start + 1, mid);
        node.right = ConstructNode(preorder, mid + 1, end);

        return node;
    }

    public TreeNode Solve2(int[] preorder)
    {
        return default;
    }
}