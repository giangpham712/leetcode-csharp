using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.RotateImage;

public class RotateImageTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(int[][] input, int[][] expected)
    {
        var solution = new RotateImageSolution();
        solution.Solve(input);

        input.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }
    
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve2(int[][] input, int[][] expected)
    {
        var solution = new RotateImageSolution2();
        solution.Solve(input);

        input.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new int[][]
            {
                [1,2,3],[4,5,6],[7,8,9]
            },
            new int[][]
            {
                [7,4,1],[8,5,2],[9,6,3]
            }
        };
        
        yield return new object[]
        {
            new int[][]
            {
                [5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]
            },
            new int[][]
            {
                [15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]
            }
        };
    }
}