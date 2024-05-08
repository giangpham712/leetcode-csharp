namespace ConsoleApp.Problems.LeetCode.WordSearch;

public class WordSearchTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(char[][] board, string word, bool expected)
    {
        var solution = new WordSearch();
        var actual = solution.Solve(board, word);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new char[][]
            {
                new[] { 'A', 'B', 'C', 'E' }, new [] { 'S', 'F', 'C', 'S' }, new [] { 'A', 'D', 'E', 'E' }
            },
            "ABCCED",
            true
        };
        
        yield return new object[]
        {
            new char[][]
            {
                new[] { 'A','B','C','E' }, new [] { 'S','F','C','S' }, new [] { 'A','D','E','E' }
            },
            "SEE",
            true
        };

        yield return new object[]
        {
            new char[][]
            {
                new[] { 'A','B','C','E' }, new [] { 'S','F','C','S' }, new [] { 'A','D','E','E' }
            },
            "ABCB",
            false
        };
        
        yield return new object[]
        {
            new char[][]
            {
                new[] { 'a','b' }, new [] { 'c','d' }
            },
            "acdb",
            true
        };
        
        yield return new object[]
        {
            new char[][]
            {
                new[] { 'A','B','C','E' }, new [] { 'S','F','E','S' }, new [] { 'A','D','E','E' }
            },
            "ABCESEEEFS",
            true
        };
        
        yield return new object[]
        {
            new char[][]
            {
                new [] { 'A','A','A','A','A','A' }, 
                new [] { 'A','A','A','A','A','A' }, 
                new [] { 'A','A','A','A','A','A' },
                new [] { 'A','A','A','A','A','A' },
                new [] { 'A','A','A','A','A','A' },
                new [] { 'A','A','A','A','A','A' },
            },
            "AAAAAAAAAAAABAA",
            false
        };
    }
}