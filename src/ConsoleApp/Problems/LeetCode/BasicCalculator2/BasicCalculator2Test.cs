namespace ConsoleApp.Problems.LeetCode.BasicCalculator2;

public class BasicCalculator2Test
{
    [Theory]
    [InlineData("3+2*2", 7)]
    [InlineData(" 3/2 ", 1)]
    [InlineData(" 3+5 / 2 ", 5)]
    [InlineData("2*3+4", 10)]
    [InlineData("1*2-3/4+5*6-7*8+9/10", -24)]
    public void TestSolve(string input, int expected)
    {
        var solution = new BasicCalculator2Solution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData("3+2*2", 7)]
    [InlineData(" 3/2 ", 1)]
    [InlineData(" 3+5 / 2 ", 5)]
    [InlineData("2*3+4", 10)]
    [InlineData("1*2-3/4+5*6-7*8+9/10", -24)]
    public void TestSolve2(string input, int expected)
    {
        var solution = new BasicCalculator2Solution();
        var actual = solution.Solve2(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}