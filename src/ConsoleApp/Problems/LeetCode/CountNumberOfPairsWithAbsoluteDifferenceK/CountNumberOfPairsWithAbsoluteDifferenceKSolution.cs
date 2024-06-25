namespace ConsoleApp.Problems.LeetCode.CountNumberOfPairsWithAbsoluteDifferenceK;

public class CountNumberOfPairsWithAbsoluteDifferenceKSolution
{
    public int Solve(int[] nums, int k)
    {
        var total = 0;
        var map = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (map.ContainsKey(num))
            {
                map[num] += 1;
            }
            else
            {
                map[num] = 1;
            }

            if (map.TryGetValue(num + k, out var count1)) 
            {
                total += count1;
            }
            
            if (map.TryGetValue(num - k, out var count2)) 
            {
                total += count2;
            }
        }
        
        return total;
    }
}