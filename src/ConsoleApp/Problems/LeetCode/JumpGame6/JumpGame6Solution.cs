namespace ConsoleApp.Problems.LeetCode.JumpGame6;

public class JumpGame6Solution
{
    public int Solve(int[] nums, int k)
    {
        var memoized = new Dictionary<int, int>();
        memoized[nums.Length - 1] = nums[nums.Length - 1];
        
        return SolveInternal(nums, 0, k, memoized);
    }
    
    private int SolveInternal(int[] nums, int index, int k, Dictionary<int, int> memoized)
    {
        if (memoized.TryGetValue(index, out var max))
        {
            return max;
        }
        
        for (var i = index + 1; i < Math.Min(index + k + 1, nums.Length); i++)
        {
            if (nums[i] > 0)
            {
                max = nums[index] + SolveInternal(nums, i, k, memoized);
                memoized.Add(index, max);
                return max;
            }
        }
        
        max = SolveInternal(nums, Math.Min(index + k + 1, nums.Length) - 1, k, memoized);

        var value = nums[Math.Min(index + k + 1, nums.Length) - 1];
        for (var i = Math.Min(index + k + 1, nums.Length) - 2; i >= index + 1; i--)
        {
            if (nums[i] <= value && nums[i] < 0)
            {
                continue;
            }
            else
            {
                value = nums[i];
            }
            
            max = Math.Max(max, SolveInternal(nums, i, k, memoized));
        }

        max += nums[index];
        memoized.Add(index, max);
        return max;
    }
}