namespace ConsoleApp.Problems.LeetCode.FindTheCelebrity;

public class FindTheCelebritySolution
{
    public int Solve(int[][] input)
    {
        var points = new int[input.Length];
        for (var i = 0; i < input.Length; i++)
        {
            for (var j = 0; j < input[0].Length; j++)
            {
                if (input[i][j] == 1)
                {
                    points[i] += 1;
                    points[j] += -1;
                }
            }    
        }
        
        return Array.IndexOf(points, -(input.Length - 1));
    }
}