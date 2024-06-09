namespace ConsoleApp.Problems.LeetCode.RotateImage;

public class RotateImageSolution
{
    public void Solve(int[][] matrix)
    {
        var start = 0;
        var end = matrix.Length;

        while (start < end - 1)
        {
            var i = start;
            for (var j = start; j < end - 1; j++)
            {
                (matrix[j][matrix.Length - i - 1], matrix[matrix.Length - i - 1][matrix.Length - j - 1], matrix[matrix.Length - j - 1][i], matrix[i][j]) =
                    (matrix[i][j], matrix[j][matrix.Length - i - 1], matrix[matrix.Length - i - 1][matrix.Length - j - 1],
                        matrix[matrix.Length - j - 1][i]);
            }

            start++;
            end--;
        }
    }
}