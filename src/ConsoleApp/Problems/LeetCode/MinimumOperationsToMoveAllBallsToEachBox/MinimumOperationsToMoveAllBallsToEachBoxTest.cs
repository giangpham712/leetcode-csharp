namespace ConsoleApp.Problems.LeetCode.MinimumOperationsToMoveAllBallsToEachBox;

public class MinimumOperationsToMoveAllBallsToEachBoxTest
{
    [Theory]
    [InlineData("110", new[] {1,1,3})]
    [InlineData("001011", new[] {11,8,5,4,3,4})]
    public void TestSolve(string input, int[] expected)
    {
        var solution = new MinimumOperationsToMoveAllBallsToEachBoxSolution();
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