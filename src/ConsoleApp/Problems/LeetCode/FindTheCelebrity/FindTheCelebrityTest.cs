using ConsoleApp.Problems.LeetCode.Problem;

namespace ConsoleApp.Problems.LeetCode.FindTheCelebrity;

public class FindTheCelebrityTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[][] input, int expected)
    {
        var solution = new FindTheCelebritySolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new int[][]
            {
                [1,1,0],
                [0,1,0],
                [1,1,1]
            },
            1
        };
        
        yield return new object[]
        {
            new int[][]
            {
                [1,0,1],
                [1,1,0],
                [0,1,1]
            },
            -1
        };
        
        yield return new object[]
        {
            new int[][]
            {
                [0,0,1,0],
                [0,0,1,0],
                [0,0,0,0],
                [0,0,1,0],
            },
            2
        };
    }
}