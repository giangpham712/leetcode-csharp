namespace ConsoleApp.Problems.LeetCode.ReverseLinkedList;

public class ReverseLinkedListTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(ListNode? head, string expected)
    {
        var solution = new ReverseLinkedListSolution();
        var actual = solution.Solve(head);

        Assert.Equal(expected, actual == null ? "[]" : actual.ToString());
    }
    
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve2(ListNode? head, string expected)
    {
        var solution = new ReverseLinkedListSolution2();
        var actual = solution.Solve(head);

        Assert.Equal(expected, actual == null ? "[]" : actual.ToString());
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 2,
                    next = new ListNode
                    {
                        val = 3,
                        next = new ListNode
                        {
                            val = 4,
                            next = new ListNode
                            {
                                val = 5,
                            }
                        }
                    }
                }
            },
            "[5,4,3,2,1]"
        };

        yield return new object[]
        {
            new ListNode()
            {
                val = 1,
                next = new ListNode()
                {
                    val = 2,
                }
            },
            "[2,1]"
        };

        yield return new object[]
        {
            null,
            "[]"
        };
    }
}