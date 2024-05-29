namespace ConsoleApp.Problems.LeetCode.MinimumAbsoluteDifferenceBetweenElementsWithConstraint;

public class MinimumAbsoluteDifferenceBetweenElementsWithConstraintTest
{
    [Theory]
    [InlineData(new[] {4,3,2,4}, 2, 0)]
    [InlineData(new[] {5,3,2,10,15}, 1, 1)]
    [InlineData(new[] {1,2,3,4}, 3, 3)]
    [InlineData(new[] {32,129,93}, 1, 36)]
    public void TestSolve(IList<int> nums, int x, int expected)
    {
        var solution = new MinimumAbsoluteDifferenceBetweenElementsWithConstraintSolution();
        var actual = solution.Solve(nums, x);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}