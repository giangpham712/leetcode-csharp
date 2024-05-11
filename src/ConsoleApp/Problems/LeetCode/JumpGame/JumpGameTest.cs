namespace ConsoleApp.Problems.LeetCode.JumpGame;

public class JumpGameTest
{
    [Theory]
    [InlineData(new[] {2,3,1,1,4}, true)]
    [InlineData(new[] {3,2,1,0,4}, false)]
    public void TestSolve(int[] input, bool expected)
    {
        var solution = new JumpGameSolution2();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
}