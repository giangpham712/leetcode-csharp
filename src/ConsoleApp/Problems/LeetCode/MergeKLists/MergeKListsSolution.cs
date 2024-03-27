namespace ConsoleApp.Problems.LeetCode.MergeKLists;

public class MergeKListsSolution
{
    public ListNode Solve(ListNode[] lists)
    {
        var nonEmptyLists = lists.Where(l => l != null).ToList();
        if (!nonEmptyLists.Any()) {
            return null;
        }

        if (nonEmptyLists.Count() == 1) {
            return nonEmptyLists.First();
        }

        var allNodes = new List<ListNode>();
        foreach (var headNode in nonEmptyLists) {
            var currentNode = headNode;
            while (currentNode != null) {
                allNodes.Add(currentNode);
                currentNode = currentNode.next;
            }
        }

        allNodes = allNodes.OrderBy(n => n.val).ToList();

        ListNode prevNode = null;
        foreach (var node in allNodes) {
            if (prevNode != null) {
                prevNode.next = node;
            }

            prevNode = node;
        }

        return allNodes.First();
    }
}

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