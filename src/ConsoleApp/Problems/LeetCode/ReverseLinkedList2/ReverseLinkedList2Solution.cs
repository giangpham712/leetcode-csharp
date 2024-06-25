using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.ReverseLinkedList2;

public class ReverseLinkedList2Solution
{
    #region Solve
    
    public ListNode Solve(ListNode head, int left, int right)
    {
        if (left == right)
        {
            return head;
        }
        
        var index = 0;

        ListNode prev = null;
        var current = head;
        while (index < left - 1 && current.next != null)
        {
            prev = current;
            current = current.next;
            index++;
        }
        
        var (node1, node2) = ReverseNext(current, right - left);

        if (left > 1)
        {
            current.next = node2;
            prev.next = node1;

            return head;
        }
        
        current.next = node2;
        return node1;
    }

    private (ListNode, ListNode) ReverseNext(ListNode node, int times)
    {
        var next = node.next;

        if (next == null)
        {
            return (node, null);
        }

        var nextNext = next.next;

        if (times - 1 > 0)
        {
            var (node1, node2) = ReverseNext(node.next, times - 1);

            next.next = node;

            return (node1, node2);
        }
        else
        {
            next.next = node;
            return (next, nextNext);
        }
        
    }
    
    #endregion

    #region Solve2

    public ListNode Solve2(ListNode head, int left, int right)
    {
        return default;
    }

    #endregion
}