namespace ConsoleApp.Problems.LeetCode.PacificAtlanticWaterFlow;

public class PacificAtlanticWaterFlowSolution
{
    public IList<IList<int>> Solve(int[][] heights)
    {
        var pacificCells = new HashSet<(int, int)>();
        var atlantisCells = new HashSet<(int, int)>();

        for (int i = 0; i < heights.Length; i++)
        {
            for (int j = 0; j < heights[0].Length; j++)
            {
                if (i == 0 || j == 0)
                {
                    Dfs(heights, (i, j), pacificCells);
                }
                
                if (i == heights.Length - 1 || j == heights[0].Length - 1)
                {
                    Dfs(heights, (i, j), atlantisCells);
                }
            }
        }
        
        var results = new List<IList<int>>();
        
        for (int i = 0; i < heights.Length; i++)
        {
            for (int j = 0; j < heights[0].Length; j++)
            {
                if (pacificCells.Contains((i, j)) && atlantisCells.Contains((i, j)))
                {
                    results.Add(new List<int> { i, j });
                }
            }
        }
        
        return results;
    }

    private void Dfs(int[][] heights, (int, int) cell, HashSet<(int, int)> seen)
    {
        if (!seen.Add(cell))
        {
            return;
        }

        var (i, j) = cell;
        if (i > 0 && heights[i - 1][j] >= heights[i][j])
        {
            Dfs(heights, (i - 1, j), seen);
        }
        
        if (j > 0 && heights[i][j - 1] >= heights[i][j])
        {
            Dfs(heights, (i, j - 1), seen);
        }
        
        if (i < heights.Length - 1 && heights[i + 1][j] >= heights[i][j])
        {
            Dfs(heights, (i + 1, j), seen);
        }
        
        if (j < heights[0].Length - 1 && heights[i][j + 1] >= heights[i][j])
        {
            Dfs(heights, (i, j + 1), seen);
        }
    }
}