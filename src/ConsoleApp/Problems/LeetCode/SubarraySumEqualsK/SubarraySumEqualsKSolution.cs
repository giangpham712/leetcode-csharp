namespace ConsoleApp.Problems.LeetCode.SubarraySumEqualsK;

public class SubarraySumEqualsKSolution
{
    public int Solve(int[] nums, int k)
    {
        var sumFrequencies = new Dictionary<int, int>()
        {
            { 0, 1 }
        };
        
        var total = 0;
        var currentSum = 0;
        foreach (var num in nums)
        {
            currentSum += num;
            
            if (sumFrequencies.TryGetValue(currentSum - k, out var count))
            {
                total += count;
            }

            if (sumFrequencies.ContainsKey(currentSum))
            {
                sumFrequencies[currentSum]++;
            }
            else
            {
                sumFrequencies[currentSum] = 1;
            }
        }
        
        return total;
    }
}