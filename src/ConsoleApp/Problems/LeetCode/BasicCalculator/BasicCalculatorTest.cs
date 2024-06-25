namespace ConsoleApp.Problems.LeetCode.BasicCalculator;

public class BasicCalculatorTest
{
    [Theory]
    [InlineData("1 + 1", 2)]
    [InlineData(" 2-1 + 2 ", 3)]
    [InlineData("(1+(4+5+2)-3)+(6+8)", 23)]
    [InlineData("2147483647", 2147483647)]
    [InlineData("- (3 + (4 + 5))", -12)]
    public void TestSolve(string s, int expected)
    {
        var solution = new BasicCalculatorSolution();
        var actual = solution.Solve(s);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}