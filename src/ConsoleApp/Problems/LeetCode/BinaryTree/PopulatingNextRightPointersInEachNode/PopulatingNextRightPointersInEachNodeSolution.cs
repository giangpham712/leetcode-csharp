using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.PopulatingNextRightPointersInEachNode;

public class PopulatingNextRightPointersInEachNodeSolution
{
    public Node Solve(Node root)
    {
        Connect(root, null);
        return root;
    }

    private void Connect(Node node, Node neighbourNode)
    {
        if (node == null || node.left == null || node.right == null)
            return;
        
        node.left.next = node.right;
        node.right.next = neighbourNode;

        Connect(node.left, node.right?.left);
        Connect(node.right, neighbourNode?.left);
    }
}