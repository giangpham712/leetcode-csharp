using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems.LeetCode;

public class SmallestPositiveTests
{
    [Theory]
    [InlineData(new[] {1, 10, 3, 11, 6, 15}, 2)]
    public void Solve(int[] height, int expected)
    {
        var solution = new SmallestPositive();
        var actual = solution.Solve(height);
        
        Assert.Equal(expected, actual);
    }
}