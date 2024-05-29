using DataStructures.Extensions;
using DataStructures.LeetCode;
using FluentAssertions;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.SerializeAndDeserialize;

public class BinaryTreeSerializeAndDeserializeTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(TreeNode input, TreeNode expected)
    {
        var solution = new BinaryTreeSerializeAndDeserializeSolution();
        var actual = solution.Solve(input);

        actual.IsEquivalentTo(expected).Should().BeTrue();
    }

    private static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                },
                right = new TreeNode()
                {
                    val = 3,
                    left = new TreeNode()
                    {
                        val = 4
                    },
                    right = new TreeNode()
                    {
                        val = 5
                    },
                }
            },
            new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                },
                right = new TreeNode()
                {
                    val = 3,
                    left = new TreeNode()
                    {
                        val = 4
                    },
                    right = new TreeNode()
                    {
                        val = 5
                    },
                }
            },
        };

        yield return new object[]
        {
            null, null
        };
    }
}