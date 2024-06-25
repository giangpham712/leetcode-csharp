namespace ConsoleApp.Problems.LeetCode.TransposeMatrix;

public class TransposeMatrixTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[][] input, int[][] expected)
    {
        var solution = new TransposeMatrixSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new int[][]
            {
                [1,2,3],[4,5,6],[7,8,9]
            },
            new int[][]
            {
                [1,4,7],[2,5,8],[3,6,9]
            }
        };
        
        yield return new object[]
        {
            new int[][]
            {
                [1,2,3],[4,5,6]
            },
            new int[][]
            {
                [1,4],[2,5],[3,6]
            }
        };
    }
}