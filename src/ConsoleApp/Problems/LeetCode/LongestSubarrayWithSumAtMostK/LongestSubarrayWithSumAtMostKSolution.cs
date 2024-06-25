namespace ConsoleApp.Problems.LeetCode.LongestSubarrayWithSumAtMostK;

public class LongestSubarrayWithSumAtMostKSolution
{
    public int Solve(int[] input, int k)
    {
        var neg = new int[input.Length];
        var sum = 0;
        for (var i = input.Length - 1; i > -1; i--)
        {
            neg[input.Length - 1 - i] = sum;
            sum += input[i];

            sum = Math.Min(0, sum);
        }

        sum = 0;
        var l = 0;
        var j = 0;
        var result = 0;

        while (j < input.Length)
        {
            sum += input[j];

            while (l < input.Length && neg[j] + sum > l)
            {
                sum -= input[l];
                l++;
            }

            result = Math.Max(result, j - 1 + 1);
            j++;
        }
        
        return result;
    }
}