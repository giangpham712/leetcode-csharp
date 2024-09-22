namespace ConsoleApp.Problems.LeetCode.MaxAreaOfIsland;

public class MaxAreaOfIslandTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[][] input, int expected)
    {
        var solution = new MaxAreaOfIslandSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
    
    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new int[][]
            {
                new[] { 0,0,1,0,0,0,0,1,0,0,0,0,0 }, 
                new[] { 0,0,0,0,0,0,0,1,1,1,0,0,0 }, 
                new[] { 0,1,1,0,1,0,0,0,0,0,0,0,0 },
                new[] { 0,1,0,0,1,1,0,0,1,0,1,0,0 },
                new[] { 0,1,0,0,1,1,0,0,1,1,1,0,0 },
                new[] { 0,0,0,0,0,0,0,0,0,0,1,0,0 },
                new[] { 0,0,0,0,0,0,0,1,1,1,0,0,0 },
                new[] { 0,0,0,0,0,0,0,1,1,0,0,0,0 },
            },
            6
        };

        yield return new object[]
        {
            new int[][]
            {
                new[] { 0,0,0,0,0,0,0,0 }
            },
            0
        };
    }
}