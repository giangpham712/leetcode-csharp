using ConsoleApp.Problems;
using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems;

public class FindMaxConsecutiveSumTests
{
    [Theory]
    [InlineData(new[] { 100, 200, 300, 400 }, 2, 700)]
    [InlineData(new[] { 1, 4, 2, 10, 23, 4, 1, 0, 20 }, 4, 39)]
    public void Solve(int[] arr, int k, int expected)
    {
        var solution = new FindMaxConsecutiveSum();
        var actual = solution.Solve(arr, k);
        
        Assert.Equal(expected, actual);
    }
}