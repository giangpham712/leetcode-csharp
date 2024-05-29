namespace ConsoleApp.Problems.LeetCode.SearchInRotatedSortedArray;

public class SearchInRotatedSortedArrayTest
{
    [Theory]
    [InlineData(new[] {4,5,6,7,0,1,2}, 0, 4)]
    [InlineData(new[] {4,5,6,7,0,1,2}, 3, -1)]
    [InlineData(new[] {1}, 0, -1)]
    public void TestSolve(int[] input, int target, object expected)
    {
        var solution = new SearchInRotatedSortedArraySolution();
        var actual = solution.Solve(input, target);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}