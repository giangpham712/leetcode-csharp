using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.RotateList;

public class RotateListSolution
{
    public ListNode Solve(ListNode head, int k)
    {
        if (head == null || head.next == null)
        {
            return head;
        }
        
        var count = 0;
        var current = head;
        while (current != null)
        {
            count++;
            current = current.next;
        }

        k = k % count;
        
        
        
        return default;
    }
}