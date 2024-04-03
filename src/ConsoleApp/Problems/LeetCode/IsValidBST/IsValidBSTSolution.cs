namespace ConsoleApp.Problems.LeetCode.IsValidBST;

public class IsValidBSTSolution
{
    public object Solve(TreeNode root)
    {
        return IsValid(root, long.MinValue, long.MaxValue);
    }
    
    private bool IsValid(TreeNode? node, long smallest, long largest) 
    {
        if (node == null) {
            return true;
        }

        return node.val > smallest && 
               node.val < largest &&
               IsValid(node.left, smallest, node.val) &&
               IsValid(node.right, node.val, largest);
    }      

    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;

        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            val = val;
            left = left;
            right = right;
        }
    }
}