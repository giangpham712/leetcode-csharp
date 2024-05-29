namespace ConsoleApp.Problems.LeetCode.TotalAppealOfAString;

public class TotalAppealOfAStringTest
{
    [Theory]
    [InlineData("abbca", 28)]
    [InlineData("code", 20)]
    public void TestSolve(string s, long expected)
    {
        var solution = new TotalAppealOfAStringSolution();
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