using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems.LeetCode;


public class FractionToDecimalTests
{
    [Theory]
    [InlineData(1, 3, "0.(3)")]
    [InlineData(5, 2, "2.5")]
    public void Solve(int numerator, int denominator, string expected)
    {
        var solution = new FractionToDecimal();
        var actual = solution.Solve(numerator, denominator);
        
        Assert.Equal(expected, actual);
    }
}