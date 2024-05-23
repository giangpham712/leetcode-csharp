using DataStructures.LeetCode;

namespace DataStructures.Extensions;

public static class TreeNodeExtensions
{
    public static bool IsEquivalentTo(this TreeNode? thisNode, TreeNode? thatNode)
    {
        return (thisNode == null && thatNode == null) ||
               (thisNode != null && thatNode != null &&
                thisNode.val == thatNode.val &&
                thisNode.left.IsEquivalentTo(thatNode.left) &&
                thisNode.right.IsEquivalentTo(thatNode.right));
    }
}