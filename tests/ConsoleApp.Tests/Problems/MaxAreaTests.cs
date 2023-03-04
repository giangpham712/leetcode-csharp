using ConsoleApp.Problems;
using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems;

public class MaxAreaTests
{
    [Theory]
    [InlineData(new[] {1,8,6,2,5,4,8,3,7}, 49)]
    public void Solve(int[] height, int expected)
    {
        var solution = new MaxArea();
        var actual = solution.Solve(height);
        
        Assert.Equal(expected, actual);
    }
}