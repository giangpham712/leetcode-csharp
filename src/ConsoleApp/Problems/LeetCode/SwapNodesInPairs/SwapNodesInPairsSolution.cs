using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.SwapNodesInPairs;

public class SwapNodesInPairsSolution
{
    public ListNode Solve(ListNode head)
    {
        return Swap(head);
    }

    private ListNode Swap(ListNode node)
    {
        if (node != null && node.next != null)
        {
            var next = node.next;
            var nextNext = Swap(next.next);

            node.next.next = node;
            node.next = nextNext;

            return next;
        }

        return node;
    }
}