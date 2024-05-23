using DataStructures.Extensions;
using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.TrimBinarySearchTree;

public class TrimBinarySearchTreeTest
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void TestSolve(TreeNode root, int low, int high, TreeNode expected)
    {
        var solution = new TrimBinarySearchTreeSolution();
        var actual = solution.Solve(root, low, high);

        Assert.True(actual.IsEquivalentTo(expected));
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
                    val = 0
                },
                right = new TreeNode()
                {
                    val = 2
                }
            },
            1,
            2,
            new TreeNode()
            {
                val = 1,
                right = new TreeNode()
                {
                    val = 2
                }
            }
        };

        yield return new object[]
        {
            new TreeNode()
            {
                val = 3,
                left = new TreeNode()
                {
                    val = 0,
                    right = new TreeNode()
                    {
                        val = 2,
                        left = new TreeNode()
                        {
                            val = 1
                        }
                    }
                },
                right = new TreeNode()
                {
                    val = 4
                }
            },
            1,
            3,
            new TreeNode()
            {
                val = 3,
                left = new TreeNode()
                {
                    val = 2,
                    left = new TreeNode()
                    {
                        val = 1
                    }
                }
            }
        };
    }
}