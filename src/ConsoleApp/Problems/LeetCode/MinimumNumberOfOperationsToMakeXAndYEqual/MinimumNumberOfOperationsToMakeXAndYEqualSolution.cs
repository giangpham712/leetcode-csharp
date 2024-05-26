using System.Security.Cryptography;

namespace ConsoleApp.Problems.LeetCode.MinimumNumberOfOperationsToMakeXAndYEqual;

public class MinimumNumberOfOperationsToMakeXAndYEqualSolution
{
    public int Solve(int x, int y)
    {
        if (y >= x)
        {
            return y - x;
        }
        
        var maxX = x + (x - y);
        while (maxX % 5 != 0 && maxX % 11 != 0)
        {
            maxX++;
        }

        var memoized = new Dictionary<int, int>();
        memoized.Add(y, 0);
        memoized.Add(y - 1, 1);
        memoized.Add(y + 1, 1);
        memoized.Add(y * 11, 1);
        memoized.Add(y * 5, 1);
        
        return SolveInternal(x, y, memoized);
    }

    private int SolveInternal(int x, int y, Dictionary<int, int> memoized)
    {
        if (y >= x)
        {
            return y - x;
        }

        if (memoized.TryGetValue(x, out var min))
        {
            return min;
        }

        min = x - y;

        if (x % 11 == 0)
        {
            min = Math.Min(min, SolveInternal(x / 11, y, memoized) + 1);
        }
        else
        {
            min = Math.Min(min, SolveInternal(x / 11 + 1, y, memoized) + (11 - (x % 11) + 1));
            min = Math.Min(min, SolveInternal(x / 11, y, memoized) + ((x % 11) + 1));
        }
        
        if (x % 5 == 0)
        {
            min = Math.Min(min, SolveInternal(x / 5, y, memoized) + 1);
        }
        else
        {
            min = Math.Min(min, SolveInternal(x / 5 + 1, y, memoized) + (5 - (x % 5) + 1));
            min = Math.Min(min, SolveInternal(x / 5, y, memoized) + ((x % 5) + 1));
        }

        memoized[x] = min;
        return min;
    }
}