namespace ConsoleApp.Problems.LeetCode.MinCostClimbingStairs;

public class MinCostClimbingStairsSolution
{
    public int Solve(int[] cost)
    {
        var totalCost = 0;

        var memoized = new Dictionary<int, int>()
        {
            { 0, 0 },
            { 1, 0 },
        };

        return MinCost(cost, cost.Length, memoized);
    }

    private int MinCost(int[] costs, int step, Dictionary<int, int> memoized)
    {
        if (memoized.TryGetValue(step, out var cost))
        {
            return cost;
        }

        var minCost = Math.Min(
            MinCost(costs, step - 1, memoized) + costs[step - 1],
            MinCost(costs, step - 2, memoized) + costs[step - 2]
        );

        memoized[step] = minCost;

        return minCost;
    }
}