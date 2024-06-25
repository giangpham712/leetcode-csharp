namespace ConsoleApp.Problems.LeetCode.LeastNumberOfUniqueIntegersAfterKRemovals;

public class LeastNumberOfUniqueIntegersAfterKRemovalsTest
{
    [Theory]
    [InlineData(new[] {5,5,4}, 1, 1)]
    [InlineData(new[] {4,3,1,1,3,3,2}, 3, 2)]
    public void TestSolve(int[] arr, int k, int expected)
    {
        var solution = new LeastNumberOfUniqueIntegersAfterKRemovalsSolution();
        var actual = solution.Solve(arr, k);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}