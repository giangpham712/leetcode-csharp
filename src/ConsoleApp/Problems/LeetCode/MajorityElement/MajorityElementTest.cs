namespace ConsoleApp.Problems.LeetCode.MajorityElement;

public class MajorityElementTest
{
    [Theory]
    [InlineData(new int[] {3,2,3}, 3)]
    [InlineData(new int[] {2,2,1,1,1,2,2}, 2)]
    public void TestSolve(int[] nums, int expected)
    {
        var solution = new MajorityElementSolution();
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