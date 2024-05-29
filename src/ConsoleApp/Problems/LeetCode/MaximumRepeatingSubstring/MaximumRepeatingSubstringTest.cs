namespace ConsoleApp.Problems.LeetCode.MaximumRepeatingSubstring;

public class MaximumRepeatingSubstringTest
{
    [Theory]
    [InlineData("ababc", "ab", 2)]
    [InlineData("ababc", "ba", 1)]
    [InlineData("ababc", "ac", 0)]
    [InlineData("aaabaaaabaaabaaaabaaaabaaaabaaaaba", "aaaba", 5)]
    public void TestSolve(string sequence, string word, int expected)
    {
        var solution = new MaximumRepeatingSubstringSolution();
        var actual = solution.Solve(sequence, word);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}