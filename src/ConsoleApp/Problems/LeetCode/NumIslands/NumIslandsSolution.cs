namespace ConsoleApp.Problems.LeetCode.NumIslands;

public class NumIslandsSolution
{
    public int Solve(char[][] grid)
    {
        var keys = new HashSet<int>();

        var count = 0;
        for (var i = 0; i < grid.Length; i++) {
            for (var j = 0; j < grid[i].Length; j++) {
                Expand(i, j, grid, count, keys);
                count++;
            }    
        }
        
        return keys.Count;
    }
    
    public void Expand(int i, int j, char[][] grid, int key, HashSet<int> keys) 
    {
        if (grid[i][j] == '0') return;
        
        grid[i][j] = '0';
        keys.Add(key);
     
        if (i > 0)
            Expand(i - 1, j, grid, key, keys);
        
        if (j > 0)
            Expand(i, j - 1, grid, key, keys);
        
        if (i < grid.Length - 1)
            Expand(i + 1, j, grid, key, keys);
        
        if (j < grid[0].Length - 1)
            Expand(i, j + 1, grid, key, keys);
    }
}