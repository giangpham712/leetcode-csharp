using DataStructures.Extensions;
using DataStructures.LeetCode;
using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.DeleteNodeInBST;

public class DeleteNodeInBSTTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(TreeNode input, int key, TreeNode expected)
    {
        var solution = new DeleteNodeInBSTSolution();
        var actual = solution.Solve(input, key);

        actual.IsEquivalentTo(expected).Should().BeTrue();
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new TreeNode()
            {
                val = 5,
                left = new TreeNode()
                {
                    val = 3,
                    left = new TreeNode(2),
                    right = new TreeNode(4)
                },
                right = new TreeNode()
                {
                    val = 6,
                    right = new TreeNode(7)
                }
            },
            3,
            new TreeNode()
            {
                val = 5,
                left = new TreeNode()
                {
                    val = 4,
                    left = new TreeNode(2),
                },
                right = new TreeNode()
                {
                    val = 6,
                    right = new TreeNode(7)
                }
            },
        };

        yield return new object[]
        {
            new TreeNode(5)
            {
                left = new TreeNode(2)
                {
                    right = new TreeNode(4)
                },
                right = new TreeNode(6)
                {
                    right = new TreeNode(7)
                }
            },
            0,
            new TreeNode(5)
            {
                left = new TreeNode(2)
                {
                    right = new TreeNode(4)
                },
                right = new TreeNode(6)
                {
                    right = new TreeNode(7)
                }
            }
        };

        yield return new object[]
        {
            null,
            0,
            null
        };
    }
}