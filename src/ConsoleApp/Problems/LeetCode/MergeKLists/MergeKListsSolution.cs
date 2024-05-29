namespace ConsoleApp.Problems.LeetCode.MergeKLists;

/*
 * 
 */
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