namespace ConsoleApp.Problems.LeetCode.RankTeamsByVotes;

public class RankTeamsByVotesTest
{
    [Theory]
    [InlineData(new[] {"ABC","ACB","ABC","ACB","ACB"}, "ACB")]
    [InlineData(new[] {"WXYZ","XYZW"}, "XWYZ")]
    [InlineData(new[] {"ZMNAGUEDSJYLBOPHRQICWFXTVK"}, "ZMNAGUEDSJYLBOPHRQICWFXTVK")]
    public void TestSolve(string[] input, string expected)
    {
        var solution = new RankTeamsByVotesSolution();
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