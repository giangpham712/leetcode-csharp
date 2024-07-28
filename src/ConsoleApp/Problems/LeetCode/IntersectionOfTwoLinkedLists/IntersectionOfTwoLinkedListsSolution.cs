using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.IntersectionOfTwoLinkedLists;

public class IntersectionOfTwoLinkedListsSolution
{
    public ListNode Solve(ListNode headA, ListNode headB)
    {
        var lengthA = 1;
        var currentA = headA;
        while (currentA.next != null) {
            currentA = currentA.next;
            lengthA++;
        }

        var lengthB = 1;
        var currentB = headB;
        while (currentB.next != null) {
            currentB = currentB.next;
            lengthB++;
        }

        if (currentA != currentB) {
            return null;
        }

        currentA = headA;
        currentB = headB;

        if (lengthA > lengthB) {
            var skip = lengthA - lengthB;
            while (skip > 0) {
                currentA = currentA.next;
                skip--;
            }
        } else if (lengthB > lengthA) {
            var skip = lengthB - lengthA;
            while (skip > 0) {
                currentB = currentB.next;
                skip--;
            }
        }

        while (currentA != currentB) {
            currentA = currentA.next;
            currentB = currentB.next;
        }

        return currentA;
    }
}