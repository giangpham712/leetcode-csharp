namespace ConsoleApp.Problems.LeetCode.BuddyStrings;

public class BuddyStringsTest
{
    [Theory]
    [InlineData("ab", "ba", true)]
    [InlineData("ab", "ab", false)]
    [InlineData("aa", "aa", true)]
    [InlineData("aaaaaaabc", "aaaaaaacb", true)]
    [InlineData("abac", "abad", false)]
    public void TestSolve(string s, string goal, bool expected)
    {
        var solution = new BuddyStringsSolution();
        var actual = solution.Solve(s, goal);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}