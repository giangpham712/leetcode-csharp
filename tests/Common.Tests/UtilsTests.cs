using DataStructures.LeetCode;

namespace Common.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(10, 9, 11)]
    [InlineData(2, 2, 10)]
    public void ConvertToBase(long n, int b, long expected)
    {
        var actual = Utils.ConvertToBase(n, b);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(CreateTestData))]
    public void ConstructBinaryTree(int[] values, TreeNode expected)
    {
        var actual = Utils.ConstructBinaryTree(values);
        
        
    }

    public static IEnumerable<object[]> CreateTestData()
    {
        {
            var values = new[] { 25, 15, 50, 10, 22, 35, 70, 4, 12, 18, 24, 31, 44, 66, 90 };
            var root = new TreeNode(25);
            root.left = new TreeNode(15);
            root.right = new TreeNode(50);
            root.left.left = new TreeNode(10);
            root.left.right = new TreeNode(22);
            root.right.left = new TreeNode(35);
            root.right.right = new TreeNode(70);
            root.left.left.left = new TreeNode(4);
            root.left.left.right = new TreeNode(12);
            root.left.right.left = new TreeNode(18);
            root.left.right.right = new TreeNode(24);
            root.right.left.left = new TreeNode(31);
            root.right.left.right = new TreeNode(44);
            root.right.right.left = new TreeNode(66);
            root.right.right.right = new TreeNode(90);
            
            yield return new object[]
            {
                values,
                root
            };
        }
    }
}