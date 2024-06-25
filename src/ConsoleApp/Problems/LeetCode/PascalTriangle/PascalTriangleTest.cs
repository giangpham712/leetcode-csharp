namespace ConsoleApp.Problems.LeetCode.PascalTriangle;

public class PascalTriangleTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int input, IList<IList<int>> expected)
    {
        var solution = new PascalTriangleSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            5,
            new int[][]
            {
                [1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]
            }
        };
        
        yield return new object[]
        {
            1,
            new int[][]
            {
                [1]
            }
        };
    }
}