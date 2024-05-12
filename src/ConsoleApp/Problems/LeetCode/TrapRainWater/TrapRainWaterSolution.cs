namespace ConsoleApp.Problems.LeetCode.TrapRainWater;

public class TrapRainWaterSolution
{
    public int Solve(int[] height)
    {
        var total = 0;
        var left = new int[height.Length];
        var right = new int[height.Length];
        
        for (var i = 0; i < height.Length; i++)
        {
            left[i] = i > 0 ? Math.Max(left[i - 1], height[i - 1]) : 0;
            var j = height.Length - i - 1;
            right[j] = j < height.Length - 1 ? Math.Max(right[j + 1], height[j + 1]) : 0;
        }

        for (var i = 0; i < height.Length; i++)
        {
            total += Math.Max(0, Math.Min(left[i], right[i]) - height[i]);
        }

        return total;
    }
}