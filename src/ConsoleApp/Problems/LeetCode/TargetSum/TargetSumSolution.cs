namespace ConsoleApp.Problems.LeetCode.TargetSum;

public class TargetSumSolution
{
    public int Solve(int[] nums, int target)
    {
        var memoized = new Dictionary<(int, int), int>();
        
        return FindTargetSumWays(nums, nums.Length - 1, target, memoized);
    }

    private int FindTargetSumWays(int[] nums, int index, int target, Dictionary<(int, int), int> memoized)
    {
        
        if (index == 0)
        {
            if (nums[0] == 0 && target == 0)
            {
                return 2;
            }
            
            return Math.Abs(target) == nums[0] ? 1 : 0;
        }

        if (memoized.TryGetValue((index, target), out var count))
        {
            return count;
        }
        
        count = FindTargetSumWays(nums, index - 1, target - nums[index], memoized) +
                    FindTargetSumWays(nums, index - 1, target + nums[index], memoized);

        memoized[(index, target)] = count;

        return count;
    }

    public int Solve2(int[] nums, int target)
    {
        return default;
    }
}