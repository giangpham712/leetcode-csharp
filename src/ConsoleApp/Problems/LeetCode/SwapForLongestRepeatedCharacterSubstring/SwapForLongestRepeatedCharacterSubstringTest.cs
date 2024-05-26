namespace ConsoleApp.Problems.LeetCode.SwapForLongestRepeatedCharacterSubstring;

public class SwapForLongestRepeatedCharacterSubstringTest
{
    [Theory]
    [InlineData("ababa", 3)]
    [InlineData("aaabaaa", 6)]
    [InlineData("aaaaa", 5)]
    [InlineData("bbababaaaa", 6)]
    public void TestSolve(string input, int expected)
    {
        var solution = new SwapForLongestRepeatedCharacterSubstringSolution();
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