using ConsoleApp.Problems;
using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems;

public class ValidParenthesesTests
{
    [Theory]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("()", true)]
    public void Solve(string input, bool expected)
    {
        var solution = new ValidParentheses();
        var actual = solution.Solve(input);
        
        Assert.Equal(expected, actual);
    }
}