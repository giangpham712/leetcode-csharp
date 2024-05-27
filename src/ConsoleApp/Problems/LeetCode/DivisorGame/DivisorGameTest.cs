namespace ConsoleApp.Problems.LeetCode.DivisorGame;

public class DivisorGameTest
{
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    public void TestSolve(int input, bool expected)
    {
        var solution = new DivisorGameSolution();
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