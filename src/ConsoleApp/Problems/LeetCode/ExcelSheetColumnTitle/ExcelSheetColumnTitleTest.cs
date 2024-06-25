namespace ConsoleApp.Problems.LeetCode.ExcelSheetColumnTitle;

public class ExcelSheetColumnTitleTest
{
    [Theory]
    [InlineData(1, "A")]
    [InlineData(28, "AB")]
    [InlineData(701, "ZY")]
    [InlineData(52, "AZ")]
    public void TestSolve(int input, string expected)
    {
        var solution = new ExcelSheetColumnTitleSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}