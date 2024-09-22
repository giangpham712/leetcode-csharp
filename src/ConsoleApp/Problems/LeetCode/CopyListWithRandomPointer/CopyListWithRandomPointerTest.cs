using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.CopyListWithRandomPointer;

public class CopyListWithRandomPointerTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(Node input, Node expected)
    {
        var solution = new CopyListWithRandomPointerSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}