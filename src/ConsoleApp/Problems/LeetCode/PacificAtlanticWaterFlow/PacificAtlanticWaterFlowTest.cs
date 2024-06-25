using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.PacificAtlanticWaterFlow;

public class PacificAtlanticWaterFlowTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[][] heights, int[][] expected)
    {
        var solution = new PacificAtlanticWaterFlowSolution();
        var actual = solution.Solve(heights);

        actual.Select(x => x.ToArray()).Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new int[][]
            {
                [1,2,2,3,5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5],[5,1,1,2,4]
            },
            new int[][]
            {
                [0,4],[1,3],[1,4],[2,2],[3,0],[3,1],[4,0]
            }
        };
        
        yield return new object[]
        {
            new int[][]
            {
                [1]
            },
            new int[][]
            {
                [0,0]
            }
        };
    }
}