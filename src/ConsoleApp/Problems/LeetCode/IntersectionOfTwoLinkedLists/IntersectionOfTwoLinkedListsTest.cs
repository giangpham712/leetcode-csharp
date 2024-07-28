using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.IntersectionOfTwoLinkedLists;

public class IntersectionOfTwoLinkedListsTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(ListNode headA, ListNode headB, ListNode expected)
    {
        var solution = new IntersectionOfTwoLinkedListsSolution();
        var actual = solution.Solve(headA, headB);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}