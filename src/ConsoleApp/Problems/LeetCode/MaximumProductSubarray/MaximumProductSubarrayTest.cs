namespace ConsoleApp.Problems.LeetCode.MaximumProductSubarray;

public class MaximumProductSubarrayTest
{
    [Theory]
    [InlineData(default, default)]
    public void TestSolve(object input, object expected)
    {
        var solution = new MaximumProductSubarraySolution();
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