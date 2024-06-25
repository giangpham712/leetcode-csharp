namespace ConsoleApp.Problems.LeetCode.CountNumberOfPairsWithAbsoluteDifferenceK;

public class CountNumberOfPairsWithAbsoluteDifferenceKTest
{
    [Theory]
    [InlineData(new[] {1,2,2,1}, 1, 4)]
    [InlineData(new[] {1,3}, 3, 0)]
    [InlineData(new[] {3,2,1,5,4}, 2, 3)]
    [InlineData(new[] {9,3,1,1,4,5,4,9,5,10}, 1, 8)]
    public void TestSolve(int[] nums, int k, int expected)
    {
        var solution = new CountNumberOfPairsWithAbsoluteDifferenceKSolution();
        var actual = solution.Solve(nums, k);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}