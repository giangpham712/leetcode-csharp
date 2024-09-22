namespace ConsoleApp.Problems.LeetCode.ValidAnagram;

public class ProblemTest
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
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