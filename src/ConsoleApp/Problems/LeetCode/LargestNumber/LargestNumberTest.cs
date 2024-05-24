namespace ConsoleApp.Problems.LeetCode.LargestNumber;

public class LargestNumberTest
{
    [Theory]
    [InlineData(new[] {10,2}, "210")]
    [InlineData(new[] {3,30,34,5,9}, "9534330")]
    [InlineData(new[] {34323,3432}, "343234323")]
    public void TestSolve(int[] nums, string expected)
    {
        var solution = new LargestNumberSolution();
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