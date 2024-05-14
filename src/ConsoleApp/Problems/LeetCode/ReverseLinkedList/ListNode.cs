namespace ConsoleApp.Problems.LeetCode.ReverseLinkedList;

public class ListNode {
    public int val;
    public ListNode? next;
    public ListNode(int val = 0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
         
    public string ToString()
    {
        var values = new List<int>();

        var current = this;
        while (current != null)
        {
            values.Add(current.val);
            current = current.next;
        }

        return $"[{string.Join(",", values)}]";
    }
}