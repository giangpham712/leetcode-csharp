using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.MergeKLists;

public class MergeKListsTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[][] input, int[] output)
    {
        var lists = new List<ListNode>();

        foreach (var arr in input)
        {
            if (!arr.Any())
            {
                lists.Add(null);
            }
            else
            {
                var head = CreateListNode(arr);
                lists.Add(head);
            }
        }
        
        var solution = new MergeKListsSolution();
        var actual = solution.Solve(lists.ToArray());

        actual.ToArray().Should().BeEquivalentTo(output);
    }

    private ListNode CreateListNode(int[] arr)
    {
        var head = new ListNode();
        head.val = arr[0];
        
        var prevNode = head;
        for (var i = 1; i < arr.Length; i++)
        {
            var nextNode = new ListNode(arr[i]);
            prevNode.next = nextNode;
            prevNode = nextNode;
        }

        return head;
    }
    
    public static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new[] { new[] { -2, -2 }, new[] { -3 } },
            new[] { -3, -2, -2 }
        };
    }
}