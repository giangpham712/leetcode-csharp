namespace ConsoleApp.Problems.LeetCode.NumIslands;

public class NumIslandsTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(char[][] input, int expected)
    {
        var solution = new NumIslandsSolution();
        var actual = solution.Solve(input);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new char[][]
            {
                new[] { '1', '1', '1', '1', '0' }, 
                new[] { '1', '1', '0', '1', '0' }, 
                new[] { '1', '1', '0', '0', '0' },
                new[] { '0', '0', '0', '0', '0' }
            },
            1
        };

        yield return new object[]
        {
            new char[][]
            {
                new[] { '1', '1', '0', '0', '0' },
                new[] { '1', '1', '0', '0', '0' },
                new[] { '0', '0', '1', '0', '0' },
                new[] { '0', '0', '0', '1', '1' }
            },
            3
        };
    }
}