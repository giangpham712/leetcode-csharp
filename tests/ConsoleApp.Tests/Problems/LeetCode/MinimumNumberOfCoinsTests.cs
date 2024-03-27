using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems.LeetCode;

public class MinimumNumberOfCoinsTests
{
    [Theory]
    [InlineData(43, "20, 20, 2, 1")]
    public void Solve(int n, string expected)
    {
        var solution = new MinimumNumberOfCoins();
        var actual = solution.Solve(n);
        
        Assert.Equal(expected.Split(",", StringSplitOptions.TrimEntries).Select(int.Parse), actual);
    }
}