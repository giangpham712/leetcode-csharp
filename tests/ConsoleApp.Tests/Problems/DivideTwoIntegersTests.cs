using ConsoleApp.Problems;
using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems;

public class DivideTwoIntegersTests
{
    [Theory]
    [InlineData(10, 3, 3)]
    [InlineData(-2147483648, -1, 2147483647)]
    [InlineData(-2147483648, 4, -536870912)]
    public void Solve(int dividend, int divisor, int expected)
    {
        var solution = new DivideTwoIntegers();
        var actual = solution.Solve(dividend, divisor);
        
        Assert.Equal(expected, actual);
    }
}