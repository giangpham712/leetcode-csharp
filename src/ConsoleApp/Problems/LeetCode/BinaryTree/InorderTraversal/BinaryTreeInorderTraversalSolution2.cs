using DataStructures.LeetCode;

namespace ConsoleApp.Problems.LeetCode.BinaryTree.InorderTraversal;

/*
 * Iterative solution
 * 1. Create an empty stack (say S).
 * 2. Initialize the current node as root.
 * 3. Push the current node to S and set current = current's left until current is NULL
 * 4. If current is NULL and the stack is not empty then:
 *     - Pop the top item from the stack.
 *     - Print the popped item and set current = popped item's right 
 *     - Go to step 3.
 * 5. If current is NULL and the stack is empty then we are done.
 */
public class BinaryTreeInorderTraversalSolution2
{
    public IList<int> Solve(TreeNode root)
    {
        var traversal = new List<int>();

        var stack = new Stack<TreeNode>();

        var current = root;

        while (current != null || stack.Any())
        {
            if (current != null)
            {
                stack.Push(current);

                current = current.left;
            }
            else if (stack.TryPop(out var node))
            {
                traversal.Add(node.val);

                current = node.right;
            }
        }
        
        return traversal;
    }
}