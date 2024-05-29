namespace ConsoleApp.Problems.LeetCode.MergeKLists;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val; 
        this.next = next;
    }

    public int[] ToArray()
    {
        var list = new List<int>();
        var currentNode = this;
        while (currentNode != null)
        {
            list.Add(currentNode.val);
            currentNode = currentNode.next;
        }

        return list.ToArray();
    }
}