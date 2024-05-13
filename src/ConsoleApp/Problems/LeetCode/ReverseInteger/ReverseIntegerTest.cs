namespace ConsoleApp.Problems.LeetCode.ReverseInteger;

public class ReverseIntegerTest
{
    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    [InlineData(1534236469, 0)]
    [InlineData(-2147483412, -2143847412)]
    [InlineData(-2147483648, 0)]
    public void TestSolve(int input, int expected)
    {
        var solution = new ReverseIntegerSolution();
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