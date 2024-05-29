namespace ConsoleApp.Problems.LeetCode.CountNumberOfSpecialChars2;

public class CountNumberOfSpecialChars2Test
{
    [Theory]
    [InlineData("aaAbcBC", 3)]
    [InlineData("abc", 0)]
    [InlineData("AbBCab", 0)]
    [InlineData("AbcbDBdD", 1)]
    [InlineData("amvjmbhcppYILSJSJQVI", 2)]
    public void TestSolve(string input, int expected)
    {
        var solution = new CountNumberOfSpecialChars2Solution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData("aaAbcBC", 3)]
    [InlineData("abc", 0)]
    [InlineData("AbBCab", 0)]
    [InlineData("AbcbDBdD", 1)]
    [InlineData("amvjmbhcppYILSJSJQVI", 2)]
    public void TestSolve2(string input, int expected)
    {
        var solution = new CountNumberOfSpecialChars2Solution2();
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