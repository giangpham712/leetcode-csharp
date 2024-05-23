using DataStructures.Extensions;
using DataStructures.LeetCode;
using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.PopulatingNextRightPointersInEachNode;

public class PopulatingNextRightPointersInEachNodeTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(Node input, Node expected)
    {
        var solution = new PopulatingNextRightPointersInEachNodeSolution();
        var actual = solution.Solve(input);

        actual.IsEquivalentTo(expected).Should().BeTrue();
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new Node
            {
                val = 1,
                left = new Node()
                {
                    val = 2,
                    left = new Node(4),
                    right = new Node(5),
                },
                right = new Node()
                {
                    val = 3,
                    left = new Node(6),
                    right = new Node(7),
                }
            },
            new Node
            {
                val = 1,
                left = new Node()
                {
                    val = 2,
                    left = new Node(4),
                    right = new Node(5),
                },
                right = new Node()
                {
                    val = 3,
                    left = new Node(6),
                    right = new Node(7),
                }
            },
        };
    }
}