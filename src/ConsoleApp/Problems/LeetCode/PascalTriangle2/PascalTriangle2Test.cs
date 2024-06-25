namespace ConsoleApp.Problems.LeetCode.PascalTriangle2;

public class PascalTriangle2Test
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int input, IList<int> expected)
    {
        var solution = new PascalTriangle2Solution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            3, new List<int> {1,3,3,1}
        };
        yield return new object[]
        {
            0, new List<int> {1}
        };
        yield return new object[]
        {
            1, new List<int> {1,1}
        };
    }
}