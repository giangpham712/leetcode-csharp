namespace ConsoleApp.Problems.LeetCode.CountNumberOfTeams;

public class CountNumberOfTeamsTest
{
    [Theory]
    [InlineData(new[] {2,5,3,4,1}, 3)]
    [InlineData(new[] {2,1,3}, 0)]
    [InlineData(new[] {1,2,3,4}, 4)]
    public void TestSolve(int[] rating, int expected)
    {
        var solution = new CountNumberOfTeamsSolution();
        var actual = solution.Solve(rating);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new[] {2,5,3,4,1}, 3)]
    [InlineData(new[] {2,1,3}, 0)]
    [InlineData(new[] {1,2,3,4}, 4)]
    public void TestSolve2(int[] rating, int expected)
    {
        var solution = new CountNumberOfTeamsSolution();
        var actual = solution.Solve2(rating);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}