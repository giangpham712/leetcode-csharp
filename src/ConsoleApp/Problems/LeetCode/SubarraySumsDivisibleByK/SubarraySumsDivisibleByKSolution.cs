namespace ConsoleApp.Problems.LeetCode.SubarraySumsDivisibleByK;

public class SubarraySumsDivisibleByKSolution
{
    public int Solve(int[] nums, int k)
    {
        var prefixSums = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            prefixSums[i] = (i == 0 ? 0 : prefixSums[i - 1]) + nums[i];
        }

        var total = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (prefixSums[i] % k == 0)
            {
                total++;
                Console.WriteLine($"{0}:{i}");
            }
            
            for (int j = i + 1; j < nums.Length; j++)
            {
                if ((prefixSums[j] - prefixSums[i]) % k == 0)
                {
                    total++;
                    Console.WriteLine($"{i}:{j}");
                }
            }
        }

        return total;
    }
    
    public int Solve2(int[] nums, int k)
    {
        var remainderFrequencies = new Dictionary<int, int>()
        {
            { 0, 1 }
        };

        var total = 0;

        var currentSum = 0;
        foreach (var num in nums)
        {
            currentSum += num;
            var remainder = currentSum % k;

            remainder = remainder < 0 ? (k + remainder) : remainder;

            if (remainderFrequencies.ContainsKey(remainder))
            {
                total += remainderFrequencies[remainder];
                remainderFrequencies[remainder]++;
            }
            else
            {
                remainderFrequencies[remainder] = 1;
            }
        }

        return total;
    }
}