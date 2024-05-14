using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.GroupAnagrams;

public class GroupAnagramsTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(string[] input, IList<IList<string>> expected)
    {
        var solution = new GroupAnagramsSolution2();
        var actual = solution.Solve(input);

        actual.Count.Should().Be(expected.Count);
        foreach (var group in expected)
        {
            actual.Should().Contain(x => x.Count == group.Count && x.Intersect(group).Count() == group.Count);
        }
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new [] {"eat","tea","tan","ate","nat","bat"},
            new string[][]
            {
                new[] {"bat"},
                new[] {"nat","tan"},
                new[] {"ate","eat","tea"},
            }
        };

        yield return new object[]
        {
            new[] {""},
            new string[][]
            {
                new[ ]{""}
            }
        };
        
        yield return new object[]
        {
            new[] {"a"},
            new string[][]
            {
                new[ ]{"a"}
            }
        };
    }
}