namespace ConsoleApp.Problems.LeetCode.AddTwoNumbers;

public class ProblemTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void AddTwoNumbersTest(ListNode l1, ListNode l2, ListNode expected)
    {
        var solution = new AddTwoNumbersSolution();
        var actual = solution.Solve(l1, l2);

        Assert.Equal(expected.ToString(), actual.ToString());
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new ListNode { val = 2, next = new ListNode { val = 4, next = new ListNode { val = 3 }}},
            new ListNode { val = 5, next = new ListNode { val = 6, next = new ListNode { val = 4 }}},
            new ListNode { val = 7, next = new ListNode { val = 0, next = new ListNode { val = 8 }}},
        };
    }
}