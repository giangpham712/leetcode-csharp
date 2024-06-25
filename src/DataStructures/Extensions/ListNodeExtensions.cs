using DataStructures.LeetCode;

namespace DataStructures.Extensions;

public static class ListNodeExtensions
{
    public static bool IsEquivalentTo(this ListNode? thisNode, ListNode? thatNode)
    {
        return (thisNode == null && thatNode == null) ||
               (thisNode != null && thatNode != null &&
                thisNode.val == thatNode.val &&
                thisNode.next.IsEquivalentTo(thatNode.next));
    }
}