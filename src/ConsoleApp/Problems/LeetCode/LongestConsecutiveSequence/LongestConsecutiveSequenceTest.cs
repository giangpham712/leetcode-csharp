namespace ConsoleApp.Problems.LeetCode.LongestConsecutiveSequence;

public class ProblemTest
{
    [Theory]
    [InlineData(new int[] {100,4,200,1,3,2}, 4)]
    [InlineData(new int[] {0,3,7,2,5,8,4,6,0,1}, 9)]
    public void TestSolve(int[] nums, int expected)
    {
        var solution = new ProblemSolution();
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