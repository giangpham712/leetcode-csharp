using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.SpiralOrder;

public class SpiralOrderTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[][] input, IList<int> expected)
    {
        var solution = new SpiralOrderSolution();
        var actual = solution.Solve(input);

        actual.Should().BeEquivalentTo(expected);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new []
            {
                new [] {1,2,3},
                new [] {4,5,6},
                new [] {7,8,9},
            },
            new List<int>() {1,2,3,6,9,8,7,4,5}
        };
        
        yield return new object[]
        {
            new []
            {
                new [] {1,2,3,4},
                new [] {5,6,7,8},
                new [] {9,10,11,12},
            },
            new List<int>() {1,2,3,4,8,12,11,10,9,5,6,7}
        };
    }
}