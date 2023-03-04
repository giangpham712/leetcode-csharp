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
    [MemberData(nameof(ConstructBinaryTreeTestData))]
    public void ConstructBinaryTree(int[] values, TreeNode expected)
    {
        var actual = Utils.ConstructBinaryTree(values);
        
        
    }

    public static IEnumerable<object[]> ConstructBinaryTreeTestData()
    {
        {
            var values = new[] { 25, 15, 50, 10, 22, 35, 70, 4, 12, 18, 24, 31, 44, 66, 90 };
            var root = new TreeNode(25);
            root.Left = new TreeNode(15);
            root.Right = new TreeNode(50);
            root.Left.Left = new TreeNode(10);
            root.Left.Right = new TreeNode(22);
            root.Right.Left = new TreeNode(35);
            root.Right.Right = new TreeNode(70);
            root.Left.Left.Left = new TreeNode(4);
            root.Left.Left.Right = new TreeNode(12);
            root.Left.Right.Left = new TreeNode(18);
            root.Left.Right.Right = new TreeNode(24);
            root.Right.Left.Left = new TreeNode(31);
            root.Right.Left.Right = new TreeNode(44);
            root.Right.Right.Left = new TreeNode(66);
            root.Right.Right.Right = new TreeNode(90);
            
            yield return new object[]
            {
                values,
                root
            };
        }
    }
}