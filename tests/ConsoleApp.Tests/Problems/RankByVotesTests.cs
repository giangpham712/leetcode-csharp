using ConsoleApp.Problems;
using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems;

public class RankByVotesTests
{
    [Theory]
    [InlineData("ABC,ACB,ABC,ACB,ACB", "ACB")]
    public void Solve(string votes, string expected)
    {
        var solution = new RankByVotes();
        var actual = solution.Solve(votes.Split(",", StringSplitOptions.TrimEntries));
        
        Assert.Equal(expected, actual);
    }
}