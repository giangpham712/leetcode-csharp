using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems.LeetCode;

public class MinCoinChangeTests
{
    [Theory]
    [InlineData("1, 2, 5", 11, 3)]
    [InlineData("2", 3, -1)]
    public void BottomUp_Solve(string coins, int amount, int expected)
    {
        var solution = new MinCoinChange.BottomUp();
        var actual = solution.Solve(coins.Split(",", StringSplitOptions.TrimEntries).Select(int.Parse).ToArray(), amount);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData("1, 2, 5", 11, 3)]
    [InlineData("2", 3, -1)]
    public void TopDown_Solve(string coins, int amount, int expected)
    {
        var solution = new MinCoinChange.TopDown();
        var actual = solution.Solve(coins.Split(",", StringSplitOptions.TrimEntries).Select(int.Parse).ToArray(), amount);
        
        Assert.Equal(expected, actual);
    }
}