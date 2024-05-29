using FluentAssertions.Collections;

namespace ConsoleApp.Problems.LeetCode.MinimumMovesToSpreadStonesOverGrid;

public class MinimumMovesToSpreadStonesOverGridSolution
{
    public int Solve(int[][] grid)
    {
        var givers = new List<(int, int)>();

        var receivers = new List<(int, int)>();

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] > 1)
                {
                    for (var k = 0; k < grid[i][j] - 1; k++)
                    {
                        givers.Add((i, j));
                    }
                }
                else if (grid[i][j] == 0)
                {
                    receivers.Add((i, j));
                }
            }
        }

        return BackTrack(givers, receivers);
    }

    private int BackTrack(List<(int, int)> givers, List<(int, int)> receivers)
    {
        if (!givers.Any() || !receivers.Any())
        {
            return 0;
        }
        
        var min = int.MaxValue;
        (int, int)? prev = null;
        for (var i = 0; i < givers.Count; i++)
        {
            var giver = givers[i];
            if (giver == prev)
            {
                continue;
            }

            prev = giver;
            
            var giverMin = int.MaxValue;
            var otherGivers = new List<(int, int)>();

            for (var j = 0; j < givers.Count; j++)
            {
                if (j == i)
                {
                    continue;
                }
                
                var otherGiver = givers[j];
                otherGivers.Add(otherGiver);
            }

            foreach (var receiver in receivers)
            {
                giverMin = Math.Min(giverMin,
                    CalculateDistance(giver, receiver) +
                    BackTrack(otherGivers, receivers.Where(x => x != receiver).ToList()));
            }

            min = Math.Min(min, giverMin);
        }

        return min;
    }

    private int CalculateDistance((int, int) cell1, (int, int) cell2)
    {
        return Math.Abs(cell1.Item1 - cell2.Item1) + Math.Abs(cell1.Item2 - cell2.Item2);
    }
}