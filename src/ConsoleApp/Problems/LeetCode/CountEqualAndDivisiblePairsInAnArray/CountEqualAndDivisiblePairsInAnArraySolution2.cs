namespace ConsoleApp.Problems.LeetCode.CountEqualAndDivisiblePairsInAnArray;

public class CountEqualAndDivisiblePairsInAnArraySolution2
{
    public int Solve(int[] nums, int k)
    {
        var map = new Dictionary<int, List<int>>();
        var total = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.TryGetValue(nums[i], out var indexes))
            {
                total += indexes.Count(index => index * i % k == 0);
            }
            else
            {
                map.Add(nums[i], new List<int>());    
            }
            
            map[nums[i]].Add(i);
        }

        return total;
    }
}