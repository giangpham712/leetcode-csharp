namespace ConsoleApp.Problems.LeetCode.ValidParenthesisString;

public class ValidParenthesisStringTest
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("(*)", true)]
    [InlineData("(*))", true)]
    [InlineData("(**(*()**()**((**(*)", true)]
    public void TestSolve(string input, bool expected)
    {
        var solution = new ValidParenthesisStringSolution();
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