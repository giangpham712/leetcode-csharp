namespace ConsoleApp.Problems.LeetCode.MinimumFlipsToMakeBinaryStringAlternating;

public class MinimumFlipsToMakeBinaryStringAlternatingTest
{
    [Theory]
    [InlineData("111000", 2)]
    [InlineData("010", 0)]
    [InlineData("1110", 1)]
    public void TestSolve(string input, int expected)
    {
        var solution = new MinimumFlipsToMakeBinaryStringAlternatingSolution();
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