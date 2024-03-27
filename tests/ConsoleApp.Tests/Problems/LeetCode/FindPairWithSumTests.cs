using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems.LeetCode;

public class FindPairWithSumTests
{
    [Theory]
    [InlineData(new[] { 10, 20, 35, 50, 75, 80 }, 70, 1, 3)]
    [InlineData(new[] { 10, 20, 35, 50, 75, 80 }, 1000, -1, -1)]
    public void Solve(int[] arr, int k, int i, int j)
    {
        var solution = new FindPairWithSum();
        var actual = solution.Solve(arr, k);
        
        Assert.Equal((i, j), actual);
    }
}