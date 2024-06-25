using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.IntersectionOfMultipleArrays;

public class ProblemTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[][] nums, IList<int> expected)
    {
        (new Stack<char>()).TryPop(out var c);
        var solution = new ProblemSolution();
        var actual = solution.Solve(nums);
        
        actual.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new int[][]
            {
                [3,1,2,4,5],[1,2,3,4],[3,4,5,6],
                
            },
            new[] {3,4}
        };
        
        yield return new object[]
        {
            new int[][]
            {
                [1,2,3],[4,5,6],
                
            },
            new int[] {}
        };
    }
}