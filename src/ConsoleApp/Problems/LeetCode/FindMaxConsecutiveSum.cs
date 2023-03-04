namespace ConsoleApp.Problems.LeetCode;

public class FindMaxConsecutiveSum
{
    public int Solve(int[] arr, int k)
    {
        var maxSum = 0;

        for (var i = 0; i < k; i++)
        {
            maxSum += arr[i];
        }

        var windowSum = maxSum;
        for (var i = k; i < arr.Length; i++)
        {
            windowSum += arr[i] - arr[i - k];
            maxSum = windowSum > maxSum ? windowSum : maxSum;
        }
        
        return maxSum;
    }
}