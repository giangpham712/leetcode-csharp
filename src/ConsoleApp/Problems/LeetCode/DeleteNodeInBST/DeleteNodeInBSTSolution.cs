using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.DeleteNodeInBST;

public class DeleteNodeInBSTSolution
{
    public TreeNode Solve(TreeNode root, int key)
    {
        return BinarySearch(root, key);
    }

    private TreeNode BinarySearch(TreeNode node, int key)
    {
        if (node == null)
        {
            return node;
        }
        
        if (key == node.val)
        {
            if (node.right != null)
            {
                if (node.left != null)
                {
                    var current = node.right;
                    while (current.left != null)
                    {
                        current = current.left;
                    }

                    current.left = node.left;
                }
                return node.right;
            }
            else if (node.left != null)
            {
                return node.left;
            }
            else
            {
                return null;
            }
        }
        else if (key < node.val)
        {
            node.left = BinarySearch(node.left, key);
        }
        else
        {
            node.right = BinarySearch(node.right, key);
        }

        return node;
    }
}