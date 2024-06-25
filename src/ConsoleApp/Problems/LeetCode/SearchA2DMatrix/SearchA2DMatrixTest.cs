namespace ConsoleApp.Problems.LeetCode.SearchA2DMatrix;

public class SearchA2DMatrixTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[][] matrix, int target, bool expected)
    {
        var solution = new SearchA2DMatrixSolution();
        var actual = solution.Solve(matrix, target);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new int[][]
            {
                [1,3,5,7],[10,11,16,20],[23,30,34,60]
            },
            3,
            true
        };
        
        yield return new object[]
        {
            new int[][]
            {
                [1,3,5,7],[10,11,16,20],[23,30,34,60]
            },
            13,
            false
        };
    }
}