using DataStructures.Extensions;
using DataStructures.LeetCode;
using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.Invert;

public class InvertBinaryTreeTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(TreeNode input, TreeNode expected)
    {
        var solution = new InvertBinaryTreeSolution();
        var actual = solution.Solve(input);

        actual.IsEquivalentTo(expected).Should().BeTrue();
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new TreeNode(4)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(1),
                    right = new TreeNode(3),
                },
                right = new TreeNode(7)
                {
                    left = new TreeNode(6),
                    right = new TreeNode(9),
                }
            },
            new TreeNode(4)
            {
                left = new TreeNode(7)
                {
                    left = new TreeNode(9),
                    right = new TreeNode(6),
                },
                right = new TreeNode(2)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(1),
                }
            }
        };

        yield return new object[]
        {
            new TreeNode(2)
            {
                left = new TreeNode(1)
                {

                },
                right = new TreeNode(3)
                {

                }
            },
            new TreeNode(2)
            {
                left = new TreeNode(3)
                {

                },
                right = new TreeNode(1)
                {

                }
            }
        };

        yield return new object[]
        {
            null,
            null
        };
    }
}