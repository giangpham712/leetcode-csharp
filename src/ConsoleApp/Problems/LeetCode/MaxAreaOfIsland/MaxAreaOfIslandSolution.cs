namespace ConsoleApp.Problems.LeetCode.MaxAreaOfIsland;

public class MaxAreaOfIslandSolution
{
    public int Solve(int[][] grid)
    {
        var islands = new Dictionary<int, int>();

        var count = 0;
        for (var i = 0; i < grid.Length; i++) {
            for (var j = 0; j < grid[i].Length; j++) {
                Expand(i, j, grid, count, islands);
                count++;
            }    
        }

        return islands.Count > 0 ? islands.MaxBy(x => x.Value).Value : 0;
    }
    
    public void Expand(int i, int j, int[][] grid, int key, Dictionary<int, int> islands) 
    {
        if (grid[i][j] == 0) return;
        
        grid[i][j] = 0;
        
        if (islands.TryGetValue(key, out var area)) {
            islands[key] = area + 1;
        } else {
            islands[key] = 1;
        }
     
        if (i > 0)
            Expand(i - 1, j, grid, key, islands);
        
        if (j > 0)
            Expand(i, j - 1, grid, key, islands);
        
        if (i < grid.Length - 1)
            Expand(i + 1, j, grid, key, islands);
        
        if (j < grid[0].Length - 1)
            Expand(i, j + 1, grid, key, islands);
    }
}