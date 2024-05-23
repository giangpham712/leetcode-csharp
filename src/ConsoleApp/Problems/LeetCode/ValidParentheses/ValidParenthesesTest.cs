namespace ConsoleApp.Problems.LeetCode.ValidParentheses;

public class ValidParenthesesTest
{
    [Theory]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("()", true)]
    public void TestSolve(string input, bool expected)
    {
        var solution = new ValidParenthesesSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("()", true)]
    public void TestSolve2(string input, bool expected)
    {
        var solution = new ValidParenthesesSolution2();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}