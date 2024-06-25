namespace ConsoleApp.Problems.LeetCode.LongestSubarrayWithSumK;

public class ProblemSolution
{
    public int Solve(int[] A, int K)
    {
        var sumFirstIndex = new Dictionary<int, int>()
        {
            { 0, -1 }
        };
        
        var total = 0;
        var currentSum = 0;
        var longestSubarray = 0;
        for (var i = 0; i < A.Length; i++)
        {
            var num = A[i];
            currentSum += num;

            if (sumFirstIndex.TryGetValue(currentSum - K, out var index))
            {
                longestSubarray = i - index > longestSubarray 
                    ? (i - index) : 
                    longestSubarray;
            }

            if (!sumFirstIndex.ContainsKey(currentSum))
            {
                sumFirstIndex.Add(currentSum, i);
            }
        }

        return longestSubarray;
    }
}