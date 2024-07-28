namespace ConsoleApp.Problems.LeetCode.Minesweeper;

public class MinesweeperTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(char[][] board, int[] click, char[][] expected)
    {
        var solution = new MinesweeperSolution();
        var actual = solution.Solve(board, click);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new char[][]
            {
                ['E','E','E','E','E'],['E','E','M','E','E'],['E','E','E','E','E'],['E','E','E','E','E']
            },
            new int[] {3,0},
            new char[][]
            {
                ['B','1','E','1','B'],['B','1','M','1','B'],['B','1','1','1','B'],['B','B','B','B','B']
            }
        };
        
        yield return new object[]
        {
            new char[][]
            {
                ['B','1','E','1','B'],['B','1','M','1','B'],['B','1','1','1','B'],['B','B','B','B','B']
            },
            new int[] {1,2},
            new char[][]
            {
                ['B','1','E','1','B'],['B','1','X','1','B'],['B','1','1','1','B'],['B','B','B','B','B']
            }
        };
    }
}