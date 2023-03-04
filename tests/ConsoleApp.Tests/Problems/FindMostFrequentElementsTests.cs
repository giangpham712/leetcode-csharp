using ConsoleApp.Problems;
using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems;

public class FindMostFrequentElementsTests
{
    [Theory]
    [InlineData(new[] { 1, 1, 1, 2, 2, 3 }, 2, new [] { 1, 2 })]
    public void Solve(int[] arr, int k, int[] expected)
    {
        var solution = new FindMostFrequentElements();
        var actual = solution.Solve(arr, k);
        
        Assert.Equal(expected, actual);
    }
}