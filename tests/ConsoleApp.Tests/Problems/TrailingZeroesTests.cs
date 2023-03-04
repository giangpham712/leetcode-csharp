using ConsoleApp.Problems;
using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems;

public class TrailingZeroesTests
{
    [Theory]
    [InlineData(5, 1)]
    [InlineData(4, 0)]
    [InlineData(85, 20)]
    public void Solve(int n, int expected)
    {
        var solution = new TrailingZeroes();
        var actual = solution.Solve(n);
        
        Assert.Equal(expected, actual);
    }
}