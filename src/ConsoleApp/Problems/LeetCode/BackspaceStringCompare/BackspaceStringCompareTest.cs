namespace ConsoleApp.Problems.LeetCode.BackspaceStringCompare;

public class ProblemTest
{
    [Theory]
    [InlineData("ab#c", "ad#c", true)]
    [InlineData("ab##", "c#d#", true)]
    [InlineData("a#c", "b", false)]
    public void TestSolve(string s, string t, bool expected)
    {
        var solution = new ProblemSolution();
        var actual = solution.Solve(s, t);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}