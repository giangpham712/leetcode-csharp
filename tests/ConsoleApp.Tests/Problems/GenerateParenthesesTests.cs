using ConsoleApp.Problems;
using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems;

public class GenerateParenthesesTests
{
    [Theory]
    [InlineData(3, "")]
    public void Solve(int n, string expected)
    {
        var solution = new GenerateParentheses();
        var actual = solution.Solve(n);
        
        
    }
}