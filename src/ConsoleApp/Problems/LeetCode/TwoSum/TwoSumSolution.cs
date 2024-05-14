namespace ConsoleApp.Problems.LeetCode.TwoSum;

public class TwoSumSolution
{
    public int[] Solve(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (map.TryGetValue(target - nums[i], out var j))
            {
                return new int[] { i, j };
            }
            else
            {
                map[nums[i]] = i;
            }
        }

        return new int[0];
    }
}