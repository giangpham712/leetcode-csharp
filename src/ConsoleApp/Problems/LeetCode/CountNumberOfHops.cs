namespace ConsoleApp.Problems.LeetCode;

public class CountNumberOfHops
{
    public long Solve(int n)
    {
        Dictionary<int, long> memoized = new Dictionary<int, long>();
        // add your code here
        return CountWays(n, memoized);
    }
    
    static long CountWays(int n, Dictionary<int, long> memoized) {
        if (n < 0) {
            return 0;
        }
        
        if (n == 0) {
            return 1;
        }
        
        if (memoized.ContainsKey(n)) {
            return memoized[n];
        }
        
        long result = (CountWays(n - 1, memoized) + CountWays(n - 2, memoized) + CountWays(n - 3, memoized))  % 1000000007;
        memoized.Add(n, result);
        return result;
    }
}