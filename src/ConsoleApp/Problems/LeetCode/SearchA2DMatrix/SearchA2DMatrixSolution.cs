namespace ConsoleApp.Problems.LeetCode.SearchA2DMatrix;

public class SearchA2DMatrixSolution
{
    public bool Solve(int[][] matrix, int target)
    {
        return BinarySearch(matrix, target, 0, matrix.Length * matrix[0].Length - 1);
    }

    private bool BinarySearch(int[][] matrix, int target, int start, int end)
    {
        if (start > end)
        {
            return false;
        } 
        
        var mid = (start + end) / 2;

        var (midX, midY) = GetCoordinates(matrix, mid);

        if (matrix[midY][midX] == target)
        {
            return true;
        }
        else if (matrix[midY][midX] > target)
        {
            return BinarySearch(matrix, target, start, mid - 1);
        }
        else
        {
            return BinarySearch(matrix, target, mid + 1, end);
        }
    }

    private (int, int) GetCoordinates(int[][] matrix, int pos)
    {
        var x = pos % (matrix[0].Length);
        var y = pos / matrix[0].Length;

        return (x, y);
    }
}