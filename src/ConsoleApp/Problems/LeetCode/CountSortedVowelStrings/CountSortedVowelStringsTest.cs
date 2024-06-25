namespace ConsoleApp.Problems.LeetCode.CountSortedVowelStrings;

public class CountSortedVowelStringsTest
{
    [Theory]
    [InlineData(1, 5)]
    [InlineData(2, 15)]
    [InlineData(33, 66045)]
    [InlineData(4, 70)]
    public void TestSolve(int input, int expected)
    {
        var solution = new CountSortedVowelStringsSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(1, 5)]
    [InlineData(2, 15)]
    [InlineData(33, 66045)]
    [InlineData(4, 70)]
    public void TestSolve2(int input, int expected)
    {
        var solution = new CountSortedVowelStringsSolution();
        var actual = solution.Solve2(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}