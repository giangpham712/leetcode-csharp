using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode._3Sum;

public class ThreeSumTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[] input, IList<IList<int>> expected)
    {
        var solution = new ThreeSumSolution2();
        var actual = solution.Solve(input);

        Assert.Equal(expected.Count, actual.Count);
        foreach (var triplet in expected.Select(x => x.Order()))
        {
            actual.Should().ContainEquivalentOf(triplet.Order());
        }
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new int[] { -1,0,1,2,-1,-4 },
            new List<IList<int>>()
            {
                new List<int>() { -1,-1,2 },
                new List<int>() { -1,0,1 },
            }
        };
        
        yield return new object[]
        {
            new int[] { 0,1,1 },
            new List<IList<int>>()
            {
            }
        };
        
        yield return new object[]
        {
            new int[] { 0,0,0 },
            new List<IList<int>>()
            {
                new List<int>() { 0,0,0 }
            }
        };
    }
}