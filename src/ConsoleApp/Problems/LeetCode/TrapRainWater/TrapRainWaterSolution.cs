namespace ConsoleApp.Problems.LeetCode.TrapRainWater;

public class TrapRainWaterSolution
{
    public int Solve(int[] height)
    {
        var total = 0;
        var left = new int[height.Length];
        left[0] = 0;
        var right = new int[height.Length];
        right[height.Length - 1] = 0;
        
        for (var i = 1; i < height.Length; i++)
        {
            left[i] = Math.Max(left[i - 1], height[i - 1]);
            var j = height.Length - i - 1;
            right[j] = Math.Max(right[j + 1], height[j + 1]);
        }

        for (var i = 0; i < height.Length; i++)
        {
            total += Math.Max(0, Math.Min(left[i], right[i]) - height[i]);
        }

        return total;
    }
}