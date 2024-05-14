namespace ConsoleApp.Problems.LeetCode.ReverseLinkedList;

/*
 * Recursive solution
 */
public class ReverseLinkedListSolution2
{
    public ListNode? Solve(ListNode? head)
    {
        if (head == null)
        {
            return null;
        }
        
        var current = head;
        ListNode? prev = null;
        
        while (current != null)
        {
            var next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}