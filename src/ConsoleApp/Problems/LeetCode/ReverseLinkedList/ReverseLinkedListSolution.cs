namespace ConsoleApp.Problems.LeetCode.ReverseLinkedList;

/*
 * Recursive solution
 */
public class ReverseLinkedListSolution
{
    public ListNode? Solve(ListNode? head)
    {
        if (head == null)
        {
            return null;
        }
        
        var tail = ReverseNext(head);
        head.next = null;
        return tail;
    }

    private ListNode ReverseNext(ListNode node)
    {
        if (node != null && node.next != null)
        {
            var tail = ReverseNext(node.next);
            node.next.next = node;
            return tail;
        }

        return node;
    }
}