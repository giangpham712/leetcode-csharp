using System.ComponentModel;

namespace ConsoleApp.Problems.LeetCode.JumpGame;

public class JumpGameSolution2
{
    public bool Solve(int[] nums)
    {
        var current = nums.Length - 1;
        while (current > 0)
        {
            var canJump = false;
            for (var i = current - 1; i >= 0; i--)
            {
                if (nums[i] >= current - i)
                {
                    current = i;
                    canJump = true;
                    break;
                }
            }

            if (!canJump)
            {
                return false;
            }
        }

        return true;
    }
}