namespace ConsoleApp.Problems.LeetCode.RotateImage;

public class RotateImageSolution2
{
    public void Solve(int[][] matrix)
    {
        // Transpose
        for (int i = 0; i < (matrix.Length); i++)
        {
            for (int j = 0; j < i; j++)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }

        // Flip
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length / 2; j++)
            {
                (matrix[i][j], matrix[i][matrix[0].Length - j - 1]) = (matrix[i][matrix[0].Length - j - 1], matrix[i][j]);
            }
        }
    }
}