using FluentAssertions.Collections;

namespace ConsoleApp.Problems.LeetCode.CountingBits;

public class CountingBitsSolution
{
    public int[] Solve(int n)
    {
        if (n == 0)
        {
            return new[] { 0 };
        }
        
        var results = new int[n + 1];
        
        var a = 1;

        do
        {
            results[a] = 1;
            for (var i = a + 1; i < Math.Min(n + 1, a * 2); i++)
            {
                results[i] = results[a] + results[i - a];
            }

            a = a * 2;
        } while (a <= n);
        
        return results;
    }
}
