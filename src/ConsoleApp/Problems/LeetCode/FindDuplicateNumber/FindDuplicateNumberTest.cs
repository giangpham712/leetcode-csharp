namespace ConsoleApp.Problems.LeetCode.FindDuplicateNumber;

public class FindDuplicateNumberTest
{
    [Theory]
    [InlineData(new int[] {1,3,4,2,2}, 2)]
    [InlineData(new int[] {3,1,3,4,2}, 3)]
    [InlineData(new int[] {3,3,3,3,3}, 3)]
    [InlineData(new int[] {2,5,9,6,9,3,8,9,7,1}, 9)]
    public void TestSolve(int[] nums, int expected)
    {
        var solution = new FindDuplicateNumberSolution();
        var actual = solution.Solve(nums);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}