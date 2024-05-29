namespace ConsoleApp.Problems.LeetCode.TrapRainWater;

public class TrapRainWaterTest
{
    [Theory]
    [InlineData(new int[] { 0,1,0,2,1,0,1,3,2,1,2,1 }, 6)]
    [InlineData(new int[] { 4,2,0,3,2,5 }, 9)]
    public void TestSolve(int[] input, int expected)
    {
        var solution = new TrapRainWaterSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new int[] { 0,1,0,2,1,0,1,3,2,1,2,1 }, 6)]
    [InlineData(new int[] { 4,2,0,3,2,5 }, 9)]
    public void TestSolve2(int[] input, int expected)
    {
        var solution = new TrapRainWaterSolution2();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
}