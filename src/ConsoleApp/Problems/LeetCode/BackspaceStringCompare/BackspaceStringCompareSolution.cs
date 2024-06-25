namespace ConsoleApp.Problems.LeetCode.BackspaceStringCompare;

public class ProblemSolution
{
    public object Solve(string s, string t)
    {
        var sStack = new Stack<char>();
        var tStack = new Stack<char>();
        
        foreach (var c in s) {
            if (c == '#') {
                sStack.TryPop(out var _);
                continue;
            }

            sStack.Push(c);
        }

        foreach (var c in t) {
            if (c == '#') {
                tStack.TryPop(out var _);
                continue;
            }

            tStack.Push(c);
        }

        while (sStack.TryPop(out var sChar))
        {
            if (!tStack.TryPop(out var tChar) || tChar != sChar)
            {
                return false;
            }    
        }

        if (tStack.TryPop(out var _))
        {
            return false;
        }

        return true;
    }
}