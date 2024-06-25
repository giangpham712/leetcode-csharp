namespace ConsoleApp.Problems.LeetCode.DivideAStringIntoGroupsOfSizeK;

public class DivideAStringIntoGroupsOfSizeKTest
{
    [Theory]
    [InlineData("abcdefghi", 3, 'x', new[] {"abc","def","ghi"})]
    [InlineData("abcdefghij", 3, 'x', new[] {"abc","def","ghi","jxx"})]
    public void TestSolve(string s, int k, char fill, string[] expected)
    {
        var solution = new DivideAStringIntoGroupsOfSizeKSolution();
        var actual = solution.Solve(s, k, fill);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}