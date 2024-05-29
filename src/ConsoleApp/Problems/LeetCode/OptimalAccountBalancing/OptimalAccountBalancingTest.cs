namespace ConsoleApp.Problems.LeetCode.OptimalAccountBalancing;

public class OptimalAccountBalancingTest
{
    [Theory]
    [InlineData(default, default)]
    public void TestSolve(object input, object expected)
    {
        var solution = new OptimalAccountBalancingSolution();
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