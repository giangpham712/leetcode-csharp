namespace ConsoleApp.Problems.LeetCode.LongestSubarrayWithSumAtMostK;

public class LongestSubarrayWithSumAtMostKTest
{
    [Theory]
    [InlineData(new[] {1, 2, 1, 0, 1, 1, 0}, 4, 5)]
    [InlineData(new[] {8, 2, 4, 0, 1, 1, 0}, 9, 6)]
    [InlineData(new[] {1, 2, 1, 0, 1, -8, -9, 0}, 4, 8)]
    public void TestSolve(int[] input, int k, object expected)
    {
        var solution = new LongestSubarrayWithSumAtMostKSolution();
        var actual = solution.Solve(input, k);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}