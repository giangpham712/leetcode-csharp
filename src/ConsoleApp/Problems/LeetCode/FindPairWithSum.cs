namespace ConsoleApp.Problems.LeetCode;

public class FindPairWithSum
{
    public (int i, int j) Solve(int[] arr, int sum)
    {
        var i = 0;
        var j = arr.Length - 1;

        while (i < j)
        {
            if (arr[i] + arr[j] == sum)
            {
                return (i, j);
            } 
            else if (arr[i] + arr[j] < sum)
            {
                i++;
            }
            else
            {
                j--;
            }
        }
        
        return (-1, -1);
    }
}