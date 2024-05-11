using System.ComponentModel;

namespace ConsoleApp.Problems.LeetCode.JumpGame;

public class JumpGameSolution
{
    public bool Solve(int[] nums)
    {
        var memoized = new Dictionary<int, bool>();
        memoized[0] = true;
        
        return CanJump(nums, nums.Length - 1, memoized);
    }

    private bool CanJump(int[] nums, int index, Dictionary<int, bool> memoized)
    {
        if (memoized.TryGetValue(index, out var canJump))
        {
            return canJump;
        }
        
        for (var i = 0; i < index; i++)
        {
            if (nums[i] >= index - i && CanJump(nums, i, memoized))
            {
                memoized[index] = true;
                return true;
            }
        }
        
        memoized[index] = false;
        return false;
    }
}