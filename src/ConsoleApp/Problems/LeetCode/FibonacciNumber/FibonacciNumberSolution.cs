namespace ConsoleApp.Problems.LeetCode.FibonacciNumber;

public class FibonacciNumberSolution
{
    public int Solve(int n)
    {
        if (n == 0)
        {
            return n;
        }
        
        var fibonacis = new int[n + 1];
        fibonacis[1] = 1;

        for (var i = 2; i < n + 1; i++)
        {
            fibonacis[i] = fibonacis[i - 2] + fibonacis[i - 1];
        }
        
        return fibonacis[n];
    }
}