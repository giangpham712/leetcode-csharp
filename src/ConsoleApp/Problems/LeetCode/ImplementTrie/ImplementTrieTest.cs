namespace ConsoleApp.Problems.LeetCode.ImplementTrie;

public class ImplementTrieTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(string[] commands, string[][] args, bool?[] expected)
    {
        var solution = new ImplementTrieSolution();
        var actual = solution.Solve(commands, args);

        Assert.Equal(expected, actual);
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new [] { "Trie", "insert", "search", "search", "startsWith", "insert", "search" },
            new string[][]
            {
                [], ["apple"], ["apple"], ["app"], ["app"], ["app"], ["app"]
            },
            new bool?[]
            {
                null, null, true, false, true, null, true
            }
        };
    }
}