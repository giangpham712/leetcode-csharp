using System.Security.Cryptography;

namespace ConsoleApp.Problems.LeetCode.MinimumNumberOfOperationsToMakeXAndYEqual;

public class MinimumNumberOfOperationsToMakeXAndYEqualSolution2
{
    public int Solve(int x, int y)
    {
        if (y > x)
        {
            return y - x;
        }
        
        var queue = new Queue<(int x, int steps)>();

        var seen = new HashSet<int>();
        
        queue.Enqueue((x, 0));
        while (queue.TryDequeue(out var item))
        {
            x = item.x;
            seen.Add(x);

            if (x == y)
            {
                return item.steps;
            }
            
            // Try to divide by 11
            if (x % 11 == 0 && seen.Add(x / 11))
            {
                queue.Enqueue((x / 11, item.steps + 1));
            }
            
            // Try to divide by 5
            if (x % 5 == 0 && seen.Add(x / 5))
            {
                queue.Enqueue((x / 5, item.steps + 1));
            }
            
            if (seen.Add(x - 1))
            {
                queue.Enqueue((x - 1, item.steps + 1));
            }
            
            if (seen.Add(x + 1))
            {
                queue.Enqueue((x + 1, item.steps + 1));
            }
        }

        return -1;
    }
}