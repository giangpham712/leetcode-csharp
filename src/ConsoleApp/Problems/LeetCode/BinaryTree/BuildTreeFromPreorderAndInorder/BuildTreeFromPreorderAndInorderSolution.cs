using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.BuildTreeFromPreorderAndInorder;

/*
 * Command and conquer
 */
public class BuildTreeFromPreorderAndInorderSolution
{
    public TreeNode Solve(int[] preorder, int[] inorder)
    {
        var inorderMap = new Dictionary<int, int>();
        for (var i = 0; i < inorder.Length; i++)
        {
            inorderMap[inorder[i]] = i;
        }
        
        var root = BuildTree(preorder, 0, preorder.Length, inorder, 0, inorder.Length, inorderMap);

        return root;
    }

    private TreeNode BuildTree(int[] preorder, int preorderStart, int preorderEnd, int[] inorder, int inorderStart, int inorderEnd, Dictionary<int, int> inorderMap)
    {
        var value = preorder[preorderStart];
        var current = new TreeNode()
        {
            val = value
        };
        
        var inorderIndex = inorderMap[value];

        var preorderSplitIndex = preorderStart;

        for (var i = preorderStart + 1; i < preorderEnd; i++)
        {
            if (inorderMap[preorder[i]] > inorderIndex) 
            {
                break;
            }
            
            preorderSplitIndex = i;
        }

        if (preorderSplitIndex + 1 > preorderStart + 1)
        {
            current.left = BuildTree(
                preorder, 
                preorderStart + 1, 
                preorderSplitIndex + 1, 
                inorder, 
                inorderStart,
                inorderIndex, 
                inorderMap);
        }

        if (preorderEnd > preorderSplitIndex + 1)
        {
            current.right = BuildTree(
                preorder, 
                preorderSplitIndex + 1,
                preorderEnd, 
                inorder, 
                inorderIndex + 1,
                inorderEnd, 
                inorderMap);
        }

        return current;
    }
}