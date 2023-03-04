using ConsoleApp.Problems;
using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems;

public class RomanToIntTests
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void Solve(string roman, int expected)
    {
        var solution = new RomanToInt();
        var actual = solution.Solve(roman);
        
        Assert.Equal(expected, actual);
    }
}