using ConsoleApp.Problems.LeetCode;

namespace ConsoleApp.Tests.Problems.LeetCode;

public class MatrixBFSTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void Traverse(int[][] matrix)
    {
        var bfs = new MatrixBFS();
        var actual = bfs.Traverse(matrix);
        
        
    }

    public static IEnumerable<object[]> TestData()
    {
        {
            yield return new object[]
            {
                new int[][] { new []{1, 2, 3, 4}, new []{5, 6, 7, 8}, new []{9, 10, 11, 12}, new []{13, 14, 15, 16}},
                new List<int> { 1, 2, 5, 3, 6, 9, 4, 7, 10, 13, 8, 11, 14, 12, 15, 16 }
            };
        }
    }
}