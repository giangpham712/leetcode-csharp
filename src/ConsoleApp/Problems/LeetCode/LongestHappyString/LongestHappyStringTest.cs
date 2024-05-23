namespace ConsoleApp.Problems.LeetCode.LongestHappyString;

public class LongestHappyStringTest
{
    [Theory]
    [InlineData(1, 1, 7, "ccaccbcc")]
    [InlineData(7, 1, 0, "aabaa")]
    public void TestSolve(int a, int b, int c, string expected)
    {
        var solution = new LongestHappyStringSolution();
        var actual = solution.Solve(a, b, c);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}