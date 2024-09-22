namespace ConsoleApp.Problems.LeetCode.Permutations;

public class PermutationsTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[] nums, IList<IList<int>> expected)
    {
        var solution = new PermutationsSolution();
        var actual = solution.Solve(nums);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new int[] {1,2,3},
            new List<IList<int>>
            {
                new List<int>() {1,2,3}, 
                new List<int>() {1,3,2}, 
                new List<int>() {2,1,3}, 
                new List<int>() {2,3,1}, 
                new List<int>() {3,1,2}, 
                new List<int>() {3,2,1}, 
            }
        };
        
        yield return new object[]
        {
            new int[] {0,1},
            new List<IList<int>>
            {
                new List<int>() {0,1}, 
                new List<int>() {1,0}, 
            }
        };
        
        yield return new object[]
        {
            new int[] {1},
            new List<IList<int>>
            {
                new List<int>() {1}, 
            }
        };
    }
}