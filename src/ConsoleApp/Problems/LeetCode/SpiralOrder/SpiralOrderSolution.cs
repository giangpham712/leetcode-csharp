namespace ConsoleApp.Problems.LeetCode.SpiralOrder;

public class SpiralOrderSolution
{
    public IList<int> Solve(int[][] matrix)
    {
        var spiral = new List<int>();

        var x = -1;
        var y = 0;

        var n = matrix.Length - 1;
        var m = matrix[0].Length;

        var increment = 1;
        while (spiral.Count < matrix.Length * matrix[0].Length)
        {
            for (var i = 0; i < m; i++)
            {
                x += increment;
                spiral.Add(matrix[y][x]);
            }

            m--;
            
            for (var i = 0; i < n; i++)
            {
                y += increment;
                spiral.Add(matrix[y][x]);
            }

            n--;

            increment = increment * -1;
        }
        
        return spiral;
    }
}