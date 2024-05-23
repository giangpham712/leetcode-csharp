namespace ConsoleApp.Problems.LeetCode.MergeSortedArray;

public class MergeSortedArrayTest
{
    [Theory]
    [InlineData(new[] {1,2,3,0,0,0}, 3, new[] {2,5,6}, 3, new[] {1,2,2,3,5,6})]
    [InlineData(new[] {1}, 1, new int[] {}, 0, new[] {1})]
    [InlineData(new[] {0}, 0, new int[] {1}, 1, new[] {1})]
    public void TestSolve(int[] nums1, int m, int[] nums2, int n, object expected)
    {
        var solution = new MergeSortedArraySolution();
        var actual = solution.Solve(nums1, m, nums2, n);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
        };
    }
}