namespace ConsoleApp.Problems.LeetCode.CinemaSeatAllocation;

public class CinemaSeatAllocationTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int n, int[][] reservedSeats, int expected)
    {
        var solution = new CinemaSeatAllocationSolution2();
        var actual = solution.Solve(n, reservedSeats);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            3,
            new int[][]
            {
                [1,2],[1,3],[1,8],[2,6],[3,1],[3,10]
            },
            4
        };
        
        yield return new object[]
        {
            2,
            new int[][]
            {
                [2,1],[1,8],[2,6]
            },
            2
        };
        
        yield return new object[]
        {
            4,
            new int[][]
            {
                [4,3],[1,4],[4,6],[1,7]
            },
            4
        };
    }
}