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
        
        var tail = ReverseNext(head, head.next);
        head.next = null;
        return tail;
    }

    private ListNode ReverseNext(ListNode node, ListNode? nextNode)
    {
        if (nextNode != null)
        {
            var tail = ReverseNext(nextNode, nextNode.next);
            nextNode.next = node;
            return tail;
        }

        return node;
    }
}